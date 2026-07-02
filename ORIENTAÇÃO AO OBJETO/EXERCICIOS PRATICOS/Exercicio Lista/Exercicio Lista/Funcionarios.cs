using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Lista
{
    internal class Funcionarios
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        

        public Funcionarios (string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public void AumentoSalario (decimal aumento)
        {
            Salario += Salario * aumento / 100;
        }

        public override string ToString()
        {
            return  "Funcionario: "
                    + Nome
                    + ", "
                    + "salario: "
                    + Salario;
        }
    }
}
