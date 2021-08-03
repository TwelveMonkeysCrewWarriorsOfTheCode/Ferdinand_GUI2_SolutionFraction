using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionBLL;

namespace UnitTestProjectFraction
{
    [TestClass]
    public class UnitTestFraction
    {
        [DataRow(2, -2, 4, -2, -3, 1, DisplayName = "Addition de (2/-2) et (4/-2)")]
        [DataRow(1, -2, 1, -2, -1, 1, DisplayName = "Addition de (1/-2) et (1/-2)")]
        [DataRow(2, 2, 4, 2, 3, 1, DisplayName = "Addition de (2/2) et (4/2)")]
        [DataRow(2, 5, 2, 4, 9, 10, DisplayName = "Addition de (2/5) et (2/4)")]
        [TestMethod]
        public void NormalFraction(int pNum1, int pDeno1, int pNum2, int pDeno2, int pExpectedNum, int pExpectedDeno)
        {                  
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction F1 = new Fraction(pNum1, pDeno1);
            Fraction F2 = new Fraction(pNum2, pDeno2);
            Fraction result = F1 + F2;

            Assert.AreEqual(ExpectedObject, result);            
        }

        [DataRow(0, 3, 3, 1, DisplayName = "Addition de 0 et 3 --> fraction nulle")]
        [DataRow(-1, 2, 1, 1, DisplayName = "Addition de -1 et 2")]
        [DataRow(2, 3, 5, 1, DisplayName = "Addition de 2 et 3")]
        [TestMethod]
        public void FractionWithoutDenominator(int pNumber1, int pNumber2, int pExpectedNum, int pExpectedDeno)
        {
            Fraction fract1 = new Fraction(pNumber1);
            Fraction fract2 = new Fraction(pNumber2);            
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction Result = fract1 + fract2;

            Assert.AreEqual(ExpectedObject, Result);
        }

        [DataRow(0, 1, 2, 1, 2, DisplayName = "Addition de 0 et 1/2")]
        [DataRow(2, 1, 2, 5, 2, DisplayName = "Addition de 2 et 1/2")]
        [DataRow(1, 3, 7, 10, 7, DisplayName = "Addition de 1 et 3/7")]
        [TestMethod]
        public void AddNumberWithFraction(int pNumber, int pNumerator, int pDenominator, int pExpectedNum, int pExpectedDeno)
        {
            Fraction fract1 = new Fraction(pNumber);
            Fraction fract2 = new Fraction(pNumerator, pDenominator);
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction Result = fract1 + fract2;

            Assert.AreEqual(ExpectedObject, Result);
        }

        [DataRow(1, 2, 1, 4, 1, 4, DisplayName = "Soustraire (1/2) et (1/4)")]
        [DataRow(2, 5, 3, 4, -7, 20, DisplayName = "Soustraire (2/5) et (3/4)")]
        [TestMethod]
        public void SubtractTwoFractions(int pNum1, int pDeno1, int pNum2, int pDeno2, int pExpectedNum, int pExpectedDeno)
        {
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction F1 = new Fraction(pNum1, pDeno1);
            Fraction F2 = new Fraction(pNum2, pDeno2);
            Fraction result = F1 - F2;

            Assert.AreEqual(ExpectedObject, result);
        }

        [DataRow(-1, 2, 3, 4, -3, 8, DisplayName = "Multiplier (-1/2) et (3/4)")]
        [DataRow(2, 5, 3, 4, 3, 10, DisplayName = "Multiplier (2/5) et (3/4)")]
        [TestMethod]
        public void MultiplyTwoFractions(int pNum1, int pDeno1, int pNum2, int pDeno2, int pExpectedNum, int pExpectedDeno)
        {
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction F1 = new Fraction(pNum1, pDeno1);
            Fraction F2 = new Fraction(pNum2, pDeno2);
            Fraction result = F1 * F2;

            Assert.AreEqual(ExpectedObject, result);
        }

        [DataRow(-2, 5, 3, 4, -8, 15, DisplayName = "Diviser (-2/5) et (3/4)")]
        [DataRow(2, 5, 3, 4, 8, 15, DisplayName = "Diviser (2/5) et (3/4)")]
        [TestMethod]
        public void DivideTowFractions(int pNum1, int pDeno1, int pNum2, int pDeno2, int pExpectedNum, int pExpectedDeno)
        {
            Fraction ExpectedObject = new Fraction(pExpectedNum, pExpectedDeno);
            Fraction F1 = new Fraction(pNum1, pDeno1);
            Fraction F2 = new Fraction(pNum2, pDeno2);
            Fraction result = F1 / F2;

            Assert.AreEqual(ExpectedObject, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideIntNumberByZero()
        {
            Fraction f = new Fraction(2, 0);
            //Assert.AreEqual(2, f.Numerator);
            //Assert.AreEqual(0, f.Denominator);
        }
        
    }
}
