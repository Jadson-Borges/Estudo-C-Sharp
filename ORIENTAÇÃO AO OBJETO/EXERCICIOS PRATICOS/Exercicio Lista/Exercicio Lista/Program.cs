using System;
using System.Collections.Generic;

namespace Exercicio_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de funcionarios:");
            int n = int.Parse(Console.ReadLine());
            List<Funcionarios> lista = new List<Funcionarios>();

            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Posição #{i}");
                Console.WriteLine("Nome do funcionario(a)");
                string nome = Console.ReadLine();

                Console.WriteLine("Salario do funcionario(a)");
                decimal salario = decimal.Parse(Console.ReadLine());

                Funcionarios funcionario = new Funcionarios(nome, salario);

                lista.Add(funcionario);
            }

            Console.WriteLine("Funcionarios(as) cadastrados com sucesso!");
            
            foreach (Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Selecione pelo ID o usuario que deseja alterar o salario:");
            
            int id = int.Parse(Console.ReadLine());

            while (id <= 0 || id > lista.Count)
            {
                Console.WriteLine($"Id invalido! #{id}");
                Console.WriteLine("Insira um ID valido: ");                
                id = int.Parse(Console.ReadLine());
            }

        
            
            Console.WriteLine("Id Valido, prossiga!");
            Console.WriteLine();

            Console.WriteLine("Informe o percentual aumento: ");
            decimal aumento = decimal.Parse(Console.ReadLine());

            lista[id - 1].AumentoSalario(aumento);
            

            foreach(Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
