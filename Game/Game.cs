using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Game
    {
        public static void StartGame()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                Menu.PrintMenu();
                Console.Write("Choos: ");
                int intChoos = int.Parse(Console.ReadLine()!);
                string choos = Menu.NumToChoos(intChoos);
                bool end = Menu.MainMenu(choos);
                if (end)
                {
                    gameOver = true;
                }
            }
        }
    }
}
