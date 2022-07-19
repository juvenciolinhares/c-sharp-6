using System;
using HerdarVsCumprirContrato.Model.Entities;
using HerdarVsCumprirContrato.Enums;

namespace HerdarVsCumprirContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IShape circulo = new Circle() { Radius = 2.0, Color = Color.White };
            IShape retangulo = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(circulo);
            Console.WriteLine(retangulo);
        }

    }
}
