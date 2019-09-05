using System;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class describes a source file of a scenario
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class SourceFileAttribute : Attribute
    {
        /// <summary>
        /// Name of the source file
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Title of the source file
        /// </summary>
        public string Title { get; }

        public SourceFileAttribute(string name, string title = null)
        {
            Name = name;
            Title = title ?? name;
        }
    }
}
