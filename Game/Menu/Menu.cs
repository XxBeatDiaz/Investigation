using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Menu
    {
        static public void MainMenu(string choos)
        {
            switch (choos)
            {
                case "New game":
                    LevelsManager.NewGame();
                    break;

                case "Levels":
                    LevelsManager.LevelsList();
                    Console.Write("Choos: ");
                    int choosLevel = int.Parse(Console.ReadLine()!);
                    LevelsMenu(choosLevel);
                    break;

                case "Settings":
                    break;

                case "Exit":
                    break;
            }
        }

        static public void LevelsMenu(int choss)
        {
            string level = LevelsManager.NumToLevel(choss);
            LevelsManager.ChoosLevel(level);
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
