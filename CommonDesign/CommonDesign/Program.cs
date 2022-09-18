using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDesign
{
    public class SimpleDesign
    {
        public void DashPrint()
        {
            for (int i = 0; i < Console.WindowWidth; i++) Console.Write("-");
        }


        public void StarPrint()
        {
            for (int i = 0; i < Console.WindowWidth; i++) Console.Write("*");
        }

        public void WinCenter(string str)
        {
            int num = Convert.ToInt32(Console.WindowWidth / 2 - str.Length / 2);
            for (int i = 0; i < num; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(str);
        }

        public void CenterBox(string name, char ch = '*', int fore = 69, int back = 69)
        {
            Console.Clear();

            int chLength = name.Length + 8;
            if (chLength % 2 == 0) ++chLength;
            int startPoint = (int)((Console.WindowWidth / 2 - name.Length / 2) - 4);
            int endPoint = (int)((Console.WindowWidth / 2 + name.Length / 2) + 4);


            Console.SetCursorPosition(startPoint, 2);
            for (int i = 0; i < chLength; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();

            for (int i = 3; i <= 7; i++)
            {
                Console.SetCursorPosition(startPoint, i);
                Console.Write(ch);
                Console.SetCursorPosition(endPoint, i);
                Console.Write(ch);
                if (i == 5)
                {
                    Console.SetCursorPosition(startPoint + 4, i);
                    if (fore != 69 && back != 69) ColorText(name, fore, back);
                    else if (fore != 69) ColorText(name, fore);
                    else Console.Write(name);
                }
            }
            Console.WriteLine();

            Console.SetCursorPosition(startPoint, 8);
            for (int i = 0; i < chLength; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }


        public void ColorText (string str, int fore, int back)
        {
            ConsoleColor currentforegroundcolor = Console.ForegroundColor;
            ConsoleColor currentbackgroundcolor = Console.BackgroundColor;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[fore];
            Console.BackgroundColor = colors[back];
            Console.WriteLine(str);
            Console.ForegroundColor = currentforegroundcolor;
            Console.BackgroundColor = currentbackgroundcolor;
        }

        public void ColorText(string str, int fore)
        {
            ConsoleColor currentforegroundcolor = Console.ForegroundColor;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[fore];
            Console.WriteLine(str);
            Console.ForegroundColor = currentforegroundcolor;
        }
    }
}
