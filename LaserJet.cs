using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
  
   public class LaserJet : printerWindows
 {
    public override void tmpl()
    {
        Console.Write("Laserjet display dimension : ");
        string nomorPrinter = Console.ReadLine();
    }
    public override void print()
    {
        Console.WriteLine("LaserJet printer printing ....");
    }
  }
}