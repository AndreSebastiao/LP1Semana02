using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            sbyte i = sbyte.Parse(Console.ReadLine());

            i--;
            Console.WriteLine(i);

            i++;
            Console.WriteLine(i);
        }
    }
}
