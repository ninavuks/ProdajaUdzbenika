using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent
{
    public partial class LoginFrm : Form
    {
        internal Prodavac UlogovaniProdavac { get; private set; }

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                MessageBox.Show("Sva polja su obavezna.");
                return;
            }

            try
            {
                UlogovaniProdavac = Komunikacija.Instance.PrijaviProdavac(txtKorisnickoIme.Text, txtSifra.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
