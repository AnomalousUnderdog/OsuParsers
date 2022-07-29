using OsuParsers.Enums.Beatmaps;
using UnityEngine;

namespace OsuParsers.Beatmaps.Objects
{
    /// <summary>
    /// Represents osu!standard Spinner. Base class for TaikoSpinner and CatchSpinner.
    /// Properties are the same as the HitObject's.
    /// </summary>
    public class Spinner : HitObject
    {
        public Spinner(Vector2 position, int startTime, int endTime, HitSoundType hitSound, Extras extras, bool isNewCombo, int comboOffset)
            : base(position, startTime, endTime, hitSound, extras, isNewCombo, comboOffset)
        {
        }
    }
}
