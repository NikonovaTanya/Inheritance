using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
          
            PrinterDerived1 printDerived1 = new PrinterDerived1();
            printDerived1.Print("Print Derived1");
            Console.WriteLine(printDerived1.GetHashCode()); 


            PrinterDerived2 printDerived2 = new PrinterDerived2();
            printDerived2.Print("Print Derived2");
            Console.WriteLine(printDerived2.GetHashCode());

          

            Printer print = printDerived1;
            print.Print("Base print Up Cast  print = printDerived1");
            Console.WriteLine(print.GetHashCode());
            print = printDerived2;
            print.Print("Base print Up Cast  print = printDerived2");
            Console.WriteLine(print.GetHashCode());

            print = (PrinterDerived1)printDerived1;
            print.Print("Base print Up Cast print = printDerived2--> printDerived1");
            Console.WriteLine(print.GetHashCode());

            

            PrinterDerived1 PrinterDerivedNew = (PrinterDerived1)print;
            PrinterDerivedNew.Print("Down Cast");
            Console.WriteLine(PrinterDerivedNew.GetHashCode());



        }
    }
}
