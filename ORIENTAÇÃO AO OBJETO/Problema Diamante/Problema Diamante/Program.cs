using Problema_Diamante.Devices;

namespace Problema_Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imprimir impri = new Imprimir() { NumeroSerial = 1080};
            impri.DocumentoProcessado("Minha carta");
            impri.Imprimindo("Minha carta");

            Scanner sca = new Scanner() { NumeroSerial = 1081};
            sca.DocumentoProcessado("meu email");
            Console.WriteLine(sca.Scan());

            ComboDispositivo comb = new ComboDispositivo() { NumeroSerial = 1082};
            comb.DocumentoProcessado("Minha carta");
            comb.Imprimindo("Minha carta");
            comb.DocumentoProcessado("meu email");
            Console.WriteLine(comb.Scan());
        }
    }
}
