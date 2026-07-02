namespace Exercicio_Contrato.Entities
{
    internal class Departament
    {
        public string Name { get; set; }

        //constructor void
        public Departament ()
        {

        //constructor default
        }
        public Departament (string name)
        {
            Name = name;
        }
    }
}
