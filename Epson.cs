using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Epson : IPrinterWindows
    {
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public void Show(PrinterWindows show)
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
