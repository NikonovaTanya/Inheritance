using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class PrinterDerived1:Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
}
