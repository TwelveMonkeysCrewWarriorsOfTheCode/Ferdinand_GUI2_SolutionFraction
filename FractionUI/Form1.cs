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
            FirstElementsToSave(elementsToSave, TBArithmeticFraction1.Text);
            Fraction f1 = BuildFraction1(TBArithmeticFraction1.Text);
            //MessageBox.Show(f1);
            Fraction f2 = BuildFraction2(TBArithmeticFraction2.Text);
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
            bool result = Fraction.EltsToSave(elementsToSave);
            //MessageBox.Show($"Eléments sauvés: {result}");
            RTBSave.Text += $"{elementsToSave[0]},{elementsToSave[1]},{elementsToSave[2]},{elementsToSave[3]}" +
                $",{elementsToSave[4]},{elementsToSave[5]}\n"; 
            #endregion
        }       

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            #region Comparing operations
            List<string> comparingElementsToSave = new List<string>();
            FirstElementsToSave(comparingElementsToSave, TBCompFraction1.Text);
            Fraction f1 = BuildFraction1(TBCompFraction1.Text);
            Fraction f2 = BuildFraction2(TBCompFraction2.Text);
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
            bool result = Fraction.EltsToSave(comparingElementsToSave);
            RTBSave.Text += $"{comparingElementsToSave[0]},{comparingElementsToSave[1]}," +
                $"{comparingElementsToSave[2]},{comparingElementsToSave[3]},{comparingElementsToSave[4]}\n"; 
            #endregion
        }

        #region Methods
        private void FirstElementsToSave(List<string> pElementsToSave, string pFraction1)
        {
            pElementsToSave.Add(DateTime.Now.ToShortDateString());
            pElementsToSave.Add(DateTime.Now.ToShortTimeString());
            pElementsToSave.Add(pFraction1);
        }
        private void CompleteListEltsComparing(List<string> pComparingElementsToSave, string pCompSign)
        {
            pComparingElementsToSave.Add(pCompSign);
            pComparingElementsToSave.Add(TBCompFraction2.Text);
        }

        private void CompleteList(List<string> elementsToSave)
        {
            elementsToSave.Add(CBSelectOperation.Text);
            elementsToSave.Add(TBArithmeticFraction2.Text);
            elementsToSave.Add(TBArithmeticResult.Text);
        }
        private Fraction BuildFraction1(string pFraction1)
        {
            if (pFraction1 == string.Empty) throw new ArgumentNullException("Le champ est vide");
            List<string> numDeno = new List<string>(pFraction1.Split("/"));
            int numerator = int.Parse(numDeno[0]);
            int denominator = int.Parse(numDeno[1]);
            //MessageBox.Show($"{numerator} , {denominator}");
            return new Fraction(numerator, denominator);
        }

        private Fraction BuildFraction2(string pFraction2)
        {
            if (pFraction2 == string.Empty) throw new ArgumentNullException("Le champ est vide");
            List<string> numDeno = new List<string>(pFraction2.Split("/"));
            int numerator = int.Parse(numDeno[0]);
            int denominator = int.Parse(numDeno[1]);
            return new Fraction(numerator, denominator);
        } 
        #endregion
    }
}
