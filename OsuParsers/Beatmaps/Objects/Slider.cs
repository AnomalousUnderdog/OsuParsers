using OsuParsers.Enums.Beatmaps;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace OsuParsers.Beatmaps.Objects
{
    /// <summary>
    /// Represents osu!standard Slider. Base class for TaikoDrumroll and CatchDroplets.
    /// </summary>
    public class Slider : HitObject
    {
        public Slider(Vector2 position, int startTime, int endTime, HitSoundType hitSound, CurveType type, List<Vector2> points,
            int repeats, double pixelLength, bool isNewCombo, int comboOffset, List<HitSoundType> edgeHitSounds = null,
            List<Tuple<SampleSet, SampleSet>> edgeAdditions = null, Extras extras = null)
            : base(position, startTime, endTime, hitSound, extras, isNewCombo, comboOffset)
        {
            CurveType = type;
            SliderPoints = points;
            Repeats = repeats;
            PixelLength = pixelLength;
            EdgeHitSounds = edgeHitSounds;
            EdgeAdditions = edgeAdditions;
        }

        /// <summary>
        /// Curve type of this slider. (e.g. Bezier, Linear)
        /// </summary>
        public CurveType CurveType { get; set; }

        /// <summary>
        /// Anchor points used to construct the slider.
        /// </summary>
        public List<Vector2> SliderPoints { get; set; } = new List<Vector2>();

        /// <summary>
        /// Amount of times the player has to follow the slider's curve back-and-forth before the slider is complete.
        /// Despite the fact that this property is named Repeats, repeats will actually happen only at value starting at 2.
        /// </summary>
        public int Repeats { get; set; }

        /// <summary>
        /// Slider length in <a href="https://osu.ppy.sh/wiki/en/Client/Beatmap_editor/osu%21_pixel">osu! pixels</a>.
        /// </summary>
        public double PixelLength { get; set; }

        /// <summary>
        /// Hit sounds that play when hitting edges of the slider's curve.
        /// The first sound is the one that plays when the slider is first clicked,
        /// and the last sound is the one that plays when the slider's end is hit.
        /// </summary>
        public List<HitSoundType> EdgeHitSounds { get; set; }

        /// <summary>
        /// Sample sets used for the <see cref="EdgeHitSounds"/>.
        /// Each set is in the format (normalSet, additionSet).
        /// normalSet is the sample set of the normal sound, additionSet is the sample set of the whistle, finish, and clap sounds.
        /// </summary>
        public List<Tuple<SampleSet, SampleSet>> EdgeAdditions { get; set; }
    }
}
