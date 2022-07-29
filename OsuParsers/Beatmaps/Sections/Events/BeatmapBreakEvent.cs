namespace OsuParsers.Beatmaps.Sections.Events
{
    public class BeatmapBreakEvent
    {
        /// <summary>
        /// Start time of the break, in milliseconds from the beginning of the beatmap's audio.
        /// </summary>
        public int StartTime { get; private set; }

        /// <summary>
        /// End time of the break, in milliseconds from the beginning of the beatmap's audio.
        /// </summary>
        public int EndTime { get; private set; }

        public BeatmapBreakEvent(int startTime, int endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
