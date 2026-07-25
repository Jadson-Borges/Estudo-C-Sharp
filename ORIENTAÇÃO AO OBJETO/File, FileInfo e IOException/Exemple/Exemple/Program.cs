namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file1.txt";
            string targetPath = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file2.txt";

            try
            {
                //Função FileInfo
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //função File
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
