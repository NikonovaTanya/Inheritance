using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom cr = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());
            cr.printIWrite();
            Console.WriteLine("------------------------------------------");
            cr.printRead();
            Console.WriteLine("------------------------------------------");
            cr.printStudy();
            Console.WriteLine("------------------------------------------");
            cr.printRelax();
        }
    }
}
