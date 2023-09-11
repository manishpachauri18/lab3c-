using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:InternalsVisibleTo("Program")]

namespace ConsoleApp10
{
    internal class Program10a
    {
        internal Program10a() { Console.WriteLine("hi  this is the constructor of class program which lies in first assembly "); }
       internal  void display()
        {
            Console.WriteLine("done.........");
        }
    }
}
