using Dotneteer.BlazorBoard.Client.Core;

namespace Dotneteer.BlazorBoard.Client.Demos._03_DI
{
    [Demo("03_DI", 3, "Dependency injection")]
    public class DependencyInjectionDemo: DemoBase
    {
        [Scenario("Scenario_01", 1, "Using HttpClient")]
        [SourceFile("JokeComponent.razor")]
        public Scenario_01.JokeComponent Scenario01 { get; set; }

        [Scenario("Scenario_02", 2, "Using your own service")]
        [SourceFile("Board.razor")]
        [SourceFile("IMessengerService.cs")]
        [SourceFile("TopicListener.razor")]
        [SourceFile("Sender.razor")]
        [SourceFile("Startup.cs")]
        public Scenario_02.Board Scenario02 { get; set; }
        
        [Scenario("Scenario_03", 3, "Fixing event subscription")]
        [SourceFile("TopicListener.razor")]
        public Scenario_03.Board Scenario03 { get; set; }

        [Scenario("Scenario_04", 3, "Using a base class")]
        [SourceFile("TopicListener.razor")]
        [SourceFile("MessengerAwareBase.cs")]
        [SourceFile("Startup.cs")]
        public Scenario_04.Board Scenario04 { get; set; }
    }
}
