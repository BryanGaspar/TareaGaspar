using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Utilidades
    {

        public static long factorial(int num)
        {
            long fac = 1;
            if (num == 0)
                return 1;
            for(int i = 1; i <= num; i++)
            {
                fac *= i;
               
            }
                return fac;

        }
        public static long sumfactorial( int num)
        {
           
            long aux = 0 , sum = 0;
           
            for (int i = 1; i <= num; i++)
            {
                aux = factorial(i);
                sum += aux;
                
            }
            return sum;
        }
    }
}
