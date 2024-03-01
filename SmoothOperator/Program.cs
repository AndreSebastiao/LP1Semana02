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

            //Output the byte with changes in value
            //Decrement
            Console.WriteLine(--n);
            //Increment
            Console.WriteLine(++n);
            //Division
            Console.WriteLine(n/2);
            //Shift Left
            Console.WriteLine(n<<3);
            //Xor
            Console.WriteLine(n^5);
            //If > 10
            Console.WriteLine(n>10);
        }
    }
}
