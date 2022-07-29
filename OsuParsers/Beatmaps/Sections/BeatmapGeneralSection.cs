using OsuParsers.Enums;
using OsuParsers.Enums.Beatmaps;

namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// General information about the beatmap.
    /// See also official docs on <a href="https://osu.ppy.sh/wiki/en/Client/File_formats/Osu_%28file_format%29#general">Beatmap General Section</a>.
    /// </summary>
    public class BeatmapGeneralSection
    {
        /// <summary>
        /// Specifies the location of the audio file relative to the current folder.
        /// </summary>
        public string AudioFilename { get; set; }

        /// <summary>
        /// The amount of milliseconds added before the audio file begins playing.
        /// </summary>
        public int AudioLeadIn { get; set; }

        /// <summary>
        /// Defines offset time in milliseconds when the audio file should begin playing,
        /// when selected in the song selection menu.
        /// </summary>
        public int PreviewTime { get; set; } = -1;

        /// <summary>
        /// Specifies whether or not a countdown occurs before the first hit object appears.
        /// </summary>
        public bool Countdown { get; set; } = true;

        /// <summary>
        /// Specifies default set of hit sounds used throughout the beatmap,
        /// which can be overriden by a <see cref="OsuParsers.Beatmaps.Objects.TimingPoint"/>.
        /// </summary>
        public SampleSet SampleSet { get; set; } = SampleSet.Normal;

        /// <summary>
        /// Multiplier for the threshold in time where hit objects placed close together stack.
        /// Value range is 0.0 to 1.0.
        /// </summary>
        public double StackLeniency { get; set; } = 0.7f;

        /// <summary>
        /// Defines the game mode of the beatmap.
        /// </summary>
        public Ruleset Mode { get; set; } = Ruleset.Standard;

        /// <summary>
        /// Id of the game mode. (0=osu!, 1=Taiko, 2=Catch the Beat, 3=osu!mania)
        /// </summary>
        public int ModeId { get; set; }

        /// <summary>
        /// Specifies whether the letterbox appears during breaks.
        /// </summary>
        public bool LetterboxInBreaks { get; set; }

        /// <summary>
        /// Specifies whether or not the storyboard should be widescreen.
        /// </summary>
        public bool WidescreenStoryboard { get; set; }

        /// <summary>
        /// Specifies whether or not display the storyboard in front of combo fire. Deprecated.
        /// </summary>
        public bool StoryFireInFront { get; set; }

        /// <summary>
        /// Whether or not the special N+1 style key layout is used for osu!mania.
        /// </summary>
        public bool SpecialStyle { get; set; }

        /// <summary>
        /// Specifies whether to show epilepsy warning at the beginning of the beatmap or not.
        /// </summary>
        public bool EpilepsyWarning { get; set; }

        /// <summary>
        /// Specifies whether or not the storyboard can use user's skin resources.
        /// </summary>
        public bool UseSkinSprites { get; set; }

        /// <summary>
        /// Total amount of HitCircles in the beatmap.
        /// </summary>
        public int CirclesCount { get; set; }

        /// <summary>
        /// Total amount of Sliders in the beatmap.
        /// </summary>
        public int SlidersCount { get; set; }

        /// <summary>
        /// Total amount of Spinners in the beatmap.
        /// </summary>
        public int SpinnersCount { get; set; }

        /// <summary>
        /// Beatmap length in ms.
        /// </summary>
        public int Length { get; set; }
    }
}
