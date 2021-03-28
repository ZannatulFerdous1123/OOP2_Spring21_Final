using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCasio casio1 = new BasicCasio();
            ScientificCasio Scientific = new ScientificCasio();
            Console.WriteLine("BASIC CALCULATOR");
            casio1.sum(1,1);
            casio1.sub(5, 2);
            casio1.mul(5, 5);
            casio1.division(16, 4);

            Console.WriteLine("                      ");

            Console.WriteLine("SCIENTIFIC CALCULATOR");
            Scientific.sum(7, 8);
            Scientific.sub(8, 9);
            Scientific.mul(4, 4);
            Scientific.division(4, 4);
            Scientific.sin(3);
            Scientific.XtoY(3, 2);



        }
    }
}
