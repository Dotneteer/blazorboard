using System;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Core
{
    public class ScenarioMetadata : MetadataBase
    {
        /// <summary>
        /// The type of component that represents this scenario
        /// </summary>
        public Type ComponentType { get; set; }

        /// <summary>
        /// Source files belonging to this scenario
        /// </summary>
        public List<(string Name, string Title)> SourceFiles { get; set; }

        /// <summary>
        /// Relative scenario path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Initializes scenario metadata
        /// </summary>
        /// <param name="id">Scenario ID</param>
        /// <param name="order">Scenario order</param>
        /// <param name="title">Scenario title</param>
        public ScenarioMetadata(string id, int order, string title) :
            base(id, order, title)
        {
        }
    }
}
