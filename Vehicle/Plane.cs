using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Plane : Vehicle
    { private int h;
        private int count;
        public Plane()
        { }
        public Plane(int x, int y, int v, int p, int year, int h, int count)
              : base(x, y, v, p, year)
        {
            this.h = h;
            this.count = count;
        }
        public override void print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                         Plane");
            Console.Write("Координаты  " + x + "  " + y + "  скорость  " + v + "  цена  " + price + "  год выпуска  " + year + "  высота " + h + "  количество пассажиров  " + count);
        }

    }
}
