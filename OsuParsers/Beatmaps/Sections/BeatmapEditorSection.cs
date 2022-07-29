using OsuParsers.Helpers;
using System.Linq;

namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// Saved settings for the beatmap editor.
    /// These options are only relevant when opening maps in the beatmap editor.
    /// They do not affect gameplay.
    /// </summary>
    public class BeatmapEditorSection
    {
        /// <summary>
        /// Array of times in milliseconds of editor bookmarks.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Compose#bottom-(song's-timeline)">bookmarks</a>.
        /// </summary>
        public int[] Bookmarks { get; set; }

        /// <summary>
        /// A list of comma-separated times of editor bookmarks.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Compose#bottom-(song's-timeline)">bookmarks</a>.
        /// </summary>
        public string BookmarksString
        {
            get => Bookmarks.Join(',');
            set
            {
                var valueArray = value.Split(',').ToList();
                Bookmarks = valueArray.ConvertAll(e => System.Convert.ToInt32(e)).ToArray();
            }
        }

        /// <summary>
        /// A multiplier for the "Distance Snap" feature.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Distance_snap">Distance Snap</a>.
        /// </summary>
        public double DistanceSpacing { get; set; }

        /// <summary>
        /// Specifies the beat division for placing objects.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Beat_Snap_Divisor">Beat Snap Divisor</a>.
        /// </summary>
        public int BeatDivisor { get; set; }

        /// <summary>
        /// Specifies the size of the grid for the "Grid Snap" feature.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Beatmapping/Grid_snapping">Grid snapping</a>.
        /// </summary>
        public int GridSize { get; set; }

        /// <summary>
        /// Specifies the zoom in the editor timeline.
        /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Compose#top-left-(hit-objects-timeline)">object timeline zoom</a>.
        /// </summary>
        public float TimelineZoom { get; set; }
    }
}
