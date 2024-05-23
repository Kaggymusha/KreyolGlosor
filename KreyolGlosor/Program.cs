using IniParser;
using IniParser.Model;

namespace KreyolGlosor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}