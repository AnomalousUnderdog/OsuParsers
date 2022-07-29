using OsuParsers.Enums.Beatmaps;

namespace OsuParsers.Beatmaps.Objects
{
    public class TimingPoint
    {
        /// <summary>
        /// Offset in ms.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Length of a single beat in ms.
        /// </summary>
        public double BeatLength { get; set; }

        /// <summary>
        /// Time signature, used in editor. (e.g. SimpleTriple, SimpleQuadruple)
        /// </summary>
        public TimeSignature TimeSignature { get; set; }

        /// <summary>
        /// TimingPoint's sample set. (e.g. Normal, Soft)
        /// </summary>
        public SampleSet SampleSet { get; set; }

        /// <summary>
        /// Index of custom sound sample.
        /// </summary>
        public int CustomSampleSet { get; set; }

        /// <summary>
        /// Volume of samples from 0 to 100.
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// Is parameters inherited from parent timing point?
        /// </summary>
        public bool Inherited { get; set; }

        /// <summary>
        /// Effects of this timing point. (e.g. Kiai or OmitFirstBarLine)
        /// </summary>
        public Effects Effects { get; set; }
    }
}
