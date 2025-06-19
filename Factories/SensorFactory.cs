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
            switch (type)
            {
                case 1:
                    return new AudioSensor();

                case 2:
                    return new ThermalSensor();

                case 3:
                    return new PulseSensor();

                default:
                     return new Sensor();
            }
        }
    }
}

