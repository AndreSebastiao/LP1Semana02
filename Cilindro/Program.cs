using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for Hight
            Console.Write("High of the Cylinder: ");
            //Read and Transform Hight in to a float
            float a = float.Parse(Console.ReadLine());
            //Ask for Radius
            Console.Write("Radius of the Cylinder: ");
            //Read and Transform Radius in to a float
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(r);
        }
    }
}
