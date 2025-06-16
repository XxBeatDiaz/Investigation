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
            Sensor[] sensorArry = { new AudioSensor(), new AudioSensor() };
            Terrorist terrorist = new Terrorist("Avi", sensorArry);

            bool endFlag = true;
            int counterTurnes = 1;
            int amountFailures = 7;
            while (endFlag)
            {
                PrintMenu();
                int userSensor = int.Parse(Console.ReadLine()!);
                Sensor sensor = ChooseSensor(userSensor);               
                CheckSensor(ref terrorist.Sensors, sensor);
                int isMatch = Activate(ref terrorist.Sensors, terrorist.Weaknesses);
                Console.WriteLine($"{isMatch}/{terrorist.Weaknesses.Length}");

                counterTurnes++;

                if (CheckVictory(terrorist.Sensors))
                {
                    Console.WriteLine($"You are the winner.");
                    endFlag = false;
                }
                else if(CheckEndTurnes(amountFailures, counterTurnes))
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
                              $"2. Thermal sensor");
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
            return sensor;
        }

        static private void CheckSensor(ref Sensor[] sensors, Sensor sensor)
        {
            for (int i = 0; i < sensors.Length; i++)
            {
                if (sensors[i] == null || sensors[i].FlagActive == false)
                {
                    sensors[i] = sensor;
                    break; 
                }
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

                    if ( weaknesses[j].TypeSensor == sensors[i].TypeSensor)
                    {
                        sensorUsed[j] = true;
                        sensors[i].FlagActive = true;
                        counterActivates++;
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
                if (sensor == null|| sensor.FlagActive == false )
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

                if (userPlace < 0 || userPlace > weaknesses.Length -1)
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
