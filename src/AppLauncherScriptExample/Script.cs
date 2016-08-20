using System.IO;
using System.Reflection;
using System.Windows;
using AppLauncherScriptExample;
using VMS.TPS.Common.Model.API;

namespace VMS.TPS
{
    public class Script
    {
        public void Execute(ScriptContext scriptContext, Window mainWindow)
        {
            mainWindow.Title = "Stand-Alone Launcher";
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            mainWindow.Width = 320;
            mainWindow.Height = 480;

            mainWindow.Content = new MainView(new MainViewModel(GetScriptsPath()));
        }

        public string GetScriptsPath()
        {
            return Path.Combine(GetAssemblyDirectory(), "scripts.csv");
        }

        private string GetAssemblyDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
