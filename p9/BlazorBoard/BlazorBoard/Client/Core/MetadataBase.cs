using System;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class is intended to be the base class for metadata
    /// </summary>
    public abstract class MetadataBase
    {
        /// <summary>
        /// Scenario identifier
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Demo order
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Demo title
        /// </summary>
        public string Title { get; }

        protected MetadataBase(string id, int order, string title)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Order = order;
            Title = title;
        }
    }
}
