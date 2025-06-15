using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Sensor
    {
        string Name { get; set; }

        static public int Activat(string[] sensors, string[] weaknesses)
        {
            int counterActivates = 1;
            foreach (var sensor in sensors)
            {
                if (weaknesses.Contains(sensor))
                {
                    counterActivates++;
                }
            }
            return counterActivates;
        }
    }
}
