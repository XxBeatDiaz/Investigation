using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class SquadLeader : Terrorist
    {
        int CounterTurnes;
        public SquadLeader(string name, Sensor[] weaknesses) : base(name, weaknesses)
        {
            CounterTurnes = 4;
        }

        public int CountDown()
        {
            return CounterTurnes--;
        }

        public bool CheckTurnes(int turnes)
        {
            if (turnes >= 4)
            {
                return false; 
            }
            return true;
        }

        public void RemoveSensor()
        {
            Sensors[Sensors.Length] = null!;
        }
    }
}
