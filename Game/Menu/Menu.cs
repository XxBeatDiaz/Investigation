using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Menu
    {
        static public bool MainMenu(string choos)
        {
            bool exit = false;
            bool gameOver = false;
            while (!gameOver)
            {
                switch (choos)
                {
                    case "New game":
                        string end = LevelsManager.NewGame();
                        choos = end;
                        break;

                    case "Levels":
                        Console.Clear();
                        LevelsManager.LevelsList();
                        Console.Write("Choos: ");
                        int choosLevel = int.Parse(Console.ReadLine()!);
                        string endChoos = LevelsMenu(choosLevel);
                        choos = endChoos;
                        break;

                    case "Settings":
                        gameOver = true;
                        break;

                    case "Exit":
                        exit = true;
                        gameOver = true;
                        break;

                    default:
                        gameOver = true;
                        break;
                }
            }
            return exit;
        }

        static public string LevelsMenu(int choss)
        {
            string level = LevelsManager.NumToLevel(choss);
            string end = LevelsManager.ChoosLevel(level);
            return end;
        }
      
        static public void PrintMenu()
        {
            Console.WriteLine($"|||||| ''INVESTIGATION'' ||||||\n" +
                              $"1. New game.\n" +
                              $"2. Levels\n" +
                              $"3. Settings\n" +
                              $"4. Exit");
        }

        static public string NumToChoos(int num)
        {
            switch (num)
            {
                case 1:
                    return "New game";

                case 2:
                    return "Levels";

                case 3:
                    return "Settings";

                case 4:
                    return "Exit";

                default:
                    return "Exit";
            }
        }
    }
}
