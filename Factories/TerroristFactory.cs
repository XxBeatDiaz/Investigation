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
        public static Sensor[] weaknesses = { SensorFactory.CreateSensor(1), SensorFactory.CreateSensor(2) };
        public static Sensor[] weaknessesLevel_1 = {SensorFactory.CreateSensor(1), SensorFactory.CreateSensor(2)};
        public static Sensor[] weaknessesLevel_2 = {SensorFactory.CreateSensor(1), SensorFactory.CreateSensor(2), SensorFactory.CreateSensor(3), SensorFactory.CreateSensor(2)};

        public Terrorist CreateTerrorist(int level)
        {
            if (level == 1) return new Terrorist("ahmed", weaknessesLevel_1);
            if (level == 2) return new SquadLeader("avi", weaknessesLevel_2);

            else return new Terrorist("avi", weaknesses);
        }
    }
}
