using CUE4Parse.UE4.Assets.Exports.Sound;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.GameTypes.FN.Assets.Exports.Sound;


[StructFallback]
public class USoundSequenceData
{
    public USoundCue Sound;
    public float Delay;

    public USoundSequenceData(FStructFallback fallback)
    {
        Sound = fallback.GetOrDefault<USoundCue>(nameof(Sound));
        Delay = fallback.GetOrDefault<float>(nameof(Delay));
    }
}