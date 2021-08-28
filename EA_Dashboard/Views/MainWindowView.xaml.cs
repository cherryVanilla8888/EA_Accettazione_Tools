using EA_Dashboard.Utils;
using System.Windows;
using System.Windows.Input;


namespace EA_Dashboard.Views
{
    /// <summary>
    /// Logica di interazione per MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Application.Current.Shutdown();
        }
    }
}
