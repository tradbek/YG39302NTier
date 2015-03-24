using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ba.CustomControls
{
    public static class FormValidator
    {
        /// <summary>
        /// Kontrolün içindeki validated textboxların uygun olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="whatsIn">Hangi controlün içindeki textboxlar gözükecek?</param>
        /// <returns>bool</returns>
        public static bool IsValid(Control whatsIn)
        {
            bool tumuUygunmu = true;
            foreach(var item in whatsIn.Controls)
            {
                if(item is ValidatedTextBox)
                {
                    ValidatedTextBox txt = item as ValidatedTextBox;
                   if(!txt.DegerlerUygunMu())
                   {
                       tumuUygunmu = false;
                   }
                }
            }
            return tumuUygunmu;
        }

    }
}
