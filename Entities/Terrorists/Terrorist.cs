using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Terrorist
    {
        public string? Name { get; set; }

        public Sensor[] Weaknesses;
        public Sensor[] Sensors;

        public Terrorist(string name, Sensor[] weaknesses)
        {
            Name = name;
            Weaknesses = weaknesses;
            Sensors = new Sensor[weaknesses.Length];
        }

        //CounterTurnes min 1 (Virtual)
        public virtual int CountDown()
        {
            return -1;
        }

        //Check if CounterTurns is done (Virtual)
        public virtual bool EndCounterTurns()
        {
            return false;
        }

        //Remove 1 sensor after CounterTurns is done (virtual)
        public Sensor RemoveSensor()
        {
            int length = Sensors.Length - 1;
            Sensor sensor = Sensors[length];

            while (true)
            {
                sensor = Sensors[length];
                if (sensor == null || !sensor.IsActivate())
                {
                    if (length <= 0)
                    {
                        //Default remove
                        sensor = Sensors[Sensors.Length];
                        break;
                    }
                    length--;
                }
                else
                {
                    break;
                }
            }

            Sensors[length] = null!;
            return sensor;
        }

        //If the sensor is true change to false if false change to true (virtual)
        public void UpdateWeaknessActivate(ref Sensor[] sensors, Sensor sensor)
        {
            foreach (var item in sensors)
            {
                if (item.TypeSensor == sensor.TypeSensor)
                {
                    if (item.IsActivate())
                    {
                        item.FlagActive = false;
                        break;
                    }
                }
            }

            //int idx = Array.IndexOf(Weaknesses, sensor);
            //if (idx <= -1)
            //{
            //}
        }
    }
}
