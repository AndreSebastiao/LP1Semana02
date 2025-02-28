using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Start number: ");
                int i = int.Parse(Console.ReadLine());

                Console.Write("Step number: ");
                int j = int.Parse(Console.ReadLine());

                if (i <= 0)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                else if (i <= j)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }
                else if (i % j != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine(i);
                        if (i == 0)
                        {
                            break;
                        }
                        i = i - j;
                    }                  
                }
            }
        }
    }
}
