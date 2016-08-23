using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AppLauncherScriptExample
{
    public class MainViewModel
    {
        public MainViewModel(string scriptsPath)
        {
            Scripts = LoadScriptPaths(scriptsPath);
        }

        public IEnumerable<ScriptPath> Scripts { get; private set; }

        public ScriptPath SelectedScript { get; set; }

        public void RunSelectedScript()
        {
            if (SelectedScript != null)
            {
                Process.Start(SelectedScript.Path);
            }
        }

        private IEnumerable<ScriptPath> LoadScriptPaths(string path)
        {
            if (File.Exists(path))
            {
                var scriptLines = File.ReadAllLines(path);
                return scriptLines.Select(ScriptPathFromLine);
            }

            return Enumerable.Empty<ScriptPath>();
        }

        private ScriptPath ScriptPathFromLine(string line)
        {
            // Each line must be of the form <script-name>,<script-path>
            var parts = line.Split(',');
            return new ScriptPath(parts[0], parts[1]);
        }
    }
}
