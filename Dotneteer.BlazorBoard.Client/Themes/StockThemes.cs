namespace Dotneteer.BlazorBoard.Client.Themes
{
    /// <summary>
    /// This class contains default stock themes
    /// </summary>
    public class StockThemes
    {
        /// <summary>
        /// Dark theme properties
        /// </summary>
        public static ThemeProps DarkTheme = new ThemeProps
        {
            AppBackgroundColor = "#202020",
            TitleBarBackgroundColor = "transparent",
            TitleColor = "#f89406",
            TitleLabelColor = "#f0f0f0",
            FieldBackgroundColor = "#383838",
            FieldBorder = "1px solid #505050",
            FieldColor = "#f0f0f0",
            FieldHoverBackgroundColor = "#094771",
            FieldHiliteBackgroundColor = "#007acc",
            FieldPlaceholderColor = "#b0b0b0",
            SourcePanelBackgroundColor = "#383838",

            EditorTheme = "vs-dark"
        };

        /// <summary>
        /// Light theme properties
        /// </summary>
        public static ThemeProps LightTheme = new ThemeProps
        {
            AppBackgroundColor = "#e0e0e0",
            TitleBarBackgroundColor = "transparent",
            TitleColor = "#f89406",
            TitleLabelColor = "#101010",
            FieldBackgroundColor = "#f0f0f0",
            FieldBorder = "1px solid #d0d0d0",
            FieldColor = "#101010",
            FieldHoverBackgroundColor = "#007acc",
            FieldHiliteBackgroundColor = "#007acc",
            FieldPlaceholderColor = "#808080",
            SourcePanelBackgroundColor = "#f0f0f0",

            EditorTheme = "vs"
        };
    }
}
