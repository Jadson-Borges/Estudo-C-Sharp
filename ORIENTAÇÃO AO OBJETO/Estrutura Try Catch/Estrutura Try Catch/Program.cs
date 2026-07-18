namespace Estrutura_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de divizão por 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de Formato! " + e.Message);
            }
        }
    }
}
