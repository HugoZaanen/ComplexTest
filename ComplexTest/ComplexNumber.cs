using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTest
{
    public struct ComplexNumber
    {
        //read-only properties that get the real and imagiray components
        public double Real { get; }
        public double Imaginary { get; }

        //constructor
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        //return string representation of ComplexNumber
        public override string ToString() => $"({Real} {(Imaginary < 0 ? "-" : "+")} {Math.Abs(Imaginary)}i)";

        //overload the addition operator
        public static ComplexNumber operator+(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real,
                x.Imaginary + y.Imaginary);
        }

        //overload the substraction operator
        public static ComplexNumber operator-(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real,
                x.Imaginary - y.Imaginary);
        }

        //overload the multiplication operator
        public static ComplexNumber operator*(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real * y.Real - x.Imaginary * y.Imaginary,
                x.Real * y.Imaginary + y.Real * x.Imaginary);
        }
    }
}
