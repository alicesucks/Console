using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();
            UI.SetTitle();
            UI.SetBackground();
            UI.SetForeground();
            UI.SetConsoleWindowSize();

            ApplicationSettingsHelper APSH = new ApplicationSettingsHelper();
            APSH.SaveSettings(ref UI);
            Console.WriteLine("Saving to file...");
            APSH.LoadSettings();
        }
    }
}
