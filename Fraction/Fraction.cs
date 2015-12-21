using System;

namespace TddTraining
{
    public class Fraction
    {
        public Fraction (int nominator, int denominator = 1)
        {
            Nominator = nominator;
            Denominator = denominator;
        }

        public int Nominator { get; set; }
        public int Denominator { get; set; }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Nominator + second.Nominator, first.Denominator);
        }

        public override string ToString()
        {
            return Nominator + "/" + Denominator;
        }

        public override bool Equals(object obj)
        {
            var fraction = obj as Fraction;
            if (fraction == null)
            {
                return false;
            }
            return this.Nominator == fraction.Nominator; 
        }
    }
}