namespace Klijent.UserControls
{
    partial class UCRacun
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvRacuni = new DataGridView();
            dgvStavkePregled = new DataGridView();
            lblDatumIzmena = new Label(); dtpIzmenaDatum = new DateTimePicker();
            lblProdavacIzmena = new Label(); cmbIzmenaProdavac = new ComboBox();
            btnIzmeniZaglavlje = new Button();
            lblNoviRacun = new Label();
            lblKupac = new Label(); cmbKupac = new ComboBox();
            lblDatumNovi = new Label(); dtpDatum = new DateTimePicker();
            lblUdzbenikNovi = new Label(); cmbUdzbenik = new ComboBox();
            lblKolicinaNovi = new Label(); numKolicina = new NumericUpDown();
            btnDodajStavku = new Button();
            dgvNoveStavke = new DataGridView();
            btnUkloniStavku = new Button();
            lblUkupno = new Label();
            btnSacuvajRacun = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkePregled).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoveStavke).BeginInit();
            SuspendLayout();

            // --- Pregled postojećih računa ---
            dgvRacuni.Location = new Point(20, 20); dgvRacuni.Size = new Size(720, 140);
            dgvRacuni.AllowUserToAddRows = false; dgvRacuni.ReadOnly = true;
            dgvRacuni.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvRacuni.MultiSelect = false;
            dgvRacuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStavkePregled.Location = new Point(20, 170); dgvStavkePregled.Size = new Size(720, 110);
            dgvStavkePregled.AllowUserToAddRows = false; dgvStavkePregled.ReadOnly = true;
            dgvStavkePregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvStavkePregled.MultiSelect = false;
            dgvStavkePregled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblDatumIzmena.Location = new Point(20, 295); lblDatumIzmena.Size = new Size(60, 23); lblDatumIzmena.Text = "Datum:";
            dtpIzmenaDatum.Location = new Point(85, 292); dtpIzmenaDatum.Size = new Size(140, 23); dtpIzmenaDatum.Format = DateTimePickerFormat.Short;

            lblProdavacIzmena.Location = new Point(240, 295); lblProdavacIzmena.Size = new Size(70, 23); lblProdavacIzmena.Text = "Prodavac:";
            cmbIzmenaProdavac.Location = new Point(315, 292); cmbIzmenaProdavac.Size = new Size(220, 23);
            cmbIzmenaProdavac.DropDownStyle = ComboBoxStyle.DropDownList;

            btnIzmeniZaglavlje.Location = new Point(555, 290); btnIzmeniZaglavlje.Size = new Size(185, 30);
            btnIzmeniZaglavlje.Text = "Izmeni datum/prodavca";

            
            lblNoviRacun.Location = new Point(20, 335); lblNoviRacun.Size = new Size(200, 25);
            lblNoviRacun.Text = "Novi račun";
            lblNoviRacun.Font = new Font(Font, FontStyle.Bold);

            // --- Sastavljanje novog računa ---
            lblKupac.Location = new Point(20, 370); lblKupac.Size = new Size(60, 23); lblKupac.Text = "Kupac:";
            cmbKupac.Location = new Point(85, 367); cmbKupac.Size = new Size(220, 23);
            cmbKupac.DropDownStyle = ComboBoxStyle.DropDownList;

            lblDatumNovi.Location = new Point(330, 370); lblDatumNovi.Size = new Size(60, 23); lblDatumNovi.Text = "Datum:";
            dtpDatum.Location = new Point(395, 367); dtpDatum.Size = new Size(140, 23); dtpDatum.Format = DateTimePickerFormat.Short;

            lblUdzbenikNovi.Location = new Point(20, 405); lblUdzbenikNovi.Size = new Size(75, 23); lblUdzbenikNovi.Text = "Udžbenik:";
            cmbUdzbenik.Location = new Point(100, 402); cmbUdzbenik.Size = new Size(240, 23);
            cmbUdzbenik.DropDownStyle = ComboBoxStyle.DropDownList;

            lblKolicinaNovi.Location = new Point(355, 405); lblKolicinaNovi.Size = new Size(65, 23); lblKolicinaNovi.Text = "Količina:";
            numKolicina.Location = new Point(425, 402); numKolicina.Size = new Size(60, 23);
            numKolicina.Minimum = 1; numKolicina.Maximum = 1000; numKolicina.Value = 1;

            btnDodajStavku.Location = new Point(500, 400); btnDodajStavku.Size = new Size(120, 28);
            btnDodajStavku.Text = "Dodaj stavku";

            dgvNoveStavke.Location = new Point(20, 440); dgvNoveStavke.Size = new Size(520, 160);
            dgvNoveStavke.AllowUserToAddRows = false; dgvNoveStavke.ReadOnly = true;
            dgvNoveStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvNoveStavke.MultiSelect = false;
            dgvNoveStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnUkloniStavku.Location = new Point(555, 440); btnUkloniStavku.Size = new Size(185, 30);
            btnUkloniStavku.Text = "Ukloni izabranu stavku";

            lblUkupno.Location = new Point(20, 610); lblUkupno.Size = new Size(220, 25);
            lblUkupno.Text = "Ukupno: 0.00";
            lblUkupno.Font = new Font(Font, FontStyle.Bold);

            btnSacuvajRacun.Location = new Point(555, 605); btnSacuvajRacun.Size = new Size(185, 35);
            btnSacuvajRacun.Text = "Sačuvaj račun";

            Controls.Add(dgvRacuni); Controls.Add(dgvStavkePregled);
            Controls.Add(lblDatumIzmena); Controls.Add(dtpIzmenaDatum);
            Controls.Add(lblProdavacIzmena); Controls.Add(cmbIzmenaProdavac);
            Controls.Add(btnIzmeniZaglavlje);
            Controls.Add(lblNoviRacun);
            Controls.Add(lblKupac); Controls.Add(cmbKupac);
            Controls.Add(lblDatumNovi); Controls.Add(dtpDatum);
            Controls.Add(lblUdzbenikNovi); Controls.Add(cmbUdzbenik);
            Controls.Add(lblKolicinaNovi); Controls.Add(numKolicina);
            Controls.Add(btnDodajStavku);
            Controls.Add(dgvNoveStavke); Controls.Add(btnUkloniStavku);
            Controls.Add(lblUkupno); Controls.Add(btnSacuvajRacun);

            AutoScroll = true;
            Name = "UCRacun";
            Size = new Size(780, 670);

            ((System.ComponentModel.ISupportInitialize)dgvRacuni).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavkePregled).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoveStavke).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvRacuni;
        private DataGridView dgvStavkePregled;
        private Label lblDatumIzmena; private DateTimePicker dtpIzmenaDatum;
        private Label lblProdavacIzmena; private ComboBox cmbIzmenaProdavac;
        private Button btnIzmeniZaglavlje;
        private Label lblNoviRacun;
        private Label lblKupac; private ComboBox cmbKupac;
        private Label lblDatumNovi; private DateTimePicker dtpDatum;
        private Label lblUdzbenikNovi; private ComboBox cmbUdzbenik;
        private Label lblKolicinaNovi; private NumericUpDown numKolicina;
        private Button btnDodajStavku;
        private DataGridView dgvNoveStavke;
        private Button btnUkloniStavku;
        private Label lblUkupno;
        private Button btnSacuvajRacun;
    }
}