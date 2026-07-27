namespace Dictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> cookies = new Dictionary<string, string> ();

            cookies["user"] = "test";
            cookies["email"] = "teste@gmail.com";
            cookies["phone"] = "88888800";
            cookies["phone"] = "88888800";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove ("email");

            if (cookies.ContainsKey ("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("este email não existe");
            }

            Console.WriteLine("Size: " + cookies.Count);

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
