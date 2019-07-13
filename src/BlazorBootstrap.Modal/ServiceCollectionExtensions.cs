using BlazorBootstrap.Modal.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBootstrap.Modal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBootstrapModal(this IServiceCollection services)
        {
            return services.AddScoped<IModal, ModalService>();
        }
    }
}
