using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class LevelsManager
    {
        public static string NewGame()
        {
            string levelOne = "Level one";
            string end = ChoosLevel(levelOne);
            return end;

        }

        public static string NumToLevel(int num)
        {
            switch (num)
            {
                case 1:
                    return "Level one";

                case 2:
                    return "Level two";

                case 3:
                    return "Level three";

                default:
                    return "Level one";
            }
        }

        public static string ChoosLevel(string level)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                switch (level)
                {
                    case "Level one":
                        Level.LevelOne();
                        PrintEndLevelMenu();
                        int choosEnd1 = int.Parse(Console.ReadLine()!);
                        string end1 = EndLevelMenu(choosEnd1);
                        if (end1 == "Next level")
                        {
                            level = "Level two";
                            break;
                        }
                        else
                        {
                            return end1;
                        }

                    case "Level two":
                        Level.LevelTwo();
                        PrintEndLevelMenu();
                        int choosEnd2 = int.Parse(Console.ReadLine()!);
                        string end2 = EndLevelMenu(choosEnd2);
                        if (end2 == "Next level")
                        {
                            level = "Level three";
                            break;
                        }
                        else
                        {
                            return end2;
                        }

                    case "Level three":
                        Level.LevelThree();
                        PrintEndLevelMenu();
                        int choosEnd3 = int.Parse(Console.ReadLine()!);
                        string end3 = EndLevelMenu(choosEnd3);
                        if (end3 == "Next level")
                        {
                            gameOver = true;
                            break;
                        }
                        else
                        {
                            return end3;
                        }

                    default:
                        gameOver = true;
                        break;
                }
            }
            return "Main menu";
        }

        static public void LevelsList()
        {
            Console.WriteLine($"Beginners:\n" +
                              $"1. Level one.\n" +
                              $"2. Level two.\n" +
                              $"3. Level three.\n" +
                              $" \n" +
                              $"||||Not available now||||\n" +
                              $"Advanced:\n" +
                              $"4. Level four.\n" +
                              $"5. Level five.\n" +
                              $"6. Level six.\n" +
                              $" \n" +
                              $"Pros:\n" +
                              $"7. Level seven.\n" +
                              $"8. Level eight.\n" +
                              $"9. Level ten.\n" +
                              $" \n" +
                              $"Expert:\n" +
                              $"10. Boss level.\n");
        }

        static public string EndLevelMenu(int num)
        {
            switch (num)
            {
                case 1:
                    return "Next level";

                case 2:
                    return "Levels";

                case 3:
                    return "Main menu";

                default:
                    return "Next level";
                   

            }
        }                 

        static public void PrintEndLevelMenu()
        {
            Console.WriteLine($"1. Next level\n" +
                              $"2. Levels.\n" +
                              $"3. Main menu.");
        }
    }
}
