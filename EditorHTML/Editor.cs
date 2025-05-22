using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace EditorHTML
{

    public  class Editor()
    {

        public static void ShowMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor HTML");
            start();
        }

        public static void start()
        {

            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------------------");
            Console.WriteLine("  Salvar? (S/N)");
        }

    }



}
