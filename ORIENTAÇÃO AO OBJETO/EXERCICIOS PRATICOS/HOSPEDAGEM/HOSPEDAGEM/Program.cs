using System;

namespace Hospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospede[] vetor = new Hospede[10]; 

            Console.WriteLine("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel: {i}");
                Console.WriteLine("Nome: ");
                string nomeHospede = Console.ReadLine();
                Console.WriteLine("Email: ");
                string emailHospede = Console.ReadLine();

                Console.WriteLine("Quarto: ");
                int quartoCliente = int.Parse(Console.ReadLine());
                
                if (quartoCliente < 0 || quartoCliente >= vetor.Length)
                {
                    Console.WriteLine("Quarto inválido");
                }
                else if (vetor[quartoCliente] != null)
                {
                    Console.WriteLine("Este quarto está oculpado!");
                }
                else
                {                   
                    vetor[quartoCliente] = new Hospede(nomeHospede, emailHospede);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Quartos alugados: ");

            for (int i = 0;i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{i}: {vetor[i]}");
                }

            }
        }
    }
}
