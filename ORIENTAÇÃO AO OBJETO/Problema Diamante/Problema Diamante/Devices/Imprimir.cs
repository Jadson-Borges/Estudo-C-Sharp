
namespace Problema_Diamante.Devices
{
    internal class Imprimir : Dispositivo, IImpressora
    {
        public override void DocumentoProcessado(string documento)
        {
            Console.WriteLine("Processando Impressão: " + documento);
        }

        public void Imprimindo(string documento)
        {
            Console.WriteLine("Impreossora imprimindo: " + documento);
        }

    }
}
