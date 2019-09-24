using System;
using System.Collections.Generic;
using System.Text;

namespace Curse
{
    class ConversorDeMoeda
    {
        public static double CoverterMoeda( double cotacao, double quantia)
        {
            double valorTotal = quantia * cotacao;

            return valorTotal += valorTotal * 0.06;
        }



    }
}
