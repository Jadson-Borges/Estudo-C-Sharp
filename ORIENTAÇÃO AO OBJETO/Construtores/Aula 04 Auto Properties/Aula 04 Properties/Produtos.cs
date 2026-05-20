using System;
using System.Globalization;

namespace Aula_04_AUto_Properties
{
    internal class Produtos
    {
        
        private string _nome; // não vai ser feito Auto Properties pois possui logica particular
        public double Valor { get; private set; } // Auto Properties
        public int Quantidade { get; private set; }// Auto Properties

        public Produtos() { }

        public Produtos (string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        //logica particular da propriedade Nome
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

        public double ValorTotalEstoque {
            get
            {
                return Valor * Quantidade;
            }
        }

        public void AdicionarProd (int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProd (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                +"unidades, Total: $ "
                + ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
