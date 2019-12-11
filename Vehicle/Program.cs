using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(5,4,80,400,2000, 500,"Dnepr");
            ship.print();
            Car car = new Car(25, 25, 150, 5, 1998 );
            car.print();
            Plane plane = new Plane(300, 300, 80, 400, 1996, 500, 20 );
            plane.print();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
