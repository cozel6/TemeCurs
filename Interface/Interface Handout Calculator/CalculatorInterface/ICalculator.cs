using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    public interface ICalculator
    {
        double Add();
        double Subtract();
        double Multiply();
        double Divide();
    }
}
