using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class ScientificCasio : BasicCasio, IScientificCalculator
    {
        public double sin(double angle)
        {
            double sin = Math.Sin(angle);

            Console.WriteLine("Sine of {0} is:  {1} ",angle, sin);
            return sin;
        }

        public double XtoY(double x, double y)
        {
            double Pow = Math.Pow(x,y);
            Console.WriteLine("power of {0}^{1} is : {2}", x, y, Pow);
            return Pow;
        }
    }
}
