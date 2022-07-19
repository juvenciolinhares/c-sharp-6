using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultiplaProbDiamente.Device
{
    internal class Scanner : Device, IScanner //herda de device e implementa a interface scanner
    {
     
        //implementação de device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        //implementação de IScanner
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
