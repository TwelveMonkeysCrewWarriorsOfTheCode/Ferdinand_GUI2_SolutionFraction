using FractionBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBSelectOperation.SelectedIndex = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            #region Arithmetic operations
            List<string> elementsToSave = new List<string>();
            FirstElementsToSave(elementsToSave, NormalizedFraction(TBArithmeticFraction1.Text));
            Fraction f1 = BuildFraction1(NormalizedFraction(TBArithmeticFraction1.Text));
            //MessageBox.Show(f1);
            Fraction f2 = BuildFraction2(NormalizedFraction(TBArithmeticFraction2.Text));
            switch (CBSelectOperation.SelectedIndex)
            {
                case 0:
                    TBArithmeticResult.Text = f1 + f2;
                    CompleteList(elementsToSave);
                    break;
                case 1:
                    TBArithmeticResult.Text = f1 - f2;
                    CompleteList(elementsToSave);
                    break;
                case 2:
                    TBArithmeticResult.Text = f1 * f2;
                    CompleteList(elementsToSave);
                    break;
                case 3:
                    TBArithmeticResult.Text = f1 / f2;
                    CompleteList(elementsToSave);
                    break;
            }
            //MessageBox.Show(elementsToSave.Count.ToString());            
            //MessageBox.Show($"Eléments sauvés: {result}");
            SavingHistoric(elementsToSave, SendDataToBLL(elementsToSave)); 
            #endregion
        }       

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            #region Comparing operations
            List<string> comparingElementsToSave = new List<string>();
            FirstElementsToSave(comparingElementsToSave, NormalizedFraction(TBCompFraction1.Text));
            Fraction f1 = BuildFraction1(NormalizedFraction(TBCompFraction1.Text));
            Fraction f2 = BuildFraction2(NormalizedFraction(TBCompFraction2.Text));
            if (f1 > f2)
            {
                TBCompResult.Text = $"{f1} est plus grand que {f2}";
                CompleteListEltsComparing(comparingElementsToSave, ">");
            }
            else if (f1 < f2)
            {
                TBCompResult.Text = $"{f1} est plus petit que {f2}";
                CompleteListEltsComparing(comparingElementsToSave, "<");
            }
            else
            {
                TBCompResult.Text = $"{f1} est égal à {f2}";
                CompleteListEltsComparing(comparingElementsToSave, "=");
            }
            SavingHistoric(comparingElementsToSave, SendDataToBLL(comparingElementsToSave));
            #endregion
        }

        #region Methods
        private bool SendDataToBLL(List<string> pElementsToSave)
        {
            return Fraction.EltsToSave(pElementsToSave);
        }
        private void SavingHistoric(List<string> pElementsToSave, bool pResult)
        {
            if (pResult)
            {
                StringBuilder savingHistoric = new StringBuilder();
                foreach (var element in pElementsToSave)
                {
                    savingHistoric.Append($"{element},");
                }
                int lastPosition = savingHistoric.Length - 1;
                RTBSave.Text += savingHistoric.ToString().Remove(lastPosition) + "\n";
            }
        }
        private void FirstElementsToSave(List<string> pElementsToSave, string pFraction1)
        {
            pElementsToSave.Add(DateTime.Now.ToShortDateString());
            pElementsToSave.Add(DateTime.Now.ToShortTimeString());
            pElementsToSave.Add(pFraction1);
        }
        private void CompleteListEltsComparing(List<string> pComparingElementsToSave, string pCompSign)
        {
            pComparingElementsToSave.Add(pCompSign);
            pComparingElementsToSave.Add(NormalizedFraction(TBCompFraction2.Text));
        }

        private void CompleteList(List<string> elementsToSave)
        {
            elementsToSave.Add(CBSelectOperation.Text);
            elementsToSave.Add(NormalizedFraction(TBArithmeticFraction2.Text));
            elementsToSave.Add(TBArithmeticResult.Text);
        }
        private Fraction BuildFraction1(string pFraction1)
        {
            string fraction1 = NormalizedFraction(pFraction1);

            if (fraction1 == string.Empty) throw new ArgumentNullException("Le champ est vide");
            List<string> numDeno = new List<string>(fraction1.Split("/"));
            int numerator = int.Parse(numDeno[0]);
            int denominator = int.Parse(numDeno[1]);
            //MessageBox.Show($"{numerator} , {denominator}");
            return new Fraction(numerator, denominator);
        }

        private string NormalizedFraction(string pFraction1)
        {
            string fractionToNormalize = pFraction1.Normalize(NormalizationForm.FormD);
            StringBuilder inputFraction = new StringBuilder();
            for (int i = 0; i < fractionToNormalize.Length; i++)
            {
                if (fractionToNormalize[i] >= '0' && fractionToNormalize[i] <= '9' || fractionToNormalize[i] == '-' || fractionToNormalize[i] == '/')
                {
                    inputFraction.Append(fractionToNormalize[i]);
                }
            }
            return inputFraction.ToString();
        }

        private Fraction BuildFraction2(string pFraction2)
        {
            string fraction2 = NormalizedFraction(pFraction2);
            if (fraction2 == string.Empty) throw new ArgumentNullException("Le champ est vide");
            List<string> numDeno = new List<string>(fraction2.Split("/"));
            int numerator = int.Parse(numDeno[0]);
            int denominator = int.Parse(numDeno[1]);
            return new Fraction(numerator, denominator);
        } 
        #endregion
    }
}
