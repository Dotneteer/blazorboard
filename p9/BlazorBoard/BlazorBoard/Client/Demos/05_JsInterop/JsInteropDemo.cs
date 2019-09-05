using Dotneteer.BlazorBoard.Client.Core;

namespace Dotneteer.BlazorBoard.Client.Demos._05_JsInterop
{
    [Demo("05_JsInterop", 5, "JavaScript Interop")]
    public class JsInteropDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, ".NET --> JavaScript")]
        [SourceFile("AlertComponent.razor")]
        [SourceFile("alert-interop.js")]
        public Scenario_01.AlertComponent Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Using element references")]
        [SourceFile("SplitterDemo.razor")]
        [SourceFile("HorizontalSplitter.razor")]
        [SourceFile("splitter-interop.js")]
        public Scenario_02.SplitterDemo Scenario02 { get; set; }

        [Scenario("Scenario_03", 3, "JavaScript --> .NET")]
        [SourceFile("FibonacciComponent.razor")]
        [SourceFile("fibonacci-interop.js")]
        public Scenario_03.FibonacciComponent Scenario03 { get; set; }
    }
}
