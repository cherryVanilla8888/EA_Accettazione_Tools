using EA_Dashboard.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EA_Dashboard.Utils
{
    /// <summary>
    /// La classe VersionHelper controlla se c'è una nuova versione del programma
    /// </summary>
    public class VersionHelper
    {
        public Version CurrentVersion { get; set; } = typeof(MainWindowView).Assembly.GetName().Version;
        public bool CheckForNewVersion(string versionLogFilepath)
        {
            bool installNewVersion = false;
            var version1 = CurrentVersion;
            var version2 = new Version(File.ReadLines(versionLogFilepath).ToList()[0]);

            var comparison = version2.CompareTo(version1);
            if (comparison > 0)
            {
                MessageBoxResult result = MessageBox.Show("Esiste una nuova versione del programma, vuoi installarla adesso?",
                                                          "Nuova versione",
                                                          MessageBoxButton.YesNo,
                                                          MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                    installNewVersion = true;
            }

            return installNewVersion;
        }
    }
}
