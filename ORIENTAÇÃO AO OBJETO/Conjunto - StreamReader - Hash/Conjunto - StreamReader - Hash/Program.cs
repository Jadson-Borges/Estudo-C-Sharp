using Conjunto___StreamReader___Hash.Entities;
using System.IO;
namespace Conjunto___StreamReader___Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<RegisterLog> set = new HashSet<RegisterLog>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new RegisterLog { UserName = name, Instant = instant });
                        
                    }

                    Console.WriteLine("Total user: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
