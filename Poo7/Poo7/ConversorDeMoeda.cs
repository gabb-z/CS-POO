using System;

namespace Poo7
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quant, double cot)
        {
            double total = quant * cot;
            return total + (total * Iof) / 100;
        }
    }
}
