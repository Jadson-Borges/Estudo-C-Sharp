using Demo_String_Builder.Entities;
namespace Demo_String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment firstComment = new Comment("Seja bem vindo!");
            Comment secondComment = new Comment("Nossa que incrivél!");

            Post firstPost = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Estou visitando Fortaleza",
                "Espero ter otimas esperiencias na Cidade!",
                12);

            firstPost.AddComment( firstComment );
            firstPost.AddComment ( secondComment );

            Comment thirdComment = new Comment("Maravilha!");
            Comment fourthComment = new Comment("Que noticia maravilhosa de se receber");

            Post secondPost = new Post(
                DateTime.Parse("28/07/2018 15:45:00"),
                "Boa noite pessoal",
                "França ta na final da copa",
                5);

            secondPost.AddComment ( thirdComment );
            secondPost.AddComment ( fourthComment );

            Console.WriteLine(firstPost);
            Console.WriteLine(secondPost);
        }
    }
}
