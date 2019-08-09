using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class provides metadata for a particular demo class
    /// </summary>
    public class DemoMetadata : MetadataBase
    {
        /// <summary>
        /// Scenarios belonging to the demo
        /// </summary>
        public List<ScenarioMetadata> Scenarios { get; }  = new List<ScenarioMetadata>();

        /// <summary>
        /// Initializes demo metadata
        /// </summary>
        /// <param name="id">Demo ID</param>
        /// <param name="order">Demo order</param>
        /// <param name="title">Demo title</param>
        public DemoMetadata(string id, int order, string title) :
            base(id, order, title)
        {
        }
    }
}
