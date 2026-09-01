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
    public partial class UCRacun : UserControl
    {
        public UCRacun() { InitializeComponent(); }

        public DataGridView DgvRacuni => dgvRacuni;
        public DataGridView DgvStavkePregled => dgvStavkePregled;
        public DateTimePicker DtpIzmenaDatum => dtpIzmenaDatum;
        public ComboBox CmbIzmenaProdavac => cmbIzmenaProdavac;
        public Button BtnIzmeniZaglavlje => btnIzmeniZaglavlje;

        public ComboBox CmbKupac => cmbKupac;
        public DateTimePicker DtpDatum => dtpDatum;
        public ComboBox CmbUdzbenik => cmbUdzbenik;
        public NumericUpDown NumKolicina => numKolicina;
        public Button BtnDodajStavku => btnDodajStavku;
        public DataGridView DgvNoveStavke => dgvNoveStavke;
        public Button BtnUkloniStavku => btnUkloniStavku;
        public Label LblUkupno => lblUkupno;
        public Button BtnSacuvajRacun => btnSacuvajRacun;
    }
}
