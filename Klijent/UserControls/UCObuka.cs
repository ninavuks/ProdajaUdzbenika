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
    public partial class UCObuka : UserControl
    {
        public UCObuka() { InitializeComponent(); }

        public TextBox TxtNaziv => txtNaziv;
        public TextBox TxtMesto => txtMesto;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnIzmeni => btnIzmeni;
        public Button BtnObrisi => btnObrisi;
        public Button BtnPretrazi => btnPretrazi;
        public DataGridView DgvObuke => dgvObuke;
    }
}