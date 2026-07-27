using System.Threading.Channels;


namespace Dictionary_votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> voting = new Dictionary<string, int>();

            Console.WriteLine("Entre com o diretorio do arquivo: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int vote = int.Parse(line[1]);
                        if (voting.ContainsKey(candidate))
                        {
                            voting[candidate] += vote;
                        }
                        else
                        {
                            voting.Add(candidate, vote);
                        }
                    }

                    Console.WriteLine("Total de votos:");

                    foreach (KeyValuePair<string, int> item in voting)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
