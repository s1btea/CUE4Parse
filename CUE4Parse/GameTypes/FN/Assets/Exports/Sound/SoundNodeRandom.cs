using CUE4Parse.UE4.Assets.Exports.Sound.Node;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.GameTypes.FN.Assets.Exports.Sound
{
    [StructFallback]
    public class FSoundNodeRandom
    {
        public float[] Weights;
        public USoundNodeWavePlayer[] ChildNodes;

        public FSoundNodeRandom(FStructFallback fallback)
        {
            Weights = fallback.Get<float[]>(nameof(Weights));
            ChildNodes = fallback.Get<USoundNodeWavePlayer[]>(nameof(ChildNodes));
        }
    }
}