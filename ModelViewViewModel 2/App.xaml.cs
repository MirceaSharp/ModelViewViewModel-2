using System.Windows;

namespace MVVM_voorbeeld_Oplossing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            TVViewModel viewmodel = new TVViewModel();
            FrmTV view = new FrmTV();
            view.DataContext = viewmodel;
            view.Show();
        }
    }
}
