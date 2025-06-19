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
    }
}
