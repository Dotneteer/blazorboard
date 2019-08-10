using Dotneteer.BlazorBoard.Client.Core;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// This interface represents operations related to services
    /// </summary>
    public interface IDemoMetadataService
    {
        /// <summary>
        /// Registers demo metadata to be used later in other components
        /// </summary>
        /// <param name="metadata"></param>
        void RegisterDemoMetadata(List<DemoMetadata> metadata);

        /// <summary>
        /// Gets the demo metadata registered earlier
        /// </summary>
        /// <returns>List of demo metadata</returns>
        List<DemoMetadata> GetDemoMetadata();

        /// <summary>
        /// Gets the demo metadata according to the specified ID
        /// </summary>
        /// <param name="id">Demo id</param>
        /// <returns>Demo metadata</returns>
        DemoMetadata GetDemo(string id);

        /// <summary>
        /// Gets the metadata according to the specified demo and scenario
        /// </summary>
        /// <param name="demoId"></param>
        /// <param name="scenarioId"></param>
        /// <returns>Scenario metadata</returns>
        ScenarioMetadata GetScenario(string demoId, string scenarioId);
    }
}
