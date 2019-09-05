using Dotneteer.BlazorBoard.Client.Demos._03_DI.Scenario_02;
using Dotneteer.BlazorBoard.Client.Services;
using Dotneteer.BlazorBoard.Client.Themes;
using Dotneteer.BlazorBoard.Components.Themes;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Dotneteer.BlazorBoard.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IThemingService<ThemeProps>, ThemingService<ThemeProps>>();
            services.AddSingleton<IDemoMetadataService, DemoMetadataService>();
            services.AddSingleton<IBlazorBoardStateService, BlazorBoardStateService>();
            services.AddSingleton<IMessengerService, MessengerService>();
            services.AddSingleton<Demos._03_DI.Scenario_03.IMessengerService, Demos._03_DI.Scenario_03.MessengerService>();
            services.AddSingleton<Demos._03_DI.Scenario_04.IMessengerService, Demos._03_DI.Scenario_04.MessengerService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
