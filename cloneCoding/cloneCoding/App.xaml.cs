using System.Configuration;
using System.Data;
using System.Windows;
using cloneCoding.Services;
using cloneCoding.ViewModels;
using cloneCoding.Views;
using Microsoft.Extensions.DependencyInjection;

namespace cloneCoding
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = App.Current.Services.GetService<MainView>();
            mainWindow.Show();
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            //ViewModels
            services.AddTransient<MainViewModel>();
            services.AddTransient<LoginControlViewModel>();
            services.AddTransient<SignupControlViewModel>();
            services.AddTransient<ChangePwdControlViewModel>();
            
            //services.AddSingleton<ITestService, TestService>();

            services.AddSingleton<MainView>();

            return services.BuildServiceProvider();
        }
    }

}
