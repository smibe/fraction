namespace TddTraining
{
    public class Fraction
    {
        public Fraction (int nominator)
        {
            Nominator = nominator;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Nominator + second.Nominator);
        }

        public override string ToString()
        {
            return Nominator.ToString();
        }

        public int Nominator { get; set; }

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