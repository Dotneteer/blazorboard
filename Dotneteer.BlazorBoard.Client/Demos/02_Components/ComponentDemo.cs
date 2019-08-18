using Dotneteer.BlazorBoard.Client.Core;

namespace Dotneteer.BlazorBoard.Client.Demos._02_Components
{
    [Demo("02_Components", 2, "Components & Composition")]
    public class ComponentDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, "Composing components")]
        [SourceFile("Compound.razor")]
        [SourceFile("TitleBar.razor")]
        [SourceFile("Menu.razor")]
        [SourceFile("MainPanel.razor")]
        [SourceFile("StatusBar.razor")]
        [SourceFile("style.css")]
        public Scenario_01.Compound Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Reusing components")]
        [SourceFile("Compound.razor")]
        [SourceFile("TitleBar.razor")]
        [SourceFile("Menu.razor")]
        [SourceFile("MainPanel.razor")]
        [SourceFile("StatusBar.razor")]
        [SourceFile("style.css")]
        public Scenario_02.Compound Scenario02 { get; set; }

        [Scenario("Scenario_03", 3, "Component parameters")]
        [SourceFile("Compound.razor")]
        [SourceFile("TitleBar.razor")]
        [SourceFile("Menu.razor")]
        [SourceFile("MainPanel.razor")]
        [SourceFile("StatusBar.razor")]
        [SourceFile("style.css")]
        public Scenario_03.Compound Scenario03 { get; set; }

        [Scenario("Scenario_04", 4, "Consuming browser events")]
        [SourceFile("Compound.razor")]
        [SourceFile("TitleBar.razor")]
        [SourceFile("Menu.razor")]
        [SourceFile("MainPanel.razor")]
        [SourceFile("StatusBar.razor")]
        [SourceFile("style.css")]
        public Scenario_04.Compound Scenario04 { get; set; }
    }
}
