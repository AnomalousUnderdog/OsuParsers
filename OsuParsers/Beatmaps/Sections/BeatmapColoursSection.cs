using System.Collections.Generic;
using System.Drawing;

namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// Section with colours properties.
    /// </summary>
    public class BeatmapColoursSection
    {
        /// <summary>
        /// Additive combo colours.
        /// </summary>
        public List<Color> ComboColours { get; set; } = new List<Color>();

        /// <summary>
        /// Additive slider track colour.
        /// </summary>
        public Color SliderTrackOverride { get; set; }

        /// <summary>
        /// Slider border colour.
        /// </summary>
        public Color SliderBorder { get; set; }
    }
}
