using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    internal class Class_Factorial
    {
        int num;

        public void Pnum_Set(int valor)
        {
            num = valor;
        }
        int fac;

        public int Pfac_Get()
        {
            return fac;
        }

        public void factorial()
        {
            int i;
            fac = num;
            for( i = 1; i < num; i ++)
            { 
                fac = fac * i; 
            }
        }
    }
}
