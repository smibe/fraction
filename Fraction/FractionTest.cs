using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTraining
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void AddTwoNulls()
        {
            Assert.AreEqual(F(0), F(0) + F(0));
        }

        [TestMethod]
        public void AddTwoIntegers()
        {
            Assert.AreEqual(F(4), F(1) + F(3));
        }

        [TestMethod]
        public void AddTwoFractionsWithEqualDenominator ()
        {
            Assert.AreEqual(F(4, 5), F(1, 5) + F(3, 5));
        }

        [TestMethod]
        public void ReduceFractions()
        {
            Assert.AreEqual(F(4, 5), F(4 * 2, 5 * 2));
        }

        public Fraction F(int nominator, int denominator = 0)
        {
            return new Fraction(nominator, denominator);
        }
    }
}
