using EA_Dashboard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_Dashboard.ViewModels
{
    public class ViewModelBoilerPlate : BaseViewModel
    {
        #region Vars
        private MainWindowView mainWindow;
        #endregion

        #region Properties
        #endregion

        #region Commands
        #endregion
        public ViewModelBoilerPlate()
        {
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
