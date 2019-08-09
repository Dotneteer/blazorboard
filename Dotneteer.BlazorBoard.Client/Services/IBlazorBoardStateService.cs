using Dotneteer.BlazorBoard.Components;
using System;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// This interface represents the state service of Blazor Board
    /// </summary>
    public interface IBlazorBoardStateService
    {
        /// <summary>
        /// This event is raised whenever the state of the application changes.
        /// </summary>
        event EventHandler<StateChangedEventArgs> AppStateChanged;

        /// <summary>
        /// Sets the initial state of the application
        /// </summary>
        void InitAppState(
            List<ComboDataItem> themes, 
            List<ComboDataItem> demos, 
            List<ComboDataItem> scenarios,
            List<ComboDataItem> sourceFiles);

        /// <summary>
        /// Sets the list of themes
        /// </summary>
        /// <param name="themes">List of themes</param>
        void SetThemeList(List<ComboDataItem> themes);

        /// <summary>
        /// This event is raised whenever the list of demos changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> ThemeListChanged;

        /// <summary>
        /// Selects a new application theme
        /// </summary>
        /// <param name="themeId">ID of the new theme</param>
        void SelectTheme(string themeId);

        /// <summary>
        /// This event is raised whenever the current theme changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> ThemeChanged;

        /// <summary>
        /// Sets the list of demos
        /// </summary>
        /// <param name="demos">List of demos</param>
        void SetDemoList(List<ComboDataItem> demos);

        /// <summary>
        /// This event is raised whenever the list of demos changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> DemoListChanged;

        /// <summary>
        /// Selects a demo in the demo list
        /// </summary>
        /// <param name="demoId">ID of the selected demo</param>
        void SelectDemo(string demoId);

        /// <summary>
        /// This event is raised whenever the selected demo changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> SelectedDemoChanged;

        /// <summary>
        /// Sets the list of scenarios
        /// </summary>
        /// <param name="scenarios">List of scenarios</param>
        void SetScenarioList(List<ComboDataItem> scenarios);

        /// <summary>
        /// This event is raised whenever the list of scenarios changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> ScenarioListChanged;

        /// <summary>
        /// Selects a scenario in the scenario list
        /// </summary>
        /// <param name="scenarioId">ID of the selected scenario</param>
        void SelectScenario(string scenarioId);

        /// <summary>
        /// This event is raised whenever the selected scenarios changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> SelectedScenarioChanged;

        /// <summary>
        /// Sets the list of source files
        /// </summary>
        /// <param name="sourceFiles">List of source files</param>
        void SetSourceFileList(List<ComboDataItem> sourceFiles);

        /// <summary>
        /// This event is raised whenever the list of source files changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> SourceFileListChanged;

        /// <summary>
        /// Selects a source file in the source file list
        /// </summary>
        /// <param name="sourceFile">Selected source file</param>
        void SelectSourceFile(string sourceFile);

        /// <summary>
        /// This event is raised whenever the selected scenarios changes
        /// </summary>
        event EventHandler<StateChangedEventArgs> SelectedSourceFileChanged;
    }
}
