using CUE4Parse.UE4.Assets.Exports.Sound;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Misc;

namespace CUE4Parse.GameTypes.FN.Assets.Exports.Sound
{
    [StructFallback]
    public class FDialogueWaveParameter
    {
        public UDialogueWave DialogueWave;
        public FContext Context;

        public FDialogueWaveParameter(FStructFallback fallback)
        {
            Context = fallback.Get<FContext>(nameof(Context));
            DialogueWave = fallback.Get<UDialogueWave>(nameof(DialogueWave));
        }
    }

    [StructFallback]
    public class FDialogueWave
    {
        public string SpokenText;
        public FContextMappings[] ContextMappings;
        public FGuid LocalizationGUID;

        public FDialogueWave(FStructFallback fallback)
        {
            SpokenText = fallback.GetOrDefault<string>(nameof(SpokenText));
            ContextMappings = fallback.GetOrDefault<FContextMappings[]>(nameof(ContextMappings));
            LocalizationGUID = fallback.GetOrDefault<FGuid>(nameof(LocalizationGUID));
        }
    }

    [StructFallback]
    public class FContextMappings
    {
        public FContext Context;
        public USoundWave SoundWave;
        public string LocalizationKeyFormat;

        public FContextMappings(FStructFallback fallback)
        {
            Context = fallback.GetOrDefault<FContext>(nameof(Context));
            SoundWave = fallback.GetOrDefault<USoundWave>(nameof(SoundWave));
            LocalizationKeyFormat = fallback.GetOrDefault<string>(nameof(LocalizationKeyFormat));
        }
    }

    [StructFallback]
    public class FContext
    {
        public FDialogueVoice Speaker;
        public object? Targets;

        public FContext(FStructFallback fallback)
        {
            Speaker = fallback.GetOrDefault<FDialogueVoice>(nameof(Speaker));
            Targets = fallback.GetOrDefault<object?>(nameof(Targets));
        }
    }

    [StructFallback]
    public class FDialogueVoice
    {
        public FGuid LocalizationGUID;

        public FDialogueVoice(FStructFallback fallback)
        {
            LocalizationGUID = fallback.GetOrDefault<FGuid>(nameof(LocalizationGUID));
        }
    }
}
