namespace Directory_and_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Estudo C#\Estudo-C-Sharp\ORIENTAÇÃO AO OBJETO\Directory e DirectoryInfo\Test";

            try
            {
                //informar pastas do caminho declarado
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                //informar arquivos do caminho declarado
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\Pasta_nova");
            }

            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
