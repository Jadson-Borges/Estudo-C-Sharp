namespace Stream_Writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcPath = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file1.txt";
            string targetPath = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcPath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
