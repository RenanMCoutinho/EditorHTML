﻿using System;
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
            var strong = new Regex(@"<strong>(.*?)</strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1, (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))); Console.WriteLine(" ");

                    Console.WriteLine(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
