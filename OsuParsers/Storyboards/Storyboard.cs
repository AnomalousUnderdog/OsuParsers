using OsuParsers.Enums.Storyboards;
using OsuParsers.Storyboards.Interfaces;
using System.Collections.Generic;
using System.IO;
using OsuParsers.Writers;

namespace OsuParsers.Storyboards
{
    /// <summary>
    /// See official docs on <a href="https://osu.ppy.sh/wiki/en/Storyboard/Scripting">Storyboard scripting</a>.
    /// </summary>
    public class Storyboard
    {
        /// <summary>
        /// Storyboard layer that overrides default beatmap background.
        /// </summary>
        public List<IStoryboardObject> BackgroundLayer = new List<IStoryboardObject>();

        /// <summary>
        /// Storyboard layer that appears only when player is in fail state.
        /// </summary>
        public List<IStoryboardObject> FailLayer = new List<IStoryboardObject>();

        /// <summary>
        /// Storyboard layer that appears only when player is in pass state.
        /// </summary>
        public List<IStoryboardObject> PassLayer = new List<IStoryboardObject>();

        /// <summary>
        /// The "highest" layer of storyboard.
        /// </summary>
        public List<IStoryboardObject> ForegroundLayer = new List<IStoryboardObject>();

        /// <summary>
        /// Storyboard layer that sits in front of hit objects.
        /// </summary>
        public List<IStoryboardObject> OverlayLayer = new List<IStoryboardObject>();

        /// <summary>
        /// Storyboard layer that contains audio samples.
        /// </summary>
        public List<IStoryboardObject> SamplesLayer = new List<IStoryboardObject>();

        /// <summary>
        /// Contains pairs of variable names and values.
        /// </summary>
        public Dictionary<string, string> Variables = new Dictionary<string, string>();

        /// <summary>
        /// Returns specified storyboard layer.
        /// </summary>
        public List<IStoryboardObject> GetLayer(StoryboardLayer layer)
        {
            switch (layer)
            {
                case StoryboardLayer.Background:
                    return BackgroundLayer;
                case StoryboardLayer.Fail:
                    return FailLayer;
                case StoryboardLayer.Pass:
                    return PassLayer;
                case StoryboardLayer.Foreground:
                    return ForegroundLayer;
                case StoryboardLayer.Overlay:
                    return OverlayLayer;
                case StoryboardLayer.Samples:
                    return SamplesLayer;
                default:
                    return BackgroundLayer;
            }
        }

        /// <summary>
        /// Saves this <see cref="Storyboard"/> to the specified path.
        /// </summary>
        public void Save(string path)
        {
            File.WriteAllLines(path, StoryboardEncoder.Encode(this));
        }
    }
}
