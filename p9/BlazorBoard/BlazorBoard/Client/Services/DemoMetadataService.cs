using Dotneteer.BlazorBoard.Client.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// Implements the demo metadata service
    /// </summary>
    public class DemoMetadataService : IDemoMetadataService
    {
        private List<DemoMetadata> _metadata;

        /// <summary>
        /// Registers demo metadata to be used later in other components
        /// </summary>
        /// <param name="metadata"></param>
        public void RegisterDemoMetadata(List<DemoMetadata> metadata)
        {
            _metadata = metadata 
                ?? throw new ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Gets the demo metadata registered earlier
        /// </summary>
        /// <returns>Demo metadata</returns>
        public List<DemoMetadata> GetDemoMetadata()
        {
            return _metadata ?? throw new InvalidOperationException(
                "Demo metadata has not been registered yet.");
        }

        /// <summary>
        /// Gets the demo metadata according to the specified ID
        /// </summary>
        /// <param name="id">Demo id</param>
        /// <returns></returns>
        public DemoMetadata GetDemo(string id) 
            => _metadata.FirstOrDefault(d => d.Id == id);

        /// <summary>
        /// Gets the metadata according to the specified demo and scenario
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="scenarioId"></param>
        /// <returns>Scenario metadata</returns>
        public ScenarioMetadata GetScenario(string demoId, string scenarioId) 
            => _metadata.FirstOrDefault(d => d.Id == demoId)
                ?.Scenarios.FirstOrDefault(s => s.Id == scenarioId);
    }
}
