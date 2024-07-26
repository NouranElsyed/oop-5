using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal CalcArea();
        public abstract decimal Perimeter { get; }

    }
    abstract class recbase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Rectangl : recbase
    {
        public override decimal Perimeter { get { return (Dim01 + Dim02) * 2; } }


    }
    class square : recbase
    {
        public square(decimal Dim) { Dim01 = Dim02 = Dim; }
        public override decimal Perimeter { get { return 4 * Dim01; } }


    }
    class Circle : Shape
    {
        public Circle(decimal Reduis)
        {
            Dim01 = Dim02 = Reduis;
        }
        public override decimal Perimeter { get { return (2 * 3.14M * Dim01); } }

        public override decimal CalcArea() {    return Dim01*Dim01*3.14M; }
     }
}
