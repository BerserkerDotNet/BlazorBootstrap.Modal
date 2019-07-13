using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBootstrap.Modal.Samples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBootstrapModal();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
