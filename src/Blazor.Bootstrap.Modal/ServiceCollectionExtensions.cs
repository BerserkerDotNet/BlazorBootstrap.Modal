using Blazor.Bootstrap.Modal.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Bootstrap.Modal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBootstrapModal(this IServiceCollection services)
        {
            return services.AddScoped<IModal, ModalService>();
        }
    }
}
