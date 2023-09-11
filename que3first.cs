using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3b
{
    internal class ba
    {
        public void display()
        {
            ConsoleApp3a.Program program = new ConsoleApp3a.Program(); // Create an instance of Program from ConsoleApp3a
            Console.WriteLine("Here's the internal name from a different assembly: " + program.name);
        }
        public static void Main(string[] args) { 
            ba bba = new ba();
            bba.display();
        }

    }
}
       
    

