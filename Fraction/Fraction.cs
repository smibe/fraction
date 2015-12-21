using System;

namespace TddTraining
{
    public class Fraction
    {
        public Fraction (int nominator, int denominator = 1)
        {
            Nominator = nominator;
            Denominator = denominator;

            Reduce();
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

        private void Reduce()
        {
            for (int divisor = 2; divisor < Math.Max(Nominator, Denominator); divisor++)
            {
                if (Nominator % divisor == 0 && Denominator % divisor == 0)
                {
                    Nominator /= divisor;
                    Denominator /= divisor;
                }
            }
        }

    }
}