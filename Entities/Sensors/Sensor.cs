using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Sensor
    {
        public string? Name { get; set; } 
        public string? TypeSensor { get; set; }
        public bool FlagActive { get; set; }
        public int CounterBreak { get; set; }

        public Sensor()
        {
            Name = "Sensor";
            TypeSensor = "Sensor";
            FlagActive = false;
        }

        public bool IsActivate()
        {            
            return FlagActive;
        }

        public virtual bool IsBreak()
        {
            return false;
        }

        public virtual void MinusActivate() { }       


    }
}
