namespace FileStream_e_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\File, FileInfo e IOException\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {               
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na leitura!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) sr.Close();                
            }
        }
    }
}
