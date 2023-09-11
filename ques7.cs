using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class xy
    {
    private static  int x=20;
    private static int y=30;
    public void xyz(int a, int b) {
        Console.WriteLine(" changed value are :");
        
           x=a;
            y=b; 
        Console.WriteLine(a+","+b); 
        

    }
        static void Main(string[] args)
        {
        Console.WriteLine("now the value of a && b are"+x+" "+y);
        xy xy = new xy(); 
        Console.WriteLine("enter the value of a ");
        
      int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the value of b");
        int b = int.Parse(Console.ReadLine());
        xy.xyz(a, b);

        }
    }

