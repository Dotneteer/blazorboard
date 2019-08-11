using Dotneteer.BlazorBoard.Client.Services;
using Dotneteer.BlazorBoard.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class is intended to be the base class for all components in this 
    /// application so that they can leverage on IBlazorBoardStateService.
    /// </summary>
    public abstract class StateAwareComponentBase: ComponentBase, IDisposable
    {
        /// <summary>
        /// Access the state service of the app
        /// </summary>
        [Inject]
        public IBlazorBoardStateService StateService { get; set; }

        /// <summary>
        /// Access the demo metadata service
        /// </summary>
        [Inject]
        public IDemoMetadataService DemoMetadataService { get; set; }

        /// <summary>
        /// Get the current application state
        /// </summary>
        public BlazorBoardState State => StateService.State;

        /// <summary>
        /// Initialize event listeners
        /// </summary>
        protected override void OnInit()
        {
            base.OnInit();
            StateService.AppStateChanged += OnAppStateChangedInternal;
            StateService.ThemeListChanged += OnThemeListChangedInternal;
            StateService.SelectedThemeChanged += OnSelectedThemeChangedInternal;
            StateService.DemoListChanged += OnDemoListChangedInternal;
            StateService.SelectedDemoChanged += OnSelectedDemoChangedInternal;
            StateService.ScenarioListChanged += OnScenarioListChangedInternal;
            StateService.SelectedScenarioChanged += OnSelectedScenarioChangedInternal;
            StateService.SourceFileListChanged += OnSourceFileListChangedInternal;
            StateService.SelectedSourceFileChanged += OnSelectedSourceFileChangedInternal;
            StateService.SelectedFontSizeChanged += OnSelectedFontSizeChangedInternal;
        }

        /// <summary>
        /// Release event listeners
        /// </summary>
        public virtual void Dispose()
        {
            StateService.AppStateChanged -= OnAppStateChangedInternal;
            StateService.ThemeListChanged -= OnThemeListChangedInternal;
            StateService.SelectedThemeChanged -= OnSelectedThemeChangedInternal;
            StateService.DemoListChanged -= OnDemoListChangedInternal;
            StateService.SelectedDemoChanged -= OnSelectedDemoChangedInternal;
            StateService.ScenarioListChanged -= OnScenarioListChangedInternal;
            StateService.SelectedScenarioChanged -= OnSelectedScenarioChangedInternal;
            StateService.SourceFileListChanged -= OnSourceFileListChangedInternal;
            StateService.SelectedSourceFileChanged -= OnSelectedSourceFileChangedInternal;
            StateService.SelectedFontSizeChanged -= OnSelectedFontSizeChangedInternal;
        }

        /// <summary>
        /// Override this method to handle the AppStateChanged event
        /// </summary>
        /// <param name="state">New application state</param>
        protected virtual void OnAppStateChanged(BlazorBoardState state)
        {
        }

        /// <summary>
        /// Override this method to handle the ThemeListChanged event
        /// </summary>
        /// <param name="themes">List of themes</param>
        protected virtual void OnThemeListChanged(List<ComboDataItem> themes)
        {
        }

        /// <summary>
        /// Override this method to handle the SelectedThemeChanged event
        /// </summary>
        /// <param name="selectedTheme">Selected theme item</param>
        protected virtual void OnSelectedThemeChanged(ComboDataItem selectedTheme)
        {
        }

        /// <summary>
        /// Override this method to handle the DemoListChanged event
        /// </summary>
        /// <param name="demos">List of demos</param>
        protected virtual void OnDemoListChanged(List<ComboDataItem> demos)
        {
        }

        /// <summary>
        /// Override this method to handle the SelectedDemoChanged event
        /// </summary>
        /// <param name="selectedDemo">Selected theme item</param>
        protected virtual void OnSelectedDemoChanged(ComboDataItem selectedDemo)
        {
        }

        /// <summary>
        /// Override this method to handle the ScenarioListChanged event
        /// </summary>
        /// <param name="scenarios">List of scenarios</param>
        protected virtual void OnScenarioListChanged(List<ComboDataItem> scenarios)
        {
        }

        /// <summary>
        /// Override this method to handle the SelectedScenarioChanged event
        /// </summary>
        /// <param name="selectedScenario">Selected scenario item</param>
        protected virtual void OnSelectedScenarioChanged(ComboDataItem selectedScenario)
        {
        }

        /// <summary>
        /// Override this method to handle the SourceFileListChanged event
        /// </summary>
        /// <param name="sourceFiles">List of source files</param>
        protected virtual void OnSourceFileListChanged(List<ComboDataItem> sourceFiles)
        {
        }

        /// <summary>
        /// Override this method to handle the SelectedSourceFileChanged event
        /// </summary>
        /// <param name="selectedSourceFile">Selected source file item</param>
        protected virtual void OnSelectedSourceFileChanged(ComboDataItem selectedSourceFile)
        {
        }

        /// <summary>
        /// Override this method to handle the SelectedFontSizeChanged event
        /// </summary>
        /// <param name="selectedFontSize">Selected font size item</param>
        protected virtual void OnSelectedFontSizeChanged(ComboDataItem selectedFontSize)
        {
        }

        #region Helpers

        private void OnAppStateChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnAppStateChanged(e.NewState);
        }

        private void OnThemeListChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnThemeListChanged(e.NewState.Themes);
        }

        private void OnSelectedThemeChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSelectedThemeChanged(e.NewState.SelectedTheme);
        }

        private void OnDemoListChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnDemoListChanged(e.NewState.Demos);
        }

        private void OnSelectedDemoChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSelectedDemoChanged(e.NewState.SelectedDemo);
        }

        private void OnScenarioListChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnScenarioListChanged(e.NewState.Scenarios);
        }

        private void OnSelectedScenarioChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSelectedScenarioChanged(e.NewState.SelectedScenario);
        }

        private void OnSourceFileListChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSourceFileListChanged(e.NewState.SourceFiles);
        }

        private void OnSelectedSourceFileChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSelectedSourceFileChanged(e.NewState.SelectedSourceFile);
        }

        private void OnSelectedFontSizeChangedInternal(object sender, StateChangedEventArgs e)
        {
            OnSelectedFontSizeChanged(e.NewState.SelectedFontSize);
        }

        #endregion
    }
}
