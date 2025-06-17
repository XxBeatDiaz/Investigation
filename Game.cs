using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Game
    {
        static public void Menu()
        {
            int level1 = 2;
            Terrorist terrorist =  TerroristFactory.CreateTerrorist(level1);

            bool endFlag = true;
            int counterTurnes = 1;
            int amountFailures = 10;
            while (endFlag)
            {
                PrintMenu();
                int userSensor = int.Parse(Console.ReadLine()!);
                Sensor sensor = SensorFactory.CreateSensor(userSensor);
                int isMatch = Activate(ref terrorist.Sensors, ref terrorist.Weaknesses, sensor);
                CheckDuplicat(ref terrorist.Sensors, ref sensor);
                CheckAllSensors(ref terrorist.Sensors, ref terrorist.Weaknesses, ref isMatch);

                Console.WriteLine($"{isMatch}/{terrorist.Weaknesses.Length}\n");
                foreach (Sensor terSen in terrorist.Sensors)
                {
                    if (terSen == null)
                    {
                        continue;
                    }
                    Console.WriteLine($"{terSen.Name}: {terSen.IsActivate()}");
                }

                counterTurnes++;

                if (CheckVictory(terrorist.Sensors))
                {
                    Console.WriteLine($"You are the winner.");
                    endFlag = false;
                }
                else if (CheckEndTurnes(amountFailures, counterTurnes))
                {
                    Console.WriteLine($"You lose the game.");
                    endFlag = false;
                }
            }
        }


        static private void PrintMenu()
        {
            Console.WriteLine("Which sensor to add?");
            Console.WriteLine($"1. Audio sensor.\n" +
                              $"2. Thermal sensor.\n" +
                              $"3. Pulse sensor.");
        }

        //User choosing sensor
        //static private Sensor ChooseSensor(int num)
        //{
        //    Sensor sensor = new Sensor();

        //    if (num == 1)
        //    {
        //        sensor = new AudioSensor();
        //    }
        //    else if (num == 2)
        //    {
        //        sensor = new ThermalSensor();
        //    }
        //    else if (num == 3)
        //    {
        //        sensor = new PulseSensor();
        //    }
        //    return sensor;
        //}

        //Check specific sensor

        static private bool CheckSensor(Sensor sensor)
        {
            switch (sensor.TypeSensor)
            {
                case "Audio sensor":
                    return sensor.IsActivate();


                case "Thermal sensor":
                    return sensor.IsActivate();


                case "Pulse sensor":                    
                    if (sensor.IsBreak())
                    {
                        sensor.FlagActive = false;
                    }
                    else
                    {
                        sensor.MinusActivate();
                    }
                    return sensor.IsActivate();

                default:
                    return true;

            }
        }

        //Check all the sensors and return the new match
        static private void CheckAllSensors(ref Sensor[] sensors, ref Sensor[] weaknesses, ref int isMatch)
        {
            foreach (var item in sensors)
            {
                if (item != null)
                {
                    item.FlagActive = CheckSensor(item);
                    if (!item.FlagActive)
                    {
                        isMatch--;
                        foreach (var item1 in weaknesses)
                        {
                            if (item1.TypeSensor == item.TypeSensor)
                            {
                                item1.FlagActive = false;
                            }
                        }
                    }
                }
            }
        }

        //Check duplicat for breakable sensors
        static private void CheckDuplicat(ref Sensor[] sensors, ref Sensor sensor)
        {
            foreach (var item in sensors)
            {
                if (item != null && sensor.TypeSensor == "Pulse sensor" && item.TypeSensor == "Pulse sensor")
                {
                    if (item.CounterBreak < 1)
                    {
                        int idx = Array.IndexOf(sensors, item);
                        sensor.FlagActive = true;
                        sensors[idx] = sensor;
                        break;
                    }
                }
            }
        }

        //Check if the sensor exist and add to terrorisr arry for sensors
        static private int Activate(ref Sensor[] sensors, ref Sensor[] weaknesses, Sensor sensor)
        {
            
            
            foreach (Sensor  weakness in weaknesses)
            {
                if (!weakness.IsActivate() && weakness.TypeSensor == sensor.TypeSensor )
                {
                    for (int i = 0; i < sensors.Length; i++)
                    {
                        if (sensors[i] == null || !sensors[i].IsActivate()) 
                        {
                            weakness.FlagActive = true;
                            sensor.FlagActive = true;                           
                            sensors[i] = sensor;
                            break;
                        }
                    }
                    break;
                }                
            }

            int counterActivate = 0;
            foreach (var item in sensors)
            {
                if (item != null && item.IsActivate())
                {
                    counterActivate++;
                }
            }
            return counterActivate;
        }

        //Check if the player won the level
        static private bool CheckVictory(Sensor[] sensros)
        {
            bool isVictory = false;
            foreach (Sensor sensor in sensros)
            {
                if (sensor == null || sensor.FlagActive == false)
                {
                    return isVictory;
                }
            }
            isVictory = true;
            return isVictory;
        }

        //Check if the player turnes out of range and stop the game
        static private bool CheckEndTurnes(int amountFailures, int counterFailures)
        {
            bool isEnd = false;
            if (counterFailures >= amountFailures)
            {
                isEnd = true;
            }
            return isEnd;
        }


        //Optainal for future to make the game harder
        static private Sensor[] ChoosePlace(Sensor[] weaknesses, Sensor[] sensors, Sensor sensor)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write($"Choose place from: 0 to: {weaknesses.Length - 1}: ");
                int userPlace = int.Parse(Console.ReadLine()!);

                if (userPlace < 0 || userPlace > weaknesses.Length - 1)
                {
                    continue;
                }

                sensors[userPlace] = sensor;
                flag = false;
            }
            return sensors;
        }
    }
}
