using System;
using System.IO;

namespace Files
{
    class ApplicationSettingsHelper
    {
        StreamWriter sw;
        StreamReader sr;
        public void SaveSettings(ref UserInterface UI)
        {
            sw = new StreamWriter("settings.txt");
            sw.WriteLine("Заголовок: " + UI.Title);
            sw.WriteLine("Фон: " + UI.Background);
            sw.WriteLine("Шрифт: " + UI.Foreground);
            sw.WriteLine("Ширина: " + UI.Width);
            sw.WriteLine("Высота: " + UI.Height);
            sw.Close();
        }
        public void LoadSettings()
        {
            sr = new StreamReader("settings.txt");
            int len = File.ReadAllLines("settings.txt").Length;
            string[] settings = new string[len];
            for (int i = 0; i < settings.Length; i++)
                settings[i] = sr.ReadLine();
            Console.WriteLine("Ваши последние настройки:");
            for (int i = 0; i < settings.Length; i++)
                Console.WriteLine(settings[i]);
            Console.WriteLine();
            sr.Close();
        }
    }
}
