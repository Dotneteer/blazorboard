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
            TitleBarBackgroundColor = "#202020",
            FieldBackgroundColor = "#383838",
            FieldBorder = "1px solid #505050",

            EditorTheme = "vs-dark"
        };

        /// <summary>
        /// Light theme properties
        /// </summary>
        public static ThemeProps LightTheme = new ThemeProps
        {
            TitleBarBackgroundColor = "#e0e0e0",
            FieldBackgroundColor = "#f0f0f0",
            FieldBorder = "1px solid #d0d0d0",

            EditorTheme = "vs"
        };
    }
}
