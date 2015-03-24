using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ba.CustomControls
{
    public class ValidatedTextBox : TextBox
    {
        ErrorProvider provider;
        public ValidatedTextBox()
        {
            provider = new ErrorProvider();
        }

        #region Properties

        private bool _yalnizcaSayi;
        private bool _bosGecilemez;

        public bool BosGecilemez
        {
            get
            {
                return _bosGecilemez;
            }
            set
            {
                _bosGecilemez = value;
                if (!_bosGecilemez)
                {
                    YalnızcaSayi = false;
                }
            }
        }
        public bool YalnızcaSayi
        {
            get
            {
                return _yalnizcaSayi;
            }
            set
            {
                _yalnizcaSayi = value;
                if (_yalnizcaSayi)
                {
                    BosGecilemez = true;
                }
            }
        }
        #endregion

        public bool DegerlerUygunMu()
        {
            //HACK: String.IsNullOrWhiteSpace() ve muhadillerini araştırıp
            // aradaki farkları öğrenerek en uygun olanı kullan.
            if (BosGecilemez && base.Text == "")
            {
                provider.SetError(this, "Bu alan boş geçilemez");
                return false;
            }    
            if (YalnızcaSayi)
            {
                //HACK try catch i kaldırıp int.TryParse kullanmayı dene.                
                try
                {
                    int geciciDeger = Convert.ToInt32(base.Text);
                  
                }
                catch
                {
                    provider.SetError(this, "Yalnızca sayı girebilirsin.");
                    return false;
                }
            }
            provider.Clear();
            return true;
        }

    }
}
