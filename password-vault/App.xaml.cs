using Microsoft.Extensions.DependencyInjection;
using password_vault.Extensions;
using password_vault.Views;
using System.Windows;

namespace password_vault;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // Dependency Injection
        IServiceCollection services = new ServiceCollection();

        services.AddServices();

        IServiceProvider serviceProvider = services.BuildServiceProvider();

        // Show window
        MainWindow mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
