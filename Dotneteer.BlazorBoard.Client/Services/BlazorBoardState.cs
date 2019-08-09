using Dotneteer.BlazorBoard.Components;
using System;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// An instance of this class represents the state of the Blazor Board app
    /// </summary>
    public class BlazorBoardState
    {
        /// <summary>
        /// The available theme items
        /// </summary>
        public List<ComboDataItem> Themes { get; set; }

        /// <summary>
        /// The ID of the selected application theme
        /// </summary>
        public string SelectedTheme { get; set; }

        /// <summary>
        /// The available demo items
        /// </summary>
        public List<ComboDataItem> Demos { get; set; }

        /// <summary>
        /// The ID of the selected demo
        /// </summary>
        public string SelectedDemo { get; set; }

        /// <summary>
        /// The available scenario items
        /// </summary>
        public List<ComboDataItem> Scenarios { get; set; }

        /// <summary>
        /// The ID of the selected scenario
        /// </summary>
        public string SelectedScenario { get; set; }

        /// <summary>
        /// The available source file items
        /// </summary>
        public List<ComboDataItem> SourceFiles { get; set; }

        /// <summary>
        /// The ID of the selecte source file item
        /// </summary>
        public string SelectedSourceFile { get; set; }

        /// <summary>
        /// Creates a deep clone of this instance
        /// </summary>
        /// <returns>Cloned state instance</returns>
        public BlazorBoardState Clone(Action<BlazorBoardState> action = null)
        {
            var clone = new BlazorBoardState
            {
                Themes = new List<ComboDataItem>(Themes),
                SelectedTheme = SelectedTheme,
                Demos = new List<ComboDataItem>(Demos),
                SelectedDemo = SelectedDemo,
                Scenarios = new List<ComboDataItem>(Scenarios),
                SelectedScenario = SelectedScenario,
                SourceFiles = new List<ComboDataItem>(SourceFiles),
                SelectedSourceFile = SelectedSourceFile
            };
            action?.Invoke(clone);
            return clone;
        }
    }
}
