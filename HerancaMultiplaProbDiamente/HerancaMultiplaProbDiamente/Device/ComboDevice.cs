using System;


namespace HerancaMultiplaProbDiamente.Device
{

    internal class ComboDevice : Device, IScanner, IPrinter
    {
        //implemento de device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        //implementação de IScanner
        public string Scan()
        {
            return "ComboDevice scan Result";
        }

        //implementação de IPrinter
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

    }
}
