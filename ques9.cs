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
            Console.WriteLine(" hey god (shree radhey krishna):: please help me to complete my dreams ");
            Console.WriteLine("i want to open a school");
            Console.WriteLine(" i want to buy  a car which name is THAR :");
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

