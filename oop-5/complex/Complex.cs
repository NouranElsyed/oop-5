using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.complex
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };
        }
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0)
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = (c?.Imag ?? 0)
            };
        }

        public static bool operator >(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag > b.Imag;
            else
                return a.Real > b.Real;
        }
        public static bool operator <(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag < b.Imag;
            else
                return a.Real < b.Real;
        }

        public static explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }
        public static implicit operator string (Complex c)
            {return c?.ToString()?? string.Empty; }

    }
}
