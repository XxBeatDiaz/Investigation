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

        //Check if the sensor break
        public override bool IsBreak()
        {
            bool isBreak = false;
            if (CounterBreak <= 0)
            {
                Console.WriteLine("\nBreak sensor: pulse");
                isBreak = true;
            }
            return isBreak;

        }

        //Minus activae by 1
        public override void  MinusActivate()
        {
            CounterBreak--;
        }
    }
}
