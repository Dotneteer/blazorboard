namespace Dotneteer.BlazorBoard.Components
{
    /// <summary>
    /// Represents a combo box data item with an id and a display name
    /// </summary>
    public class ComboDataItem
    {
        public ComboDataItem(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        /// <summary>
        /// Item identifier
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Name to display
        /// </summary>
        public string DisplayName { get; }
    }
}
