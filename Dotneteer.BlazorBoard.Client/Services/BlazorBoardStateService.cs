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
        private BlazorBoardState _state;

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
            if (_state != null) return;
            var oldState = _state;
            var newState = new BlazorBoardState
            {
                Themes = themes ?? throw new ArgumentNullException(nameof(themes)),
                SelectedTheme = (themes?.Count ?? -1) > 0 ? themes[0].Id : null,
                Demos = demos ?? throw new ArgumentNullException(nameof(demos)),
                SelectedDemo = (demos?.Count ?? -1) > 0 ? demos[0].Id : null,
                Scenarios = scenarios ?? throw new ArgumentNullException(nameof(scenarios)),
                SelectedScenario = (scenarios?.Count ?? -1) > 0 ? scenarios[0].Id : null,
                SourceFiles = sourceFiles ?? throw new ArgumentNullException(nameof(sourceFiles)),
                SelectedSourceFile  = (sourceFiles?.Count ?? -1) > 0 ? sourceFiles[0].Id : null,
            };
            _state = newState;
            AppStateChanged?.Invoke(this, new StateChangedEventArgs(oldState, _state));
        }

        /// <summary>
        /// Sets the list of themes
        /// </summary>
        /// <param name="themes">List of themes</param>
        public void SetThemeList(List<ComboDataItem> themes)
        {
            if (_state.Themes == themes) return;
            var oldState = _state;
            _state = _state.Clone(s => s.Themes = themes);
            var args = new StateChangedEventArgs(oldState, _state);
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
            if (_state.SelectedTheme == themeId) return;
            var oldState = _state;
            _state = _state.Clone(s => s.SelectedTheme = themeId);
            var args = new StateChangedEventArgs(oldState, _state);
            AppStateChanged?.Invoke(this, args);
            ThemeChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the current theme changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> ThemeChanged;

        public void SetDemoList(List<ComboDataItem> demos)
        {
            if (_state.Demos == demos) return;
            var oldState = _state;
            _state = _state.Clone(s => s.Demos = demos);
            var args = new StateChangedEventArgs(oldState, _state);
            AppStateChanged?.Invoke(this, args);
            DemoListChanged?.Invoke(this, args);
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
            if (_state.SelectedDemo == demoId) return;
            var oldState = _state;
            _state = _state.Clone(s => s.SelectedDemo = demoId);
            var args = new StateChangedEventArgs(oldState, _state);
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
            if (_state.Scenarios == scenarios) return;
            var oldState = _state;
            _state = _state.Clone(s => s.Scenarios = scenarios);
            var args = new StateChangedEventArgs(oldState, _state);
            AppStateChanged?.Invoke(this, args);
            ScenarioListChanged?.Invoke(this, args);
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
            if (_state.SelectedScenario == scenarioId) return;
            var oldState = _state;
            _state = _state.Clone(s => s.SelectedScenario = scenarioId);
            var args = new StateChangedEventArgs(oldState, _state);
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
            if (_state.SourceFiles == sourceFiles) return;
            var oldState = _state;
            _state = _state.Clone(s => s.SourceFiles = sourceFiles);
            var args = new StateChangedEventArgs(oldState, _state);
            AppStateChanged?.Invoke(this, args);
            SourceFileListChanged?.Invoke(this, args);
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
            if (_state.SelectedSourceFile == sourceFile) return;
            var oldState = _state;
            _state = _state.Clone(s => s.SelectedSourceFile = sourceFile);
            var args = new StateChangedEventArgs(oldState, _state);
            AppStateChanged?.Invoke(this, args);
            SelectedSourceFileChanged?.Invoke(this, args);
        }

        /// <summary>
        /// This event is raised whenever the selected scenarios changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> SelectedSourceFileChanged;
    }
}
