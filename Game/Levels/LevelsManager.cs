using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class LevelsManager
    {
        public void ChoosLevel(string level)
        {
            switch (level)
            {
                case "Level one":
                    Levels.Level_1();
                    break;

                case "Level two":
                    Levels.Level_2();
                    break;

                case "Level three":
                    Levels.Level_3();
                    break;
                    
            }
        }


        public void LevelList()
        {
            Console.WriteLine($"Beginners: " +
                              $"1. Level one." +
                              $"2. Level two." +
                              $"3. Level three." +
                              $" " +
                              $"Advanced: " +
                              $"4. Level four." +
                              $"5. Level five." +
                              $"6. Level six." +
                              $" " +
                              $"Pros: " +
                              $"7. Level seven." +
                              $"8. Level eight." +
                              $"9. Level ten." +
                              $" " +
                              $"10. Boss level.");    
        }
    }
}
