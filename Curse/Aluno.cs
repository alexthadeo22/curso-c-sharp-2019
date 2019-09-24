using System;
using System.Collections.Generic;
using System.Text;

namespace Curse
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double MediaNotas()
        {
            return Nota1+Nota2+Nota3;
        }

        public bool Aprovado()
        {
           if (MediaNotas() > 60.0)
            {
                return true;
            }
           else
            {
                return false;

            }
        }

        public double FaltaNota()
        {
            double falta = 0.0;
            if (MediaNotas() < 60.0)
            {
                falta = 60.0 - MediaNotas();
            }
            
            return falta;
        }


    }
}
