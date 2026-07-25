

namespace Problema_Diamante.Devices
{
    internal class Scanner : Dispositivo, IScanner
    {
        public override void DocumentoProcessado(string documento)
        {
            Console.WriteLine("Processando Scanner: " + documento);
        }

        public string Scan()
        {
            return "Sanner scan resultado";
        }
    }
}
