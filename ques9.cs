using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        protected void dream() {
            Console.WriteLine("  ");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
    class dreams:Program
    { 
        void acessp()
        {
            Console.WriteLine("here  we acess  the protected method:         ");
            dream();
        }
        static void Main(string[] args)
        {
            dreams d=new dreams();
            d.acessp();
        }
    }
}

