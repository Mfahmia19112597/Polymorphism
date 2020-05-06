using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class Epson : printerWindows
 {
    public override void tmpl()
    {
        Console.Write("Epson display dimension : ");
        string nomorPrinter = Console.ReadLine();
    }
    public override void print()
    {
        Console.WriteLine("Epson printer printing ....");
    }
  }
}