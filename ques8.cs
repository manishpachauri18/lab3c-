using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        private void  privatemsg()
            {
            Console.WriteLine("hi  I love you very much");
            Console.WriteLine("i am just kidding ");

            }
        public void  callprivate()
        {
            Console.WriteLine("here i am caliing private method ");
            for(int i = 0; i < 10; i++) { 
            Console.WriteLine("processing..............");
            }
            privatemsg();
        
        }
        static void Main(string[] args)
        {
            Program p=  new Program();
            p.callprivate();
        }
    }
}
