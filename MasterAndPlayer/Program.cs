using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the input from Master
            Console.Write("Number Master, please insert an int: ");
            int m = int.Parse(Console.ReadLine());

            //Check if the number is valid
            if (m < 0 || m > 100)
            {
                Console.WriteLine("That number is invalid!");
                return;
            }

            //Clear the console
            for (int i = 1; i != 100; i++)
            {
                Console.WriteLine("");
            }

            //Playing loop
            while (true)
            {
                //Ask for the input from Player
                Console.Write("Player, please insert an int: ");
                int p = int.Parse(Console.ReadLine());

                //Check if the number is valid
                if (p < 0 || p > 100)
                {
                    Console.WriteLine("That number is invalid!");
                }
                else
                {
                    //Check if the number is the same and give guesses to the player
                    if (p < m)
                    {
                        Console.WriteLine($"The correct number is higher then {p}");
                    }
                    else if (p > m)
                    {
                        Console.WriteLine($"The correct number is lower then {p}");
                    }
                    else if (p == m)
                    {
                        Console.WriteLine("Player wins!");
                        //Stop the game
                        break;
                    }
                }
            }
        }
    }
}
