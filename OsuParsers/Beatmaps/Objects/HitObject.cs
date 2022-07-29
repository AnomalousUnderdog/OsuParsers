using OsuParsers.Enums.Beatmaps;
using System;
using System.Numerics;

namespace OsuParsers.Beatmaps.Objects
{
    /// <summary>
    /// Base class for all objects.
    /// </summary>
    public class HitObject
    {
        /// <summary>
        /// HitObject's position.
        /// </summary>
        public Vector2 Position { get; set; } = Vector2.Zero;

        /// <summary>
        /// Start time offset of this object.
        /// </summary>
        public int StartTime { get; set; } = 0;

        /// <summary>
        /// End time offset of this object.
        /// </summary>
        public int EndTime { get; set; } = 0;

        /// <summary>
        /// HitSound of this object (e.g. Normal, Whistle)
        /// </summary>
        public HitSoundType HitSound { get; set; } = 0;

        /// <summary>
        /// Class which contains Extras properties.
        /// </summary>
        public Extras Extras { get; set; } = new Extras();

        /// <summary>
        /// Is it a new combo?
        /// </summary>
        public bool IsNewCombo { get; set; } = false;

        /// <summary>
        /// Represents how many combo colours this object is skipping.
        /// </summary>
        public int ComboOffset { get; set; } = 0;

        public HitObject() { }
        public HitObject(Vector2 position, int startTime, int endTime, HitSoundType hitSound, Extras extras, bool isNewCombo, int comboOffset)
        {
            Position = position;
            StartTime = startTime;
            EndTime = endTime;
            HitSound = hitSound;
            Extras = extras;
            IsNewCombo = isNewCombo;
            ComboOffset = comboOffset;
        }

        /// <summary>
        /// Start time timespan of this object.
        /// </summary>
        public TimeSpan StartTimeSpan => TimeSpan.FromMilliseconds(StartTime);

        /// <summary>
        /// End time timespan of this object.
        /// </summary>
        public TimeSpan EndTimeSpan => TimeSpan.FromMilliseconds(EndTime);

        /// <summary>
        /// Total timespan of this object.
        /// </summary>
        public TimeSpan TotalTimeSpan => TimeSpan.FromMilliseconds(EndTime - StartTime);

        /// <summary>
        /// The distance from this object to another.
        /// </summary>
        /// <param name="otherObject"></param>
        /// <returns></returns>
        public float DistanceFrom(HitObject otherObject) => Vector2.Distance(Position, otherObject.Position);
    }
}
