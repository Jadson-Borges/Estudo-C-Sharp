using System;
using System.Globalization;


namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main (string[] args)
        {
            //VARIAVEIS INTEIRAS
            sbyte x = 100; //entrepoint
            byte n1 = 126;
            int n2 = 2147483647;// valor maximo permitido para o tipo int, se passar disso da overflow
            long n3 = 2147483648L;// quando estiver com uma variavel long tem que colocar o L no final do numero para o compilador entender que é um long

            //VARIAVEIS DO TIPO DE CASO
            bool completo = false;
            char genero = 'F';

            //VARIAVEIS DO TIPO REAL
            float n4 = 4.5f; // quando estiver com uma variavel float tem que colocar o f no final do numero para o compilador entender que é um float
            double n5 = 4.5; // o double é o tipo real mais preciso, por isso não precisa colocar o f no final do numero
            double saldo = 10.357456;
            //VARIAVEIS DO TIPO STRING OU TEXTO
            string nome = "Maria"; // o tipo string é usado para armazenar texto, e o texto tem que estar entre aspas duplas e a variavel é imutavel, ou seja, não pode ser alterada depois de criada

            //VARIAVEIS  GERENICA
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            //COMO SABER O MENOR E MAIOR VALOR QUE UMA VARIAVEL PODE RECEBER
            int n6 = int.MinValue; // o int.MinValue é o menor valor que uma variavel do tipo int pode receber
            int n7 = int.MaxValue; // o int.MaxValue é o maior valor que uma variavel do tipo int pode receber
            sbyte n8 = sbyte.MinValue; // o sbyte.MinValue é o menor valor que uma variavel do tipo sbyte pode receber
            sbyte n9 = sbyte.MaxValue; // o sbyte.MaxValue é o maior valor que uma variavel do tipo sbyte pode receber
            decimal n10 = decimal.MinValue; // o decimal.MinValue é o menor valor que uma variavel do tipo decimal pode receber
            decimal n11 = decimal.MaxValue;

            string cliente = "Maria";
            int idade = 32;
            double valor = 17.25471;


            n1++; // o operador de incremento (++) é usado para aumentar o valor de uma variavel em 1, nesse caso o n1 vai passar de 126 para 127, se passar disso da overflow e volta para o valor minimo do tipo byte que é 0
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(genero); 
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(saldo.ToString("F2")); //ToString("F2") é usado para formatar o numero com 2 casas decimais, nesse caso o saldo vai ser exibido como 10.36 o F é usado para indicar que o numero é do tipo float, e o 2 é usado para indicar o numero de casas decimais que queremos exibir, nesse caso 2 casas decimais. Se quisermos exibir 3 casas decimais, basta colocar F3, e assim por diante.
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture)); //cultureInfo.InvariantCulture é usado para formatar o numero com o ponto como separador decimal, independente da cultura do sistema, nesse caso o saldo vai ser exibido como 10.357, mesmo que a cultura do sistema use a vírgula como separador decimal.
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            //-------------------------------------------------------------------------------------------------------------------
            //placeholder é um recurso do C# que permite formatar strings de forma mais fácil e legível, usando chaves {} para indicar onde os valores devem ser inseridos, e os argumentos são passados depois da string, separados por vírgula. O primeiro argumento é o valor que deve ser inserido no lugar do {0}, o segundo argumento é o valor que deve ser inserido no lugar do {1}, e assim por diante. O placeholder também permite formatar os valores, usando os mesmos formatos de formatação que vimos anteriormente, como F2, F3, etc.
            Console.WriteLine("A {0} tem {1} anos de idade, e seu saldo é {2:F3}", cliente, idade, valor ); // o {0} é usado para indicar a posição do argumento que queremos exibir, nesse caso o cliente, o {1} é usado para indicar a posição do argumento que queremos exibir, nesse caso a idade, e o {2:F3} é usado para indicar a posição do argumento que queremos exibir, nesse caso o valor, e o F3 é usado para formatar o numero com 3 casas decimais. Se quisermos exibir 2 casas decimais, basta colocar F2, e assim por diante.


            //interpolação de string é um recurso do C# que permite formatar strings de forma mais fácil e legível, usando o símbolo $ antes da string, e as expressões são colocadas entre chaves {} dentro da string. A interpolação de string também permite formatar os valores, usando os mesmos formatos de formatação que vimos anteriormente, como F2, F3, etc.
            Console.WriteLine($"A {cliente} tem {idade} de idade e o saldo bancario de {valor:F3}");

            //concatenação de string é um recurso do C# que permite juntar strings usando o operador +, nesse caso estamos juntando a string "A " com a string cliente, depois juntando com a string " tem ", depois juntando com a string idade, depois juntando com a string " de idade e o saldo bancario de ", e por fim juntando com a string valor formatada com 3 casas decimais usando o F3.
            Console.WriteLine(nome + " tem " + idade + " anos de idade e " + valor.ToString("F4") + " de saldo bancario");

        }
    }
}

// overflow é quando um calculo estrapola o tipo da variavel