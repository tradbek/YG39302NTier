using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTire.Dto;
using Ba.CustomControls;

namespace NTire.UI.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(FormValidator.IsValid(pnlOgrenciBilgi))
            {
                Ogrenci ogr = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    No = txtOgrenciNo.Text,
                    Sinif = txtSinif.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                };
                lbxOgrenciler.Items.Add(ogr);
            }
          

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}
