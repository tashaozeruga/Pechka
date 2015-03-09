using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pechka p1 = new Pechka();
            Pechka p2 = new Pechka();
            Pechka p3 = new Pechka();

            p2.nagrev();
            p3.nagrev();
            p2.nagrev();
            p1.t = 100;
            
            Console.WriteLine("p1 t=" + p1.t);
            Console.WriteLine("p2 t=" + p2.t);
            Console.WriteLine("p3 t=" + p3.t);
            p1.lamp.l = "off";
            Console.WriteLine("Lamp of p1 " + p1.lamp.l);
            Console.WriteLine("Lamp of p2 " + p2.lamp.l);
            Console.WriteLine("Lamp of p3 " + p3.lamp.l);
            Pechka p4 = p2;
                     

            p2 = p1;
            p4.lamp.l = "flash";
            Console.WriteLine("Lamp of p4 " + p4.lamp.l);
            Console.WriteLine("Lamp of p2 " + p2.lamp.l);
            
            /*
            string a = "cinnamon";
            string b = "sugar";
            Console.WriteLine(a + b);
            Console.WriteLine(b + a);
            string c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("salt" + b);
            int d = 34;
            Console.WriteLine(a + d);
            int e = 43;
            Console.WriteLine(d + e);
            Console.WriteLine(a + d + e);
            Console.WriteLine(d + e + a);
            */
        }
    }
}
