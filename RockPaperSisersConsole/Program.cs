using System;
using System.Collections.Generic;

namespace RockPaperSisersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            int cpuInput;
            var list = new List<string> { "Paper", "Rock", "Scissors" };


            while (true)
            {
                Console.WriteLine("Paper, Rock, Scissors: ");
                playerInput = Console.ReadLine();
                var firstLetter =playerInput.Substring(0, 1).ToUpper();
                var restOfTheLetters = playerInput.Substring(1).ToLower();
                playerInput = firstLetter + restOfTheLetters;

                //Console.WriteLine(playerInput);

                Random random = new Random();
                cpuInput = random.Next(list.Count);
                var cpuResult = list[cpuInput];
                Console.WriteLine(cpuResult);

                if (playerInput == cpuResult)
                {
                    Console.WriteLine("Its a tie!!");
                    Console.WriteLine("----------------------------------------------");
                }
                else
                {
                    if (playerInput == "Paper")
                    {
                        if (cpuResult == "Rock")
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("You lose :(");
                            Console.WriteLine("----------------------------------------------");
                        }
                    }
                    else if(playerInput == "Rock")
                    {
                        if (cpuResult == "Scissors")
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("You lose :(");
                            Console.WriteLine("----------------------------------------------");
                        }
                    }
                    else if(playerInput == "Scissors")
                    {
                        if (cpuResult == "Paper")
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("You lose :(");
                            Console.WriteLine("----------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't make up words!");
                        Console.WriteLine("----------------------------------------------");
                    }
                }
            }
        }
    }
}
