using System;
using System.Collections.Generic;
using ProjetFractionDAL;

namespace FractionBLL
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        #region Properties
        private int m_Numerator;
        private int m_Denominator;

        public int Numerator
        {
            get { return m_Numerator; }
            set { m_Numerator = value; }
        }
        public int Denominator
        {
            get { return m_Denominator; }
            set { m_Denominator = value; }
        }
        #endregion

        #region Constructors
        public Fraction(int pNumber) => InitializeFraction(pNumber, 1);

        public Fraction(Fraction pFraction) => InitializeFraction(pFraction.m_Numerator, pFraction.m_Denominator);
        public Fraction(int pNumerator, int pDenominator)
        {
            if (pDenominator == 0) throw new DivideByZeroException("Le diviseur ne peut pas être égal à zéro.");
            InitializeFraction(pNumerator, pDenominator);
        }
        #endregion

        #region Overloading arithmetic operators
        public static Fraction operator +(Fraction pFraction1, Fraction pFraction2)
        {
            return new Fraction(NumeratorLeftOperation(pFraction1, pFraction2) +
                NumeratorRightOperation(pFraction1, pFraction2), CalculateDeno(pFraction1, pFraction2));
        }

        public static Fraction operator -(Fraction pFraction1, Fraction pFraction2)
        {
            return new Fraction(NumeratorLeftOperation(pFraction1, pFraction2) -
                NumeratorRightOperation(pFraction1, pFraction2), CalculateDeno(pFraction1, pFraction2));
        }

        public static Fraction operator *(Fraction pFraction1, Fraction pFraction2) =>
            new Fraction(pFraction1.m_Numerator * pFraction2.m_Numerator, CalculateDeno(pFraction1, pFraction2));

        public static Fraction operator /(Fraction pFraction1, Fraction pFraction2) =>
            new Fraction(pFraction1.m_Numerator * pFraction2.m_Denominator, pFraction1.m_Denominator * pFraction2.m_Numerator);
        #endregion

        #region Comparison logic
        public static bool operator <(Fraction left, Fraction right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }
        public static bool operator >(Fraction left, Fraction right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator ==(Fraction left, Fraction right)
        {
            return EqualityComparer<Fraction>.Default.Equals(left, right);
        }       

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }
        #endregion

        #region Conversion logic
        public static implicit operator string(Fraction pFraction)
        {
            return pFraction.ToString();
        }

        public static explicit operator decimal(Fraction pFraction)
        {
            if (pFraction.m_Denominator == 1)
                return (decimal)(double)pFraction.m_Numerator;

            return (decimal)((double)pFraction.m_Numerator / (double)pFraction.m_Denominator);
        }

        public static explicit operator Fraction(decimal pdecimal)
        {
            string myDecimal = pdecimal.ToString();
            int numberOfTen;
            int numerator = int.Parse(myDecimal.Split(",")[0]);
            int denominator = int.Parse(myDecimal.Split(",")[1]);
            int decimalLength = myDecimal.Split(",")[1].Length;
            if (numerator == 0)
            {
                numerator = 1;
                numberOfTen = CalculateNumberOfTen(decimalLength);                
                numerator *= denominator;
                denominator = numberOfTen;
                return new Fraction(numerator, denominator);
            }
            else
            {
                numberOfTen = CalculateNumberOfTen(decimalLength);
                Fraction fractionRightPart = new Fraction(denominator, numberOfTen);
                Fraction fractionLeftPart = new Fraction(numerator);
                return fractionLeftPart + fractionRightPart;
            }


        }
        #endregion

        #region Methods
        private static int CalculateNumberOfTen(int decimalLength)
        {
            int numberOfTen;
            if (decimalLength > 1)
            {
                numberOfTen = 1;
                for (int i = 0; i < decimalLength; i++)
                {
                    numberOfTen *= 10;
                }
            }
            else
            {
                numberOfTen = 10;
            }

            return numberOfTen;
        }
        private static int NumeratorRightOperation(Fraction pFraction1, Fraction pFraction2) =>
           pFraction1.m_Denominator * pFraction2.m_Numerator;
        private static int NumeratorLeftOperation(Fraction pFraction1, Fraction pFraction2) =>
            pFraction1.m_Numerator * pFraction2.m_Denominator;
        private static int CalculateDeno(Fraction pFraction1, Fraction pFraction2) =>
            pFraction1.m_Denominator * pFraction2.m_Denominator;
        private void InitializeFraction(int pNum, int pDeno)
        {
            this.m_Numerator = pNum;
            this.m_Denominator = pDeno;
            SimplifyFraction();
        }

        private void SimplifyFraction()
        {
            if (this.m_Denominator < 0)
            {
                this.m_Numerator = -this.m_Numerator;
                this.m_Denominator = -this.m_Denominator;
            }
            int myDCD = Math.Abs(GCD(this.m_Numerator, this.m_Denominator));
            this.m_Numerator /= myDCD;
            this.m_Denominator /= myDCD;
        }
        private int GCD(int pN1, int pN2)
        {
            while (pN2 != 0)
            {
                int temp = pN2;
                pN2 = pN1 % pN2;
                pN1 = temp;
            }
            return pN1;
        }
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    if (obj.GetType() != typeof(Fraction)) return false;
        //    Fraction fraction = obj as Fraction;
        //    if (fraction == null)
        //    {
        //        return false;
        //    }
        //    return this.m_Numerator == fraction.m_Numerator && this.m_Denominator == fraction.m_Denominator;
        //}

        //public override int GetHashCode() => this.m_Numerator.GetHashCode() ^ this.m_Denominator.GetHashCode();

        // Substitution de ToString() afin de retourner la valeur d'une fraction comme une chaine
        public override string ToString() => this.m_Numerator.ToString() + "/" + this.m_Denominator.ToString();

        public override bool Equals(object obj) => Equals(obj as Fraction);

        public bool Equals(Fraction other) => other != null &&
                   m_Numerator == other.m_Numerator &&
                   m_Denominator == other.m_Denominator &&
                   Numerator == other.Numerator &&
                   Denominator == other.Denominator;

        public override int GetHashCode()
        {
            return HashCode.Combine(m_Numerator, m_Denominator, Numerator, Denominator);
        }
        private int CompareTo(Fraction right)
        {

            int leftScale = this.m_Numerator * right.m_Denominator;
            int rightScale = this.m_Denominator * right.m_Numerator;

            if (leftScale < rightScale)
                return -1;
            else if (leftScale > rightScale)
                return 1;
            else
                return 0;
        }
        int IComparable<Fraction>.CompareTo(Fraction other)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Transfering data method
        public static bool EltsToSave(List<string> pElements)
        {
            return FractionDAL.SaveToCSVFile(pElements);
        } 
        #endregion
    }
}
