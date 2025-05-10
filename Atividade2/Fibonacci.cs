using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public static class Fibonacci
    {
        public static bool PertenceFibonacci(int numero)
        {
            if (numero < 0)
                return false;

            int a = 0, b = 1;

            while (b < numero)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return numero == a || numero == b;
        }
    }
}
