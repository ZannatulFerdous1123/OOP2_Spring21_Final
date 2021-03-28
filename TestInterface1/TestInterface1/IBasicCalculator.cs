using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    interface IBasicCalculator
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int mul(int x, int y);
        double division(int x, int y);
    }
}
