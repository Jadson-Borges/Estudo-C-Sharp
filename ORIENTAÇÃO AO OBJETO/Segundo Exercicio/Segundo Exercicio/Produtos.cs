using System;
using System.Globalization;

namespace Segundo_Exercicio
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RMProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + " - Valor de Estoque: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade do estoque atual: "+ Quantidade + " Unidades, "
                + " Valor unitário: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        
    }
}
