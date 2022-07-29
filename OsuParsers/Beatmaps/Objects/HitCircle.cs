using OsuParsers.Enums.Beatmaps;
using System.Numerics;

namespace OsuParsers.Beatmaps.Objects
{
    /// <summary>
    /// Represents osu!standard HitCircle. Base class for <see cref="Taiko.TaikoHit"/>, <see cref="Catch.CatchFruit"/> and <see cref="Mania.ManiaNote"/> classes.
    /// Properties are the same as the HitObject's.
    /// </summary>
    public class HitCircle : HitObject
    {
        public HitCircle(Vector2 position, int startTime, int endTime, HitSoundType hitSound, Extras extras, bool isNewCombo, int comboOffset)
            : base(position, startTime, endTime, hitSound, extras, isNewCombo, comboOffset)
        { }
    }
}
