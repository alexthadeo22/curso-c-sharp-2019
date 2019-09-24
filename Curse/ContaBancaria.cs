using System;
using System.Globalization;
using System.Text;

namespace Curse
{
    class ContaBancaria
    {
        public int Conta { get; set; }
        public string Titular  { get; set; }
        public double Valor { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int conta, string titular, double valor)
        {
            Conta = conta;
            Titular = titular ?? throw new ArgumentNullException(nameof(titular));
            Valor = valor;
            Saldo = Valor;
        }

        public double Deposito(double valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public double Saque(double valor)
        {
            Saldo -= (valor + 5.00);
            return Saldo;
        }

        public override string ToString()
        {
            return "Conta "+Conta+", Titular: "+Titular+", Saldo: $ "+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
