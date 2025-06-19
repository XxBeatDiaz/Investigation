using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Menu
    {
        static public void MainMenu()
        {

        }

        static public void LevelsMenu(int choss)
        {
            string level = LevelsManager.NumToLevel(choss);
            LevelsManager.ChoosLevel(level);
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
