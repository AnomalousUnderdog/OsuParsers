using OsuParsers.Enums.Beatmaps;

namespace OsuParsers.Beatmaps.Objects
{
    public class Extras
    {
        public Extras() { }
        public Extras(SampleSet sampleSet, SampleSet additionSet, int customIndex, int volume, string sampleFileName)
        {
            SampleSet = sampleSet;
            AdditionSet = additionSet;
            CustomIndex = customIndex;
            Volume = volume;
            SampleFileName = sampleFileName;
        }

        /// <summary>
        /// SampleSet that changes the sample set of the normal Hit Sound.
        /// </summary>
        public SampleSet SampleSet { get; set; }

        /// <summary>
        /// SampleSet that changes the sample set for the other Hit Sounds. (whistle, finish, clap)
        /// </summary>
        public SampleSet AdditionSet { get; set; }

        /// <summary>
        /// Custom SampleSet index. (e.g. 3 in soft-hitnormal3.wav)
        /// </summary>
        public int CustomIndex { get; set; }

        /// <summary>
        /// Volume of the sample from 0 to 100.
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// This names an audio file in the folder to play instead of sounds from SampleSets.
        /// </summary>
        public string SampleFileName { get; set; }
    }
}
