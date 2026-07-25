
namespace Problema_Diamante.Devices
{
    internal class ComboDispositivo: Dispositivo, IScanner, IImpressora
    {
        public override void DocumentoProcessado(string documento)
        {
            Console.WriteLine("Combo de dispositivo Imprimir" +documento);
        }

        public void Imprimindo(string documento)
        {
            Console.WriteLine("Combo de dispositivo processando" + documento);
        }

        public string Scan()
        {
            return "Combo de dispositivo Scanner resultado";
        }
    }
}
