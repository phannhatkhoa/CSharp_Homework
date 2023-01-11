using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction frac)
        {
            int numerator = Numerator * frac.Denominator + frac.Numerator * Denominator;
            int denominator = Denominator * frac.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Subtract(Fraction frac)
        {
            int numerator = Numerator * frac.Denominator - frac.Numerator * Denominator;
            int denominator = Denominator * frac.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Multiply(Fraction frac)
        {
            int numerator = Numerator * frac.Numerator;
            int denominator = Denominator * frac.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Divide(Fraction frac)
        {
            int numerator = Numerator * frac.Denominator;
            int denominator = Denominator * frac.Numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"({Numerator}/{Denominator})";
        }

        public double ToDecimal()
        {
            return (double)Numerator / Denominator;
        }
    }
}
