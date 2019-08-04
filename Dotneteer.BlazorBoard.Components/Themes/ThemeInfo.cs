namespace Dotneteer.BlazorBoard.Components.Themes
{
    /// <summary>
    /// This structure represents a theme with its properties
    /// </summary>
    /// <typeparam name="TPropSet">A type holding the property set of the theme</typeparam>
    public struct ThemeInfo<TPropSet>
    {
        /// <summary>
        /// Theme name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The properties of the theme
        /// </summary>
        public TPropSet Properties { get; }

        public ThemeInfo(string name, TPropSet properties)
        {
            Name = name;
            Properties = properties;
        }
    }
}
