using EA_Dashboard.Data;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EA_Dashboard.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected DataService dataService = new DataService();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
