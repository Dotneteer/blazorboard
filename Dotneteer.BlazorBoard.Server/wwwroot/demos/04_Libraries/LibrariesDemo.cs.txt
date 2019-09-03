using Dotneteer.BlazorBoard.Client.Core;

namespace Dotneteer.BlazorBoard.Client.Demos._04_Libraries
{
    [Demo("04_Libraries", 4, "Component libraries")]
    public class LibrariesDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, "Using a component library")]
        [SourceFile("ComboDemo.razor")]
        [SourceFile("ComboDataItem.cs")]
        [SourceFile("_Imports.razor")]
        public Scenario_01.ComboDemo Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Creating a component library")]
        [SourceFile("RectangleDemo.razor")]
        [SourceFile("MyRectangle.razor")]
        [SourceFile("style.css")]
        [SourceFile("MyLibrary.csproj")]
        [SourceFile("index.html")]
        public Scenario_02.RectangleDemo Scenario02 { get; set; }
    }
}
