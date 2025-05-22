using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Viewer
    {
        public static void ShowMenu(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualizador HTML");
            Console.WriteLine("--------------------------------------------------");
            Replace(text);
            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
            Menu.ShowMenu();

        }
        public static void Replace(string text)
        {
            var strong = new Regex("");
        }
    }
}
