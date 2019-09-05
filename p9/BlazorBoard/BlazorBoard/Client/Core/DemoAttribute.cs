using System;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class is intended to decorate a DemoBase derived class to 
    /// add metadata to it.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DemoAttribute: Attribute
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

        public DemoAttribute(string id, int order, string title)
        {
            Id = id;
            Order = order;
            Title = title;
        }
    }
}
