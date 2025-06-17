using Investigation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class PulseSensor : Sensor
    {
        public PulseSensor() : base()
        {
            Name = "Pulse sensor";
            TypeSensor = "Pulse sensor";
            CounterBreak = 3;
        }

        public override bool IsBreak()
        {
            bool isBreak = false;
            if (CounterBreak <= 0)
            {
                Console.WriteLine("Break pulse\n");
                isBreak = true;
            }
            return isBreak;

        }

        public override void  MinusActivate()
        {
            CounterBreak--;
        }
    }
}
