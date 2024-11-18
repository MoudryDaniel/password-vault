using Microsoft.Extensions.DependencyInjection;
using password_vault.ViewModels;
using password_vault.Views;

namespace password_vault.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<MainWindow>();
        services.AddTransient<MainWindowViewModel>();

        return services;
    }
}