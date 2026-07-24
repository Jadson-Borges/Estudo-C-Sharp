
namespace Interface_Icomparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string path = @"E:\ESTUDO C#\ORIENTAÇÃO AO OBJETO\Interface Icomparable\Files\in.txt";
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        List<string> list = new List<string>();
                        while (!sr.EndOfStream)
                        {
                            list.Add(sr.ReadLine());
                        }
                        list.Sort();
                        foreach (string str in list)
                        {
                            Console.WriteLine(str);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
            }
    }
    }
