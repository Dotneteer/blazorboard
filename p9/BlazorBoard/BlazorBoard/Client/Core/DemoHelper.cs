using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class provides helper utilities to get demo information
    /// from the current assembly
    /// </summary>
    public static class DemoHelper
    {
        /// <summary>
        /// Gets demo metadata information from the executing assembly
        /// </summary>
        /// <returns>List of demo metadata</returns>
        public static List<DemoMetadata> GetDemos()
        {
            // --- This types describe demos
            var demoTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(DemoBase)));

            // --- Instantiate the demo type to obtain metadata
            var metadata = new List<DemoMetadata>();
            foreach (var demoType in demoTypes)
            {
                var instance = Activator.CreateInstance(demoType) as DemoBase;
                metadata.Add(instance.Metadata);

                // --- Collect scenario metadata
                var scenProps = instance.GetType().GetProperties();
                foreach (var scenProp in scenProps)
                {
                    var attr = scenProp.GetCustomAttribute<ScenarioAttribute>();
                    if (attr == null) continue;

                    var scenario = new ScenarioMetadata(attr.Id, attr.Order, attr.Title)
                    {
                        ComponentType = scenProp.PropertyType,

                        SourceFiles = scenProp
                            .GetCustomAttributes<SourceFileAttribute>()
                            .Select(f => (f.Name, f.Title))
                            .ToList()
                    };
                    instance.Metadata.Scenarios.Add(scenario);
                }
            }

            return metadata
                .OrderBy(m => m.Order)
                .ThenBy(m => m.Title)
                .ToList();
        }
    }
}
