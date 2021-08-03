using System;

namespace FractionBLL
{
    public class Fraction
    {
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

        public Fraction(int pNumber) => InitializeFraction(pNumber, 1);

        public Fraction(Fraction pFraction) => InitializeFraction(pFraction.m_Numerator, pFraction.m_Denominator);
        public Fraction(int pNumerator, int pDenominator)
        {
            if (pDenominator == 0) throw new DivideByZeroException("Le diviseur ne peut pas être égal à zéro.");
            InitializeFraction(pNumerator, pDenominator);
        }

        public static Fraction operator +(Fraction pFraction1, Fraction pFraction2)
        {
            int num = NumeratorLeftOperation(pFraction1, pFraction2) + NumeratorRightOperation(pFraction1, pFraction2);

            return new Fraction(num, CalculateDeno(pFraction1, pFraction2));
        }

        public static Fraction operator -(Fraction pFraction1, Fraction pFraction2)
        {
            int num = NumeratorLeftOperation(pFraction1, pFraction2) - NumeratorRightOperation(pFraction1, pFraction2);
            return new Fraction(num, CalculateDeno(pFraction1, pFraction2));
        }        

        public static Fraction operator *(Fraction pFraction1, Fraction pFraction2)
        {
            int num = pFraction1.m_Numerator * pFraction2.m_Numerator;
            return new Fraction(num, CalculateDeno(pFraction1, pFraction2));
        }

        public static Fraction operator /(Fraction pFraction1, Fraction pFraction2)
        {
            int num = pFraction1.m_Numerator * pFraction2.m_Denominator;
            int deno = pFraction1.m_Denominator * pFraction2.m_Numerator;

            return new Fraction(num, deno);
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
            int myDCD = GCD(this.m_Numerator, this.m_Denominator);
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
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Fraction)) return false;
            Fraction fraction = obj as Fraction;
            if (fraction == null)
            {
                return false;
            }
            return this.m_Numerator == fraction.m_Numerator && this.m_Denominator == fraction.m_Denominator;
        }

        public override int GetHashCode() => this.m_Numerator.GetHashCode() ^ this.m_Denominator.GetHashCode();

        // Substitution de ToString() afin de retourner la valeur d'une fraction comme une chaine
        public override string ToString() => m_Numerator.ToString() + "/" + m_Denominator.ToString();

    }
}
