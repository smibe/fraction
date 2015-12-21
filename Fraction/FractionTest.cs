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

        public Fraction F(int nominator)
        {
            return new Fraction(nominator);
        }
    }
}
