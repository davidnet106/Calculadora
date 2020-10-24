using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto1.ClasesCalculadora
{
    class ClaseFactorial
    {
        public double Factorial(double v1)
        {
            if (v1 == 0 || v1 == 1)
            {
                return 1;
            }
            else
            {
                return v1 * Factorial(v1 - 1);
            }
        }
    }
}
