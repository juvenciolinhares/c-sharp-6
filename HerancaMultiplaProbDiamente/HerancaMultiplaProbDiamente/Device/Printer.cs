using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultiplaProbDiamente.Device
{
    internal class Printer : Device, IPrinter //herda de device e implementa a interface IPrinter
    {
        //implementação de device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document); 
        }

        //implementação de IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
