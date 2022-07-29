namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// Difficulty settings.
    /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Song_Setup#difficulty">Difficulty</a>.
    /// </summary>
    public class BeatmapDifficultySection
    {
        /// <summary>
        /// Specifies how fast the health decreases.
        /// Value range is 0 to 10. Default is 5.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Beatmap/HP_drain_rate">HP drain rate</a>.
        /// </summary>
        public float HPDrainRate { get; set; } = 5f;

        /// <summary>
        /// Defines the size of the hit objects in the osu!standard mode (number of columns in osu!mania).
        /// Value range is 0 to 10. Default is 5.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Beatmap/Circle_size">Circle size</a>.
        /// </summary>
        public float CircleSize { get; set; } = 5f;

        /// <summary>
        /// The harshness of the hit window and the difficulty of spinners.
        /// Value range is 0 to 10. Default is 5.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Beatmap/Overall_difficulty">Overall difficulty</a>.
        /// </summary>
        public float OverallDifficulty { get; set; } = 5f;

        /// <summary>
        /// Defines when hit objects start to fade-in relatively to when they should be hit.
        /// Value range is 0 to 10. Default is 5.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Beatmap/Approach_rate">Approach rate</a>.
        /// </summary>
        public float ApproachRate { get; set; } = 5f;

        /// <summary>
        /// Specifies the multiplier of the slider velocity.
        /// </summary>
        public double SliderMultiplier { get; set; } = 1.4;

        /// <summary>
        /// The number of slider ticks per beat.
        /// </summary>
        public double SliderTickRate { get; set; } = 1.0;
    }
}
