using System;
using System.Collections.Generic;


namespace Lista_Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia lista
            List<string> list = new List<string>();

            list.Add("Rafael");
            list.Add("Jadson");
            list.Add("Alisson");// Add adiciona sempre ao final da lista
            list.Add("Elton");
            list.Insert(0, "Jackson");// insere valor na lista definindo uma posição especifica

            //repetição de objetos nesse caso repete os membros da lista 1 a 1
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //conta a quantidade de itens na lista
            Console.WriteLine("Quantidade da lista: " +list.Count);
            //visualiza o primeiro da lista na condição a baixo
            string top = list.Find(x => x[0] == 'J');
            Console.WriteLine("Primeio nome com A: " +top);
            //visualiza o ultimo da lista na condição a baixo
            string bottom = list.FindLast(x => x[0] == 'J');
            Console.WriteLine("Ultimo com a Letra J: " + bottom);
            //mostra a primeira posição a aparecer
            int index = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("Primeira posição: " + index);
            //mostra a ultima posição a aparecer
            int lastIndex = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("Ultima posição: " + lastIndex);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("===================================");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //remove elemento da lista
            list.Remove("Alisson");
            Console.WriteLine("===================================");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //remove todos dentro do parametro passado
            list.RemoveAll(x => x[0] == 'J');
            Console.WriteLine("===================================");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove posição especifica
            list.RemoveAt(0);
            Console.WriteLine("===================================");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove a partir de uma posição da lista um numero especificado  de obj
            list.RemoveRange(0, 5);
            Console.WriteLine("===================================");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
