using System;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class is intended to decorate properties in a DemoBase derived
    /// class to add scenario metadata to that property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ScenarioAttribute: Attribute
    {
        /// <summary>
        /// Demo identifier
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

        public ScenarioAttribute(string id, int order, string title)
        {
            Id = id;
            Order = order;
            Title = title;
        }
    }
}
