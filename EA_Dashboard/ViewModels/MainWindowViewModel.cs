using EA_Dashboard.Models;
using EA_Dashboard.Utils;
using EA_Dashboard.Views;
using MaterialDesignThemes.Wpf;
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
        private List<DrawerMenuItem> drawerMenuItems;


        #endregion

        #region Properties
        public List<DrawerMenuItem> DrawerMenuItems
        {
            get { return drawerMenuItems; }
            set { drawerMenuItems = value; NotifyPropertyChanged(); }
        }

        #endregion

        #region Commands
        #endregion
        public MainWindowViewModel()
        {

     
            InitializeProperties();
            Task.Run(InitializePropertiesAsync);
            InitializeCommands();

        }
        #region Initializers

        private async Task InitializePropertiesAsync()
        {
            DrawerMenuItems = NavigationManager.GetDrawerMenuItems();
        }


        private void InitializeProperties()
        {
        }
        private void InitializeCommands()
        {

        }
        #endregion

        #region Command's Methods
        #endregion

        #region Methods

        #endregion
    }
}
