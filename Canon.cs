using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Canon : IPrinterWindows
    {
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }

        public void Show(PrinterWindows show)
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}
