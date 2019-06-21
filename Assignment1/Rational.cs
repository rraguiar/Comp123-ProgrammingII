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
    class Rational
    {
        #region Properties
        public int Denominator { get; private set; } //getter is public and setter is private
        public int Numerator { get; private set; } //getter is public and setter is private
        #endregion


        #region Constructor&ToString
        public Rational(int numerator = 0, int denominator = 1) //Constructor
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString() //ToString method
        {
            return $"{Numerator}/{Denominator}";
        }
        #endregion

        #region CalculateFractions
        public void IncreaseBy(Rational other) //sum of the fractions
        {
            Normalize(other);
            Numerator = (Numerator * other.Denominator) + (Denominator * other.Numerator);
            Denominator *= other.Denominator;
        }
        public void DecreaseBy(Rational other) //subtraction of the fractions
        {
            Normalize(other);
            Numerator = (Numerator * other.Denominator) - (Denominator * other.Numerator);
            Denominator *= other.Denominator;
        }
        #endregion
        #region Normalization 
        /* This class is to ensure that when numerator is equal 0, 
         * than denominator can´t be different than 1 or the calculation 
         * result will be different (not wrong, but different). 
         * Testing it with 0/3 makes a different (not wrong, but different)
         * result on both the addition and subtraction.
         */
        private void Normalize(Rational fraction) //private, for internal class use only
        {
            if (Numerator == 0)
            {
                Denominator = 1;
            }
            if (fraction.Numerator == 0)
            {
                fraction.Denominator = 1;
            }
        }
    }
    #endregion
    /* - Henry code - GCD
    class Rational
    {
        #region Properties
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }
        #endregion
        
        #region public methods
        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public void IncreaseBy(Rational other)
        {
            Rational temp = this.AddOrSubtract(other, true);
            int gcd = Rational.FindGCD(temp.Numerator, temp.Denominator);
            this.Numerator = temp.Numerator / gcd;
            this.Denominator = temp.Denominator / gcd;
        }

        public void DecreaseBy(Rational other)
        {
            Rational temp = this.AddOrSubtract(other, false);
            int gcd = Rational.FindGCD(temp.Numerator, temp.Denominator);
            this.Numerator = temp.Numerator / gcd;
            this.Denominator = temp.Denominator / gcd;
        }
        #endregion
        #region Private methods
        Rational AddOrSubtract(Rational other, bool isAdded)
        {
            int newNumerator = 0;
            if (isAdded == true)
            {
                newNumerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            }
            else
            {
                newNumerator = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
            }
            int newDenominator = this.Denominator * other.Denominator;
            return new Rational(newNumerator, newDenominator);
        }

        static int FindGCD(int number01, int number02)
        {
            number01 = Math.Abs(number01);
            number02 = Math.Abs(number02);
            while (number01 != 0 && number02 != 0)
            {
                if (number01 > number02)
                {
                    number01 %= number02;
                }
                else
                {
                    number02 %= number01;
                }
            }
            return (number01 == 0) ? number02 : number01;
        }
        #endregion
        */
}
