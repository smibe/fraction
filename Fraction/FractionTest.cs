using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            return new Fraction(0);
        }

        public override string ToString()
        {
            return "";
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

    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void AddTwoNulls()
        {
            Assert.AreEqual(F(0), F(0) + F(0));
        }

        public Fraction F(int nominator)
        {
            return new Fraction(nominator);
        }
    }
}
