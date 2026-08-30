namespace Klijent.UserControls
{
    partial class UCUdzbenik
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblIzdavac = new Label();
            txtIzdavac = new TextBox();
            lblCena = new Label();
            txtCena = new TextBox();
            lblRazred = new Label();
            numRazred = new NumericUpDown();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnPretrazi = new Button();
            dgvUdzbenici = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numRazred).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUdzbenici).BeginInit();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.Location = new Point(20, 20);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(80, 23);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(110, 17);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 27);
            txtNaziv.TabIndex = 1;
            // 
            // lblIzdavac
            // 
            lblIzdavac.Location = new Point(20, 55);
            lblIzdavac.Name = "lblIzdavac";
            lblIzdavac.Size = new Size(80, 23);
            lblIzdavac.TabIndex = 2;
            lblIzdavac.Text = "Izdavač:";
            // 
            // txtIzdavac
            // 
            txtIzdavac.Location = new Point(110, 52);
            txtIzdavac.Name = "txtIzdavac";
            txtIzdavac.Size = new Size(200, 27);
            txtIzdavac.TabIndex = 3;
            // 
            // lblCena
            // 
            lblCena.Location = new Point(20, 90);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(80, 23);
            lblCena.TabIndex = 4;
            lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            txtCena.Location = new Point(110, 87);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(100, 27);
            txtCena.TabIndex = 5;
            // 
            // lblRazred
            // 
            lblRazred.Location = new Point(20, 125);
            lblRazred.Name = "lblRazred";
            lblRazred.Size = new Size(80, 23);
            lblRazred.TabIndex = 6;
            lblRazred.Text = "Razred:";
            // 
            // numRazred
            // 
            numRazred.Location = new Point(110, 122);
            numRazred.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numRazred.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRazred.Name = "numRazred";
            numRazred.Size = new Size(60, 27);
            numRazred.TabIndex = 7;
            numRazred.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(340, 17);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(110, 30);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj (novi)";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(340, 52);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(110, 30);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni izabrani";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(340, 87);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(110, 30);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obriši izabrani";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(340, 122);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(110, 30);
            btnPretrazi.TabIndex = 11;
            btnPretrazi.Text = "Pretraži / Osveži";
            // 
            // dgvUdzbenici
            // 
            dgvUdzbenici.AllowUserToAddRows = false;
            dgvUdzbenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUdzbenici.BackgroundColor = Color.SteelBlue;
            dgvUdzbenici.ColumnHeadersHeight = 29;
            dgvUdzbenici.Location = new Point(20, 165);
            dgvUdzbenici.MultiSelect = false;
            dgvUdzbenici.Name = "dgvUdzbenici";
            dgvUdzbenici.ReadOnly = true;
            dgvUdzbenici.RowHeadersWidth = 51;
            dgvUdzbenici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUdzbenici.Size = new Size(560, 250);
            dgvUdzbenici.TabIndex = 12;
            // 
            // UCUdzbenik
            // 
            BackColor = Color.LightSteelBlue;
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblIzdavac);
            Controls.Add(txtIzdavac);
            Controls.Add(lblCena);
            Controls.Add(txtCena);
            Controls.Add(lblRazred);
            Controls.Add(numRazred);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvUdzbenici);
            Name = "UCUdzbenik";
            Size = new Size(600, 430);
            ((System.ComponentModel.ISupportInitialize)numRazred).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUdzbenici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaziv;
        private TextBox txtNaziv;
        private Label lblIzdavac;
        private TextBox txtIzdavac;
        private Label lblCena;
        private TextBox txtCena;
        private Label lblRazred;
        private NumericUpDown numRazred;
        private Button btnSacuvaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnPretrazi;
        private DataGridView dgvUdzbenici;
    }
}