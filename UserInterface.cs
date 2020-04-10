using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class UserInterface
    {
        ConsoleColor background;
        ConsoleColor foreground;
        int width;
        int height;
        string title;
        public ConsoleColor Foreground { get => foreground; set => foreground = value; }
        public ConsoleColor Background { get => background; set => background = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public string Title { get => title; set => title = value; }

        public UserInterface()
        {
            Background = Console.BackgroundColor = ConsoleColor.White;
            Foreground = Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(120, 30);
        }
        public void SetBackground()
        {
            Console.WriteLine("Выберите цвет фона консоли:\n1.Красный\t2. Зеленый\t3. Желтый\t4. Белый\t5. Лазурный\t6. Черный\t7. Синий\t8. Темно-синий\t9. Темно-лазурный\t10. Темно-серый\t11. Темно-зеленый\t12. Темно-малиновый\t13. Темно-красный\t14. Темно-желтый\t15. Серый\t16. Малиновый");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Background = Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Background = Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Background = Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Background = Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Background = Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 6:
                    Background = Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 7:
                    Background = Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 8:
                    Background = Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 9:
                    Background = Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case 10:
                    Background = Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 11:
                    Background = Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 12:
                    Background = Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 13:
                    Background = Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 14:
                    Background = Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 15:
                    Background = Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 16:
                    Background = Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
            }
            Console.Clear();
        }
        public void SetForeground()
        {
            Console.WriteLine("Выберите цвет шрифта:\n1.Красный\t2. Зеленый\t3. Желтый\t4. Белый\t5. Лазурный\t6. Черный\t7. Синий\t8. Темно-синий\t9. Темно-лазурный\t10. Темно-серый\t11. Темно-зеленый\t12. Темно-малиновый\t13. Темно-красный\t14. Темно-желтый\t15. Серый\t16. Малиновый");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Foreground = Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Foreground = Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Foreground = Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Foreground = Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Foreground = Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 6:
                    Foreground = Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 7:
                    Foreground = Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 8:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 9:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 10:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 11:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 12:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 13:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 14:
                    Foreground = Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 15:
                    Foreground = Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 16:
                    Foreground = Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            Console.Clear();
        }
        public void SetConsoleWindowSize()
        {
            Console.WriteLine("Укажите параметры размера консоли:\nШирина (не более 170) ->");
            Width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Высота (не более 44) ->");
            Height = Int32.Parse(Console.ReadLine());
            Console.SetWindowSize(Width, Height);
            Console.Clear();
        }
        public void SetTitle()
        {
            Console.WriteLine("Задайте заголовок консоли:");
            Title = Console.ReadLine();
            Console.Title = Title;
        }
    }
}
