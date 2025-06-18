using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class SquadLeader : Terrorist
    {
        int CounterTurns;

        public SquadLeader(string name, Sensor[] weaknesses) : base(name, weaknesses)
        {
            CounterTurns = 4;
        }

        //CounterTurns min 1
        public override int CountDown()
        {
            return CounterTurns--;
        }

        //Check if CounterTurns is done
        public override bool EndCounterTurns()
        {
            if (CounterTurns <= 0)
            {
                CounterTurns = 4;
                return true; 
            }
            return false;
        }
    }
}
