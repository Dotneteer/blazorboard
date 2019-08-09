using Dotneteer.BlazorBoard.Client.Core;
using System;
using System.Collections.Generic;

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
    }
}
