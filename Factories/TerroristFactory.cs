using Investigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class TerroristFactory : ITerroristFactory
    {
        public static Sensor[] weaknesses = { SensorFactory.CreateSensor(Rand()), SensorFactory.CreateSensor(Rand()) };
        public static Sensor[] weaknessesLevel_1 = { SensorFactory.CreateSensor(Rand()), SensorFactory.CreateSensor(Rand()) };
        public static Sensor[] weaknessesLevel_2 = { SensorFactory.CreateSensor(Rand()), SensorFactory.CreateSensor(Rand()), SensorFactory.CreateSensor(Rand()), SensorFactory.CreateSensor(Rand()) };

        public Terrorist CreateTerrorist(int level)
        {
            switch (level)
            {
                case 1:
                    return new Terrorist("Terrorist", weaknessesLevel_1);

                case 2:
                    return new SquadLeader("Squad leader", weaknessesLevel_2);

                default:
                    return new Terrorist("Base terrorist", weaknesses);
            }           
        }

        static private int Rand()
        {
            Random rand = new();
            int num = rand.Next(1,4);
            return num;
        }
    }
}
