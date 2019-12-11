using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        protected int x;
        protected int y;
        protected int v;
        protected int price;
        protected int year;

        public Vehicle()
        { 
        }
        public Vehicle(int x, int y, int v, int p, int year)
        {
            this.x = x;
            this.y = y;
            this.v = v;
            this.price = p;
            this.year = year;
        }
        public virtual void  print()
        { 
            Console.WriteLine("                               Vehicle");
            Console.Write("Координаты  " + x + "  " + y + "  скорость  " + v + "  цена  " + price + "  год выпуска  " + year);
        }
    }
}
