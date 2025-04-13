using System.Configuration;
using System.Data;
using System.Windows;

namespace wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var splash = new SplashScreen();
            splash.Show();

            await Task.Delay(3000);

            var loginScreen = new LoginScreen();
            MainWindow = loginScreen;
            MainWindow.Show();

            splash.Close();
        }
    }

}
