using OsuParsers.Beatmaps.Sections.Events;
using OsuParsers.Storyboards;
using System.Collections.Generic;

namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// Beatmap and storyboard graphic events.
    /// </summary>
    public class BeatmapEventsSection
    {
        /// <summary>
        /// The filename specifies the location of the background image relative to the beatmap directory.
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// The filename specifies the location of the video relative to the beatmap directory.
        /// </summary>
        public string Video { get; set; }

        /// <summary>
        /// Video offset in ms.
        /// </summary>
        public int VideoOffset { get; set; }

        /// <summary>
        /// List of break periods.
        /// </summary>
        public List<BeatmapBreakEvent> Breaks { get; set; } = new List<BeatmapBreakEvent>();

        /// <summary>
        /// Storyboard of this beatmap.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Storyboard/Scripting">Storyboard scripting</a>.
        /// </summary>
        public Storyboard Storyboard { get; set; } = new Storyboard();
    }
}
