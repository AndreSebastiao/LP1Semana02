using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere a altura do cilindro: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insere o raio do cilindor: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * Math.Pow(r, 2) * a:f3}");
            Console.WriteLine($"{2 * Math.PI * r * (r + a):f3}");
        }
    }
}
