namespace AppLauncherScriptExample
{
    public class ScriptPath
    {
        public ScriptPath(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; private set; }
        public string Path { get; private set; }
    }
}