using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class printerWindows
 {
    public string name { get; set; }
    public virtual void tmpl()
    {
        Console.WriteLine("Input Error");
    }
    public virtual void print()
    {
        //Console.WriteLine("Input Error");
    }
  }
}
