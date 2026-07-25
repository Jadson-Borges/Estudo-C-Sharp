using System.Globalization;

namespace path_atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\EXERCICIOS PRATICOS\path atividade\newFolder\sourceFile.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                string sourceFolder = Path.GetDirectoryName(path);
                string outFolder = Path.Combine(sourceFolder, "out");
                Directory.CreateDirectory(outFolder);

                string targetPath = Path.Combine(outFolder, "summary.csv");

                using (StreamWriter sw = File.CreateText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        double total = price * quantity;

                        sw.WriteLine($"{name},{total.ToString("F2", CultureInfo.InvariantCulture)}");
                        
                    }
                }

                Console.WriteLine("Arquivo criado com sucesso!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
