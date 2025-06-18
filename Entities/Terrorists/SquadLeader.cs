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

        //CounterTurnes min 1
        public int CountDown()
        {
            return CounterTurnes--;
        }

        //Check if CounterTurnes is done
        public bool CheckTurnes()
        {
            if (CounterTurnes <= 0)
            {
                CounterTurnes = 4;
                return false; 
            }
            return true;
        }

        //Remove sensor after CounterTurnes is done
        public Sensor RemoveSensor()
        {
            int length = Sensors.Length;
            Sensor sensor = Sensors[length];

            while (true)
            {
                sensor = Sensors[length];
                if (!sensor.IsActivate())
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

        //If the sensor is true change to false if false change to true
        public void UpdateWeaknessActivate(Sensor sensor)
        {
            int idx = Array.IndexOf(Weaknesses, sensor);
            if (sensor.IsActivate())
            {
                Weaknesses[idx].FlagActive = false; 
            }
            else
            {
                Weaknesses[idx].FlagActive = true;
            }
        }
    }
}
