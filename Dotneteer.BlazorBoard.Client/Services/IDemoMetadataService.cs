using Dotneteer.BlazorBoard.Client.Core;
using System.Collections.Generic;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// This interface represents operations related to services
    /// </summary>
    interface IDemoMetadataService
    {
        /// <summary>
        /// Registers demo metadata to be used later in other components
        /// </summary>
        /// <param name="metadata"></param>
        void RegisterDemoMetadata(List<DemoMetadata> metadata);

        /// <summary>
        /// Gets the demo metadata registered earlier
        /// </summary>
        /// <returns>Demo metadata</returns>
        List<DemoMetadata> GetDemoMetadata();
    }
}
