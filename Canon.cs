using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
   public class Canon : printerWindows
 {
    public override void tmpl()
    {
        Console.Write("Canon display dimension : ");
        string nomorPrinter = Console.ReadLine();
    }

    public override void print()
    {
        Console.WriteLine("Canon printer printing ....");
    }
 }
}