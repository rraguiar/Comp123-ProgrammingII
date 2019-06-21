using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ******************************************************
 * COMP123 - Programming II - Assignment 1
 * 
 * Name: Rafael Aguiar
 * Student id: 301041266
 * Name: Tran Huy Hoang
 * Student id: 300979272
 * 
 * Professor: Narendra K Pershad
 * 
 * Date: May 22, 2019
 ********************************************************
 */
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the 4 fractions
            Rational fraction1 = new Rational();
            Rational fraction2 = new Rational(2);
            Rational fraction3 = new Rational(denominator:3,numerator:2);
            Rational fraction4 = new Rational(3, 4);

            //Sum of the fractions
            Console.WriteLine($"Performing the sum of {fraction1} and {fraction3}");
            Console.Write($"{fraction1} + {fraction3} = ");
            fraction1.IncreaseBy(fraction3);
            Console.WriteLine(fraction1);
            Console.WriteLine($"Performing the sum of {fraction3} and {fraction4}");
            Console.Write($"{fraction3} + {fraction4} = ");
            fraction3.IncreaseBy(fraction4);
            Console.WriteLine(fraction3);

            //loading back Fraction 1 and 3 to the original values
            fraction1 = new Rational();
            fraction2 = new Rational(numerator:2);
            fraction3 = new Rational(denominator:3);
            fraction4 = new Rational(3, 4);

            //Subtraction of the fractions
            Console.WriteLine($"Performing the subtraction of {fraction2} and {fraction3}");
            Console.Write($"{fraction2} - {fraction3} = ");
            fraction2.DecreaseBy(fraction3);
            Console.WriteLine(fraction2);
            Console.WriteLine($"Performing the subtraction of {fraction2} and {fraction4}");
            Console.Write($"{fraction2} - {fraction4} = ");
            fraction2.DecreaseBy(fraction4);
            Console.WriteLine(fraction2);
        }
    }
}
