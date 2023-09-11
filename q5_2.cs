using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5a
{
    public class Program1 : Program
    {
        void access()
        { Console.WriteLine("the name is" + name); display(); }
        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.access();
            
        }
    }
}
