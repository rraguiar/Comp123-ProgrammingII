using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassDemo
{
    class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"<{Real}, {Imaginary}>";
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == lhs.Imaginary;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real != rhs.Real || lhs.Imaginary != lhs.Imaginary;
        }
        public static Complex operator + (Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator - (Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator *(Complex lhs, Complex rhs)//<ac-bd, ad+bc>
        {
            int real = lhs.Real * rhs.Real;
            int imaginary = lhs.Imaginary * rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int real = lhs.Real / rhs.Real;
            int imaginary = lhs.Imaginary / rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex arg)
        {
            int real = -arg.Real;
            int imaginary = -arg.Imaginary;
            return new Complex(real, imaginary);
        }
    }
}
