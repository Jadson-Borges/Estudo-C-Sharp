
namespace Problema_Diamante.Devices
{
    abstract class Dispositivo
    {
        public int NumeroSerial { get; set; }

        public abstract void DocumentoProcessado(string documento);
    }
}
