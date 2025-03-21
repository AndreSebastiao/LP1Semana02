﻿using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            uint i = uint.MaxValue;
            double x = double.MaxValue;
            float f1, f2;

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);

            Console.WriteLine(i + 1);

            Console.WriteLine(x * 2);
            Console.WriteLine(x + 1);

            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);
        }
    }
}
