using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;

namespace EA_Dashboard.Utils
{
    public class SettingsManager
    {
        public Dictionary<string, dynamic> Settings { get; set; }
        public async Task<Dictionary<string, dynamic>> getSettingsFromJSONAsync()
        {
            // Debug
            DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName);

            // Release
            //string directoryInfo = System.AppDomain.CurrentDomain.BaseDirectory;

            string jsonFile = System.IO.Path.Combine(directoryInfo.FullName, "Utils/settings.json");
            string json = File.ReadAllText(jsonFile);
            var settings = await Task.Run(() => (new JavaScriptSerializer()).Deserialize<Dictionary<string, dynamic>>(json));

            return settings;
        }
        public Dictionary<string, object> getSettingsFromJSON()
        {
            // Debug
            DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName);
            // Release
            //string directoryInfo = System.AppDomain.CurrentDomain.BaseDirectory;

            string jsonFile = System.IO.Path.Combine(directoryInfo.FullName, "Utils/settings.json");
            string json = File.ReadAllText(jsonFile);
            var settings = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(json);
            return settings;
        }

    }
}
