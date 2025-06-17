using Investigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public static class SensorFactory 
    {
        static public Sensor CreateSensor(int type)
        {
            if (type == 1) return new AudioSensor();
            if (type == 2) return new ThermalSensor();
            if (type == 3) return new PulseSensor();

            else return new Sensor();
        }
    }
}

