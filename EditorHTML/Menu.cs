using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{

    public class Menu()
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            ShowOptions();
          
            var option = short.Parse(Console.ReadLine());

            handleOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.WriteLine(" ");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.WriteLine(" ");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.WriteLine("\n");


        }

        public static void ShowOptions()
        {
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("2 - Open file");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("3 - Save file");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("4 - Exit");
            Console.Write("Opção: ");
        }

        public static void handleOption(short option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("New file");
                    break;
                case 2:
                    Console.WriteLine("Open file");
                    break;
                case 3:
                    Console.WriteLine("Save file");
                    break;
                case 4:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }
    }


}
