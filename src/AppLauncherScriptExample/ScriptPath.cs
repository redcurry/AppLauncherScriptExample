namespace AppLauncherScriptExample
{
    public class ScriptPath
    {
        public ScriptPath(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; }
        public string Path { get; }
    }
}