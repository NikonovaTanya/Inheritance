using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Printer
    { public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
      }
    }
}
