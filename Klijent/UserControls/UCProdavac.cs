using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCProdavac : UserControl
    {
        public UCProdavac() { InitializeComponent(); }

        public TextBox TxtIme => txtIme;
        public TextBox TxtPrezime => txtPrezime;
        public TextBox TxtKorisnickoIme => txtKorisnickoIme;
        public TextBox TxtSifra => txtSifra;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnIzmeni => btnIzmeni;
        public Button BtnObrisi => btnObrisi;
        public Button BtnPretrazi => btnPretrazi;
        public DataGridView DgvProdavci => dgvProdavci;
    }
}