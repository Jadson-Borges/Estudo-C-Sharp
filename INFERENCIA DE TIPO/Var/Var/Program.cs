using System;


namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var é inferencia de tipo ou seja ele identifica o tipo da variavel pelo valor informado,
            //pode se dizer que é uma variavel dinamica pois não se refere a um tipo especifico
            var n = 10;
            var nome = "jadson";
            var quebrado = 10.3;

            //sempre da preferencia ao tipo de dados para evitar erros por exemplo int w = x;
            var w = quebrado;

            Console.WriteLine(n);
            Console.WriteLine(nome);
            Console.WriteLine(quebrado);
        }
    }
}
