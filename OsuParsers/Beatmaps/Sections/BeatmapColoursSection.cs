using System.Collections.Generic;
using UnityEngine;

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
        public List<Color32> ComboColours { get; set; } = new List<Color32>();

        /// <summary>
        /// Additive slider track colour.
        /// </summary>
        public Color32 SliderTrackOverride { get; set; }

        /// <summary>
        /// Slider border colour.
        /// </summary>
        public Color32 SliderBorder { get; set; }
    }
}
