using System;
using System.Collections.Generic;
using Dotneteer.BlazorBoard.Client.Core;
using Dotneteer.BlazorBoard.Components;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// This class represent the service that manages the Blazor Board
    /// application's state
    /// </summary>
    public class BlazorBoardStateService : IBlazorBoardStateService
    {
        /// <summary>
        /// The current application state
        /// </summary>
        public BlazorBoardState State { get; private set; }

        /// <summary>
        /// This event is raised whenever the state of the application changes.
        /// </summary>
        public event EventHandler<StateChangedEventArgs> AppStateChanged;

        /// <summary>
        /// Sets the initial state of the application
        /// </summary>
        public void InitAppState(
            List<ComboDataItem> themes,
            List<ComboDataItem> demos,
            List<ComboDataItem> scenarios,
            List<ComboDataItem> sourceFiles)
        {
            if (State != null) return;
            var oldState = State;
            var newState = new BlazorBoardState
            {
                Themes = themes ?? throw new ArgumentNullException(nameof(themes)),
                SelectedThemeId = (themes?.Count ?? -1) > 0 ? themes[0].Id : null,
                Demos = demos ?? throw new ArgumentNullException(nameof(demos)),
                SelectedDemoId = (demos?.Count ?? -1) > 0 ? demos[0].Id : null,
                Scenarios = scenarios ?? throw new ArgumentNullException(nameof(scenarios)),
                SelectedScenarioId = (scenarios?.Count ?? -1) > 0 ? scenarios[0].Id : null,
                SourceFiles = sourceFiles ?? throw new ArgumentNullException(nameof(sourceFiles)),
                SelectedSourceFileName  = (sourceFiles?.Count ?? -1) > 0 ? sourceFiles[0].Id : null,
            };
            State = newState;
            AppStateChanged?.Invoke(this, new StateChangedEventArgs(oldState, State));
        }

        /// <summary>
        /// Sets the list of themes
        /// </summary>
        /// <param name="themes">List of themes</param>
        public void SetThemeList(List<ComboDataItem> themes)
        {
            if (State.Themes == themes) return;
            var oldState = State;
            State = State.Clone(s =>
            {
                s.Themes = themes;
                s.SelectedThemeId = themes.Count > 0 ? themes[0].Id : null;
            });
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            ThemeListChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the list of demos changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> ThemeListChanged;

        /// <summary>
        /// Selects a new application theme
        /// </summary>
        /// <param name="themeId">ID of the new theme</param>
        public void SelectTheme(string themeId)
        {
            if (State.SelectedThemeId == themeId) return;
            var oldState = State;
            State = State.Clone(s => s.SelectedThemeId = themeId);
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            SelectedThemeChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the current theme changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SelectedThemeChanged;

        public void SetDemoList(List<ComboDataItem> demos)
        {
            if (State.Demos == demos) return;
            var oldState = State;
            State = State.Clone(s => {
                s.Demos = demos;
                s.SelectedDemoId = demos.Count > 0 ? demos[0].Id : null;
            });
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            DemoListChanged?.Invoke(this, args);
            SelectedDemoChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the list of demos changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> DemoListChanged;

        /// <summary>
        /// Selects a demo in the demo list
        /// </summary>
        /// <param name="demoId">ID of the selected demo</param>
        public void SelectDemo(string demoId)
        {
            if (State.SelectedDemoId == demoId) return;
            var oldState = State;
            State = State.Clone(s => s.SelectedDemoId = demoId);
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            SelectedDemoChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the selected demo changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SelectedDemoChanged;

        /// <summary>
        /// Sets the list of scenarios
        /// </summary>
        /// <param name="scenarios">List of scenarios</param>
        public void SetScenarioList(List<ComboDataItem> scenarios)
        {
            if (State.Scenarios == scenarios) return;
            var oldState = State;
            State = State.Clone(s =>
            {
                s.Scenarios = scenarios;
                s.SelectedScenarioId = scenarios.Count > 0 ? scenarios[0].Id : null;
            });
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            ScenarioListChanged?.Invoke(this, args);
            SelectedScenarioChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the list of scenarios changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> ScenarioListChanged;

        /// <summary>
        /// Selects a scenario in the scenario list
        /// </summary>
        /// <param name="scenarioId">ID of the selected scenario</param>
        public void SelectScenario(string scenarioId)
        {
            if (State.SelectedScenarioId == scenarioId) return;
            var oldState = State;
            State = State.Clone(s => s.SelectedScenarioId = scenarioId);
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            SelectedScenarioChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the selected scenarios changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SelectedScenarioChanged;

        /// <summary>
        /// Sets the list of source files
        /// </summary>
        /// <param name="sourceFiles">List of source files</param>
        public void SetSourceFileList(List<ComboDataItem> sourceFiles)
        {
            if (State.SourceFiles == sourceFiles) return;
            var oldState = State;
            State = State.Clone(s =>
            {
                s.SourceFiles = sourceFiles;
                s.SelectedSourceFileName = sourceFiles.Count > 0 ? sourceFiles[0].Id : null;
            });
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            SourceFileListChanged?.Invoke(this, args);
            SelectedSourceFileChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the list of source files changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SourceFileListChanged;

        /// <summary>
        /// Selects a source file in the source file list
        /// </summary>
        /// <param name="sourceFile">Selected source file</param>
        public void SelectSourceFile(string sourceFile)
        {
            if (State.SelectedSourceFileName == sourceFile) return;
            var oldState = State;
            State = State.Clone(s => s.SelectedSourceFileName = sourceFile);
            var args = new StateChangedEventArgs(oldState, State);
            AppStateChanged?.Invoke(this, args);
            SelectedSourceFileChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the selected scenarios changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SelectedSourceFileChanged;
    }
}
