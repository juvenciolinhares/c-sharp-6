using System;
using System.Collections.Generic;
using System.Text;
using HerdarVsCumprirContrato.Enums;

namespace HerdarVsCumprirContrato.Model.Entities
{
    //subtipo da interface IShape
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();//reproduziu o método da classe IShape
    }
}
