using Dotneteer.BlazorBoard.Client.Core;
using Dotneteer.BlazorBoard.Client.Demos._01_Hello.Scenarios;

namespace Dotneteer.BlazorBoard.Client.Demos._01_Hello
{
    [Demo("01_Hello", 1, "Hello, Blazor!")]
    public class HelloDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, "Displaying Text and Date")]
        [SourceFile("HelloBlazor01.razor", "HelloBlazor.razor")]
        public HelloBlazor01 Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Updating Data")]
        [SourceFile("HelloBlazor02.razor", "HelloBlazor.razor")]
        public HelloBlazor02 Scenario02 { get; set; }
    }
}
