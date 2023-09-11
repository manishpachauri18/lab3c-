using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class owner
{
    public void print()
    {
        Console.WriteLine("the private variable is " + name);
    }
    public static void Main(string[] args)
    {
        owner o = new owner();
        o.print();
    }
}

