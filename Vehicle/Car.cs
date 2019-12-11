using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car:Vehicle
    { public Car() { }
      public Car( int x, int y, int v, int p, int year)
            : base(x, y, v, p, year)
        {
            
        }
        public override void print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                     Car      ");
            Console.Write("Координаты  " + x + "  " + y + "  скорость  " + v + "  цена  " + price + "  год выпуска  " + year);
        }
    }
}
