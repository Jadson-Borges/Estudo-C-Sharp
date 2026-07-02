namespace Soma
{
    internal class Calculadora
    {  
        public static int Soma (params int[] valores)
        {
            int soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma;
        }
        //SOBRECARGA PARA TER DE EXEMPLO DE COMO NÃO FAZER 
        //public static decimal Soma (decimal n1, decimal n2)
        //{
        //    return n1 + n2;
        //}
        //public static decimal Soma (decimal n1, decimal n2, decimal n3)
        //{
        //    return n1 + n2 + n3;
        //}
        //public static decimal Soma (decimal n1, decimal n2, decimal n3, decimal n4)
        //{
        //    return n1 + n2 + n3 + n4;
        //}
    }
}
