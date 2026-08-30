using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCUdzbenik : UserControl
    {
        public UCUdzbenik()
        {
            InitializeComponent();
        }

        public Label LblNaziv => lblNaziv;
        public TextBox TxtNaziv => txtNaziv;
        public TextBox TxtIzdavac => txtIzdavac;
        public TextBox TxtCena => txtCena;
        public NumericUpDown NumRazred => numRazred;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnIzmeni => btnIzmeni;
        public Button BtnObrisi => btnObrisi;
        public Button BtnPretrazi => btnPretrazi;
        public DataGridView DgvUdzbenici => dgvUdzbenici;
    }
}