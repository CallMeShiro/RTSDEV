using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace StenSaxPase
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgain = true;
 
            while (playAgain)
            {
 
                int scorePlayer = 0;
                int scoreCPU = 0;
 
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                   
 
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
 
                    Random rnd = new Random();
 
                    randomInt = rnd.Next(1, 4);
 
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "STEN";
                            Console.WriteLine("Computer chose STEN");
                            if (inputPlayer == "STEN")
                            {
                                Console.WriteLine("Oavgjort!!\n\n");
                            }
                            else if (inputPlayer == "PÅSE")
                            {
                                Console.WriteLine("Spelare wins!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SAX")
                            {
                                Console.WriteLine("AI Vinner!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PÅSE";
                            Console.WriteLine("AI Valde PÅSE");
                            if (inputPlayer == "PÅSE")
                            {
                                Console.WriteLine("Oavgjort!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("AI Vinner!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SAX")
                            {
                                Console.WriteLine("Spelare Vinner!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SAX";
                            Console.WriteLine("AI Valde Sax");
                            if (inputPlayer == "SAX")
                            {
                                Console.WriteLine("Oavgjort!\n\n");
                            }
                            else if (inputPlayer == "STEN")
                            {
                                Console.WriteLine("Spelare Vinner!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PÅSE")
                            {
                                Console.WriteLine("AI Vinner!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
 
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
 
                }
 
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Spelare Vann!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("AI VANN!");
                }
                else
                {
 
                }
 
                Console.WriteLine("Vill du spela igen?(j/n)");
                string loop = Console.ReadLine();
                if (loop == "j")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
               
                }
 
            }
        }
    }
}
