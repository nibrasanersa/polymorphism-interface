using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet : IPrinterWindows
    {
        public void Show(PrinterWindows show)
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
