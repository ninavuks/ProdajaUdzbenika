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
    public partial class UCOsnovnaSkola : UserControl
    {
        public UCOsnovnaSkola() { InitializeComponent(); }

        public TextBox TxtNaziv => txtNaziv;
        public TextBox TxtEmail => txtEmail;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnIzmeni => btnIzmeni;
        public Button BtnObrisi => btnObrisi;
        public Button BtnPretrazi => btnPretrazi;
        public DataGridView DgvSkole => dgvSkole;
    }
}
