using Dotneteer.BlazorBoard.Components.Themes;

namespace Dotneteer.BlazorBoard.Client.Themes
{
    /// <summary>
    /// This class represents theme properties
    /// </summary>
    public class ThemeProps
    {
        public string TitleBarBackgroundColor { get; set; }
        public string FieldBackgroundColor { get; set; }
        public string FieldBorder { get; set; }
        public string FieldColor { get; set; }
        public string FieldHoverBackgroundColor { get; set; }
        public string FieldHiliteBackgroundColor { get; set; }
        public string FieldPlaceholderColor { get; set; }


        [NonCss]
        public string EditorTheme { get; set; }
    }
}
