using Dotneteer.BlazorBoard.Components;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public string SelectedThemeId { get; set; }

        /// <summary>
        /// The selected theme item
        /// </summary>
        public ComboDataItem SelectedTheme => Themes.FirstOrDefault(t => t.Id == SelectedThemeId);

        /// <summary>
        /// The available demo items
        /// </summary>
        public List<ComboDataItem> Demos { get; set; }

        /// <summary>
        /// The ID of the selected demo
        /// </summary>
        public string SelectedDemoId { get; set; }

        /// <summary>
        /// The selected demo item
        /// </summary>
        public ComboDataItem SelectedDemo => Demos.FirstOrDefault(d => d.Id == SelectedDemoId);

        /// <summary>
        /// The available scenario items
        /// </summary>
        public List<ComboDataItem> Scenarios { get; set; }

        /// <summary>
        /// The ID of the selected scenario
        /// </summary>
        public string SelectedScenarioId { get; set; }

        /// <summary>
        /// The selected scenario item
        /// </summary>
        public ComboDataItem SelectedScenario => Scenarios.FirstOrDefault(s => s.Id == SelectedScenarioId);

        /// <summary>
        /// The available source file items
        /// </summary>
        public List<ComboDataItem> SourceFiles { get; set; }

        /// <summary>
        /// The ID of the selecte source file item
        /// </summary>
        public string SelectedSourceFileName { get; set; }

        /// <summary>
        /// The selected source file item
        /// </summary>
        public ComboDataItem SelectedSourceFile => SourceFiles.FirstOrDefault(s => s.Id == SelectedSourceFileName);

        /// <summary>
        /// Creates a deep clone of this instance
        /// </summary>
        /// <returns>Cloned state instance</returns>
        public BlazorBoardState Clone(Action<BlazorBoardState> action = null)
        {
            var clone = new BlazorBoardState
            {
                Themes = new List<ComboDataItem>(Themes),
                SelectedThemeId = SelectedThemeId,
                Demos = new List<ComboDataItem>(Demos),
                SelectedDemoId = SelectedDemoId,
                Scenarios = new List<ComboDataItem>(Scenarios),
                SelectedScenarioId = SelectedScenarioId,
                SourceFiles = new List<ComboDataItem>(SourceFiles),
                SelectedSourceFileName = SelectedSourceFileName
            };
            action?.Invoke(clone);
            return clone;
        }
    }
}
