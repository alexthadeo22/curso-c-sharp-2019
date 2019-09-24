using System;
using System.Globalization;

namespace Curse
{
    class Produto
    {

        private string _nome;
        public double Preco { get; set ; }
        public int QtdEstoque { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int qtdEstoque)
        {
            _nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }    

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            QtdEstoque = 5;
        }



        public double ValorTotalEstoque()
        {
            return Preco * QtdEstoque;
        }

        public void AdicionaProduto(int quantidade)
        {
            QtdEstoque += quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            QtdEstoque -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + QtdEstoque + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

     
    }
}
