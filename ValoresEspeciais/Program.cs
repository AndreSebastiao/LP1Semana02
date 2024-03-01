using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Values
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

            //Byte values
            bt = byte.MaxValue;
            Console.WriteLine(bt);
            bt = byte.MinValue;
            Console.WriteLine(bt);

            //sByte values
            sbt = sbyte.MaxValue;
            Console.WriteLine(sbt);
            sbt = sbyte.MinValue;
            Console.WriteLine(sbt);

            //Short values
            short = short.MaxValue;
            Console.WriteLine(sh);
            short = short.MinValue;
            Console.WriteLine(sh);

            //uShort values
            ushort = ushort.MaxValue;
            Console.WriteLine(ush);
            ushort = ushort.MinValue;
            Console.WriteLine(ush);

            //int values
            int = int.MaxValue;
            Console.WriteLine(i);
            int = int.MinValue;
            Console.WriteLine(i);

            //uint values
            uint = int.MaxValue;
            Console.WriteLine(ui);
            uint = int.MinValue;
            Console.WriteLine(ui);

            //long values
            long = long.MaxValue;
            Console.WriteLine(ln);
            long = long.MinValue;
            Console.WriteLine(ln);

            //ulong values
            ulong = ulong.MaxValue;
            Console.WriteLine(uln);
            ulong = ulong.MinValue;
            Console.WriteLine(uln);

            //char values
            char = char.MaxValue;
            Console.WriteLine(ch);
            char = char.MinValue;
            Console.WriteLine(ch);

            //double values
            double = double.MaxValue;
            Console.WriteLine(db);
            double = double.MinValue;
            Console.WriteLine(db);

            //float values
            float = float.MaxValue;
            Console.WriteLine(f);
            float = float.MinValue;
            Console.WriteLine(f);

            //decimal values
            decimal = decimal.MaxValue;
            Console.WriteLine(dc);
            decimal = decimal.MinValue;
            Console.WriteLine(dc);

            //int overflow
            ui = uint.MaxValue;
            Console.WriteLine(ui + 1);

            //double infinite
            db = 2 * double.MaxValue;
            Console.WriteLine(db);

            //?
            f = 100000000.0f;
            f2 = f1;
            Console.WriteLine(f2 == f + 0.000000001f);
        }
    }
}
