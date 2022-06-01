using System;

namespace LabNet2022.TP2
{
    public static class IntegerExtension
    {
        public static double dividir(this int numero, double divisor)
        {
            if (divisor == 0) { throw new DivideByZeroException(); }
            return numero / divisor;
        }
    }
}
