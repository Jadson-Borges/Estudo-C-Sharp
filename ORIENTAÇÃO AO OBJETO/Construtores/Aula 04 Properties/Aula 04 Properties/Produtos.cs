using System;
using System.Globalization;

namespace Aula_04_Properties
{
    internal class Produtos
    {
        
        private string _nome;
        private double _valor;
        private int _quantidade;

        public Produtos() { }

        public Produtos (string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && _nome.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Valor {
            get { return _valor; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEstoque {
            get
            {
                return _valor * _quantidade;
            }
        }

        public void AdicionarProd (int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProd (int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                +"unidades, Total: $ "
                + ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
