using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto1.ClasesCalculadora
{
    class ClasePorcentaje
    {
        public double Porcentuar(double v1, double v2)
        {
            double P;
            P = (v1 * v2) / 100;          
            return P;
        }
    }
}
