using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class LevelsManager
    {
        public static void NewGame()
        {
            string levelOne = "LevelOne";
            ChoosLevel(levelOne);
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
                    return "Level three";
            }
        }

        public static void ChoosLevel(string level)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                switch (level)
                {
                    case "Level one":
                        Levels.LevelOne();
                        level = "Level two";
                        break;

                    case "Level two":
                        Levels.LevelTwo();
                        level = "Level three";
                        break;

                    case "Level three":
                        Levels.LevelThree();
                        level = "Done";
                        break;

                    case "Done":
                        gameOver = true;
                        break;

                    default:
                        gameOver = true;
                        break;
                }
            }
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
    }
}
