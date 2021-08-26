using EA_Dashboard.Utils;
using EA_Dashboard.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace EA_Dashboard.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Vars
        private MainWindowView mainWindow;
        #endregion

        #region Properties
        #endregion

        #region Commands
        #endregion
        public MainWindowViewModel()
        {

            // Debug
            //DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName);
            // Release
            //string directoryInfo = System.AppDomain.CurrentDomain.BaseDirectory;

            mainWindow = (MainWindowView)System.Windows.Application.Current.MainWindow;
            initializeProperties();
            initializeCommands();

        }

        #region Initializers

        private void initializeProperties()
        {
        }
        private void initializeCommands()
        {

        }
        #endregion

        #region Command's Methods
        #endregion

        #region Methods

        #endregion
    }
}
