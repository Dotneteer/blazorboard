using Dotneteer.BlazorBoard.Components.Themes;

namespace Dotneteer.BlazorBoard.Client.Themes
{
    /// <summary>
    /// This class represents theme properties
    /// </summary>
    public class ThemeProps
    {
        public string AppBackgroundColor { get; set; }

        public string TitleBarBackgroundColor { get; set; }
        public string TitleColor { get; set; }
        public string TitleLabelColor { get; set; }

        public string FieldBackgroundColor { get; set; }
        public string FieldBorder { get; set; }
        public string FieldColor { get; set; }
        public string FieldHoverBackgroundColor { get; set; }
        public string FieldHiliteBackgroundColor { get; set; }
        public string FieldPlaceholderColor { get; set; }

        public string SourcePanelBackgroundColor { get; set; }

        public string SplitterBackgroundColor { get; set; }
        public string SplitterSize { get; set; }
        public string SplitterHandleBackgroundColor { get; set; }
        public string SplitterHandleSize { get; set; }

        public string PreviewPanelBackgroundColor { get; set; }
        public string PreviewPanelPadding { get; set; }

        [NonCss]
        public string EditorTheme { get; set; }
    }
}
