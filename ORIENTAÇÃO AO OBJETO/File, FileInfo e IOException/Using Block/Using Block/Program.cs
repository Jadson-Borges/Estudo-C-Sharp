namespace Using_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
