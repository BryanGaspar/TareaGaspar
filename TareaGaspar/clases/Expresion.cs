using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluar
{
    class Expresion
    {
        public static double calcularExpresion(int i, int n)
        {
            double aux = 0;
            double tot = 0;
            while (i <= n)
            {
                aux += ((Math.Pow(2, i + 1)) - (Math.Pow(2, i))) / (i + 1);
                i++;
            }
            tot = tot + aux;


            return tot;
        }
    }
}
