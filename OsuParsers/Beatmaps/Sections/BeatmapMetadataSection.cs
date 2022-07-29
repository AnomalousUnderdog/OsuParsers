using OsuParsers.Helpers;

namespace OsuParsers.Beatmaps.Sections
{
    /// <summary>
    /// Information used to identify the beatmap.
    /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/Song_Setup#song-and-map-metadata">Metadata</a>.
    /// </summary>
    public class BeatmapMetadataSection
    {
        /// <summary>
        /// The title of the song limited to ASCII characters.
        /// For foreign/Eastern titles, this is the romanised version.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The title of the song with unicode support.
        /// </summary>
        public string TitleUnicode { get; set; }

        /// <summary>
        /// The name of the song's artist limited to ASCII characters.
        /// For foreign/Eastern names, this is the romanised version.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// The name of the song's artist with unicode support.
        /// </summary>
        public string ArtistUnicode { get; set; }

        /// <summary>
        /// The username of the mapper.
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// The name of the beatmap's difficulty.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Original media the song was produced for.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Search terms.
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// Search terms in one comma-separated string.
        /// </summary>
        public string TagsString
        {
            get => Tags.Join();
            set => Tags = value.Split(' ');
        }

        /// <summary>
        /// Difficulty ID.
        /// </summary>
        public int BeatmapID { get; set; }

        /// <summary>
        /// Beatmap ID.
        /// </summary>
        public int BeatmapSetID { get; set; }
    }
}
