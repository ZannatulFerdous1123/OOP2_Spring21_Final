using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class BasicCasio : IBasicCalculator
    {
        public double division(int x, int y)
        {
            double division = x/y;
            Console.WriteLine("Devision of {0} and {1} is : {2}", x, y, division);
            return division;
        }

        public int mul(int x, int y)
        {
            int mul = x*y;
            Console.WriteLine("Multiplication of {0} and {1} is : {2}", x, y, mul);
            return mul;

        }

        public int sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("Substraction of {0} and {1} is : {2}", x, y, sub);
            return sub;

        }

        public int sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition of {0} and {1} is : {2}", x, y, sum);
            return sum;

        }
    }
}
