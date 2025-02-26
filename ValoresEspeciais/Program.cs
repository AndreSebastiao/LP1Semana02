using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte    bt;
            sbyte   sbt;
            short   sh;
            ushort  ush;
            int     i;
            uint    ui;
            long    ln;
            ulong   uln;
            char    ch;
            double  db;
            float   f;
            float   f2;
            decimal dc;

            Console.WriteLine(bt = byte.MaxValue);
            Console.WriteLine(bt = byte.MinValue);

            Console.WriteLine(sbt = sbyte.MaxValue);
            Console.WriteLine(sbt = sbyte.MaxValue);

            Console.WriteLine(sh = short.MaxValue);
            Console.WriteLine(sh = short.MinValue);

            Console.WriteLine(ush = ushort.MaxValue);
            Console.WriteLine(ush = ushort.MinValue);

            Console.WriteLine(i = int.MaxValue);
            Console.WriteLine(i = int.MinValue);

            Console.WriteLine(ui = uint.MaxValue);
            Console.WriteLine(ui = uint.MinValue);

            Console.WriteLine(ln = long.MaxValue);
            Console.WriteLine(ln = long.MinValue);

            Console.WriteLine(uln = ulong.MaxValue);
            Console.WriteLine(uln = ulong.MinValue);

            Console.WriteLine(ch = char.MaxValue);
            Console.WriteLine(ch = char.MinValue);

            Console.WriteLine(db = double.MaxValue);
            Console.WriteLine(db = double.MinValue);

            Console.WriteLine(f = float.MaxValue);
            Console.WriteLine(f = float.MinValue);

            Console.WriteLine(dc = decimal.MaxValue);
            Console.WriteLine(dc = decimal.MinValue);
        }
    }
}
