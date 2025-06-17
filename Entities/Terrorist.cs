using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Terrorist
    {
        string? Name;

        public Sensor[] Weaknesses;
        public Sensor[] Sensors; 
        
        public Terrorist(string name, Sensor[] weaknesses)
        {
            Name = name;
            Weaknesses = weaknesses;
            Sensors = new Sensor[4];
        }
    }
}
