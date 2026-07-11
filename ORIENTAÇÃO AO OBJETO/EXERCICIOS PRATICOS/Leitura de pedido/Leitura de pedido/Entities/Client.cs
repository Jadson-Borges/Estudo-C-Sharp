namespace Leitura_de_pedido.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
<<<<<<< HEAD
=======

        public override string ToString()
        {
            return Name
                + " ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
    }
}
