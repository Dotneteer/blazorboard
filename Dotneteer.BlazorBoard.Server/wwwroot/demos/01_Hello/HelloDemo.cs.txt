using Dotneteer.BlazorBoard.Client.Core;

namespace Dotneteer.BlazorBoard.Client.Demos._01_Hello
{
    [Demo("01_Hello", 1, "Hello, Blazor!")]
    public class HelloDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, "Displaying Text and Date")]
        [SourceFile("HelloBlazor.razor")]
        public Scenario_01.HelloBlazor Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Updating Data")]
        [SourceFile("HelloBlazor.razor" )]
        public Scenario_02.HelloBlazor Scenario02 { get; set; }

        [Scenario("Scenario_03", 3, "CSS Styling")]
        [SourceFile("HelloBlazor.razor")]
        [SourceFile("style.css")]
        public Scenario_03.HelloBlazor Scenario03 { get; set; }
    }
}
