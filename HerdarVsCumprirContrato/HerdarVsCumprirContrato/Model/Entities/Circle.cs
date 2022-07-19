using System;
using System.Globalization;

namespace HerdarVsCumprirContrato.Model.Entities
{
    internal class Circle : AbstractShape //herda de abstractshape, ou seja, tem o color da classe abstractshape
    {
        public double Radius { get; set; }//atributo

        public override double Area()//método(contrato) área, herdado da classe abstractshape
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                +", area = "
                +Area().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
