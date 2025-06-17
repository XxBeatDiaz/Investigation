using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class Game
    {
        static public void Menu()
        {
            Sensor[] sensorArry = { new AudioSensor(), new PulseSensor(), new AudioSensor(), new ThermalSensor() };
            Terrorist terrorist = new Terrorist("Gabi", sensorArry);

            bool endFlag = true;
            int counterTurnes = 1;
            int amountFailures = 10;
            while (endFlag)
            {
                PrintMenu();
                int userSensor = int.Parse(Console.ReadLine()!);
                Sensor sensor = ChooseSensor(userSensor);
                CheckPlaceForSensor(ref terrorist.Sensors, sensor);
                int isMatch = Activate(ref terrorist.Sensors, terrorist.Weaknesses);
                Console.WriteLine($"{isMatch}/{terrorist.Weaknesses.Length}\n");
                foreach (var item in terrorist.Sensors)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    Console.WriteLine($"{item.Name}: {item.IsActivate()}");
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

        static private Sensor ChooseSensor(int num)
        {
            Sensor sensor = new Sensor();

            if (num == 1)
            {
                sensor = new AudioSensor();
            }
            else if (num == 2)
            {
                sensor = new ThermalSensor();
            }
            else if (num == 3)
            {
                sensor = new PulseSensor();
            }
            return sensor;
        }

        static private void CheckPlaceForSensor(ref Sensor[] sensors, Sensor sensor)
        {
            for (int i = 0; i < sensors.Length; i++)
            {
                if (sensors[i] == null || !sensors[i].IsActivate())
                {
                    sensors[i] = sensor;
                    break;
                }
            }
        }

        static private bool CheckSensors(Sensor sensor)
        {
            switch (sensor.TypeSensor)
            {
                case "Audio sensor":
                    return sensor.IsActivate();


                case "Thermal sensor":
                    return sensor.IsActivate();


                case "Pulse sensor":
                    return sensor.IsBreak();
                default:
                    return true;

            }
        }

        static private int Activate(ref Sensor[] sensors, Sensor[] weaknesses)
        {
            int counterActivates = 0;
            bool[] sensorUsed = new bool[weaknesses.Length];


            for (int i = 0; i < sensors.Length; i++)
            {
                if (sensors[i] == null)
                {
                    continue;
                }

                for (int j = 0; j < weaknesses.Length; j++)
                {
                    if (sensorUsed[j])
                    {
                        continue;
                    }

                    if (weaknesses[j].TypeSensor == sensors[i].TypeSensor)
                    {
                        sensorUsed[j] = true;
                        sensors[i].FlagActive = true;
                        counterActivates++;
                        if (CheckSensors(sensors[i]))
                        {
                            sensorUsed[j] = false;
                            sensors[i].FlagActive = false;
                            Console.WriteLine($"{sensors[i].TypeSensor}");
                            break;
                        }
                        break;
                                            
                    }
                }
            }
            return counterActivates;
        }

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

        static private bool CheckEndTurnes(int amountFailures, int counterFailures)
        {
            bool isEnd = false;
            if (counterFailures >= amountFailures)
            {
                isEnd = true;
            }
            return isEnd;
        }


        //Optainal for future
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
