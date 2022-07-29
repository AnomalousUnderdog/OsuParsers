using OsuParsers.Beatmaps.Objects;
using OsuParsers.Beatmaps.Sections;
using OsuParsers.Helpers;
using System.Collections.Generic;
using System.IO;
using OsuParsers.Encoders;

namespace OsuParsers.Beatmaps
{
    /// <summary>
    /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Client/File_formats/Osu_%28file_format%29">Osu file format</a>
    /// </summary>
    public class Beatmap
    {
        public const int LATEST_OSZ_VERSION = 14;

        /// <summary>
        /// .osu file format version (e.g. 12, 14)
        /// </summary>
        public int Version { get; set; } = LATEST_OSZ_VERSION;

        /// <inheritdoc cref="BeatmapGeneralSection"/>
        public BeatmapGeneralSection GeneralSection { get; set; } = new BeatmapGeneralSection();

        /// <inheritdoc cref="BeatmapEditorSection"/>
        public BeatmapEditorSection EditorSection { get; set; } = new BeatmapEditorSection();

        /// <inheritdoc cref="BeatmapMetadataSection"/>
        public BeatmapMetadataSection MetadataSection { get; set; } = new BeatmapMetadataSection();

        /// <inheritdoc cref="BeatmapDifficultySection"/>
        public BeatmapDifficultySection DifficultySection { get; set; } = new BeatmapDifficultySection();

        /// <inheritdoc cref="BeatmapEventsSection"/>
        public BeatmapEventsSection EventsSection { get; set; } = new BeatmapEventsSection();

        /// <inheritdoc cref="BeatmapColoursSection"/>
        public BeatmapColoursSection ColoursSection { get; set; } = new BeatmapColoursSection();

        /// <summary>
        /// List of all timing points.
        /// </summary>
        public List<TimingPoint> TimingPoints { get; set; } = new List<TimingPoint>();

        /// <summary>
        /// List of all hit objects.
        /// </summary>
        public List<HitObject> HitObjects { get; set; } = new List<HitObject>();

        /// <summary>
        /// Returns nearest beat length from the given offset.
        /// </summary>
        /// <param name="offset">Time in song. Should be in milliseconds.</param>
        /// <returns></returns>
        public double BeatLengthAt(int offset)
        {
            if (TimingPoints.Count == 0)
                return 0;

            int timingPoint = 0;
            int samplePoint = 0;

            for (int i = 0; i < TimingPoints.Count; i++)
            {
                if (TimingPoints[i].Offset <= offset)
                {
                    if (TimingPoints[i].Inherited)
                        samplePoint = i;
                    else
                        timingPoint = i;
                }
            }

            double multiplier = 1;

            if (samplePoint > timingPoint && TimingPoints[samplePoint].BeatLength < 0)
                multiplier = MathHelper.CalculateBpmMultiplier(TimingPoints[samplePoint]);

            return TimingPoints[timingPoint].BeatLength * multiplier;
        }

        /// <summary>
        /// Saves this <see cref="Beatmap"/> to the specified path.
        /// </summary>
        public void Save(string path)
        {
            File.WriteAllLines(path, BeatmapEncoder.Encode(this));
        }
    }
}
