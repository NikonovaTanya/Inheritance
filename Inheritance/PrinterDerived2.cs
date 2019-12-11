using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class PrinterDerived2:Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
        }
    }
}
