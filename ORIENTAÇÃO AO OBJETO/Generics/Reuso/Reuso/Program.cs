namespace Reuso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("Quantos valores serão? : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("Primeiro: " + printService.First());

        }
    }
}
