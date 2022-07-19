

namespace HerancaMultiplaProbDiamente.Device
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        //declaração do método processDoc
        public abstract void ProcessDoc(string document);

    }
}
