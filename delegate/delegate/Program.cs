using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        delegate void calc(int a, int b);
        public static void add(int a, int b)
        {
            Console.WriteLine("sum is " + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("sub is " + (a -b));
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine("mul is " + (a *b));
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 20;
            //add(a, b);

            calc calculator = add;
            calculator += sub;
            calculator += mul;
            calculator(a, b);
            Console.WriteLine("--------------------");
            calculator(2, 2);
            Console.WriteLine("--------------------");
            calculator -= sub;

            calculator(1, 1);
        }
    }
}
