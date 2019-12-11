using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Ship:Vehicle
    {
        private int count;
        private string port;

        public Ship() { }
        public Ship(int x, int y, int v, int p, int year, int count, string port)
              : base(x, y, v, p, year)
        {
             this.count = count;
             this.port = port;
        }
        public override void print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                               Ship");
            Console.Write("Координаты  "+x+"  "+y + "  скорость  "+v + "  цена  "+price+"  год выпуска  " +year+"  количество пассажиров "+count+"  порт  "+port);
       }

    }
}
