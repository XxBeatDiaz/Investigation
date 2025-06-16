using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class ThermalSensor : Sensor
    {
        public ThermalSensor() : base()
        {
            Name = "Thermal sensor";
            TypeSensor = "Thermal sensor";
        }
    }
}
