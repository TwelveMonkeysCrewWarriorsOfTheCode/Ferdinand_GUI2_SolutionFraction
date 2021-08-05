using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFractionDAL
{
    public class FractionDAL
    {
        #region Constants
        private const string FILENAMEARITH = "ArithmeticOperationscsvfile.csv";
        private const string FILENAMECOMP = "ComparingOperationscsvfile.csv";
        private const string HEADOFFILE = "Date,Heure,Fraction1,Opération,Fraction2"; 
        #endregion

        public static bool SaveToCSVFile(List<string> pElements)
        {
            try
            {
                #region Save arithmetic elements
                if (pElements.Count > 5)
                {
                    if (!File.Exists(@$".\{FILENAMEARITH}"))
                    {
                        File.AppendAllText(@$".\{FILENAMEARITH}", HEADOFFILE + ",Résultat\n");
                    }
                    StringBuilder elementsToSave = new StringBuilder();
                    foreach (var element in pElements)
                    {
                        elementsToSave.Append($"{element},");
                    }
                    int positionLastCharOfString = elementsToSave.Length - 1;
                    string lineToSave = elementsToSave.ToString().Remove(positionLastCharOfString);
                    File.AppendAllText(@$".\{FILENAMEARITH}", lineToSave + "\n");
                    return true;
                } 
                #endregion

                #region Save comparing elements
                if (!File.Exists(@$".\{FILENAMECOMP}"))
                {
                    File.AppendAllText(@$".\{FILENAMECOMP}", HEADOFFILE + "\n");
                }
                StringBuilder elementsCompToSave = new StringBuilder();
                foreach (var element in pElements)
                {
                    elementsCompToSave.Append($"{element},");
                }
                int positionCompLastCharOfString = elementsCompToSave.Length - 1;
                string myLineToSave = elementsCompToSave.ToString().Remove(positionCompLastCharOfString);
                File.AppendAllText(@$".\{FILENAMECOMP}", myLineToSave + "\n");
                return true; 
                #endregion
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
