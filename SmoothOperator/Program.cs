using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user for a positive whole number
            Console.Write("Insert a positive whole number: ");

            //Converting the number in to a byte
            byte n = byte.Parse(Console.ReadLine());

            //Output the byte with increments and decrements
            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
