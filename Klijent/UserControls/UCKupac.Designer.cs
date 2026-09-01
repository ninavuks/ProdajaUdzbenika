namespace Klijent.UserControls
{
    partial class UCKupac
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSkola = new Label();
            cmbOsnovnaSkola = new ComboBox();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnPretrazi = new Button();
            dgvKupci = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKupci).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.Location = new Point(20, 20);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(90, 23);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(120, 17);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(190, 27);
            txtIme.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.Location = new Point(20, 55);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(90, 23);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(120, 52);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(190, 27);
            txtPrezime.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblSkola
            // 
            lblSkola.Location = new Point(20, 125);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(90, 23);
            lblSkola.TabIndex = 6;
            lblSkola.Text = "Osnovna škola:";
            // 
            // cmbOsnovnaSkola
            // 
            cmbOsnovnaSkola.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOsnovnaSkola.Location = new Point(120, 122);
            cmbOsnovnaSkola.Name = "cmbOsnovnaSkola";
            cmbOsnovnaSkola.Size = new Size(190, 28);
            cmbOsnovnaSkola.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(330, 17);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(110, 30);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj (novi)";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(330, 52);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(110, 30);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni izabrani";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(330, 87);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(110, 30);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obriši izabrani";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(330, 122);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(110, 30);
            btnPretrazi.TabIndex = 11;
            btnPretrazi.Text = "Pretraži / Osveži";
            // 
            // dgvKupci
            // 
            dgvKupci.AllowUserToAddRows = false;
            dgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKupci.ColumnHeadersHeight = 29;
            dgvKupci.Location = new Point(20, 165);
            dgvKupci.MultiSelect = false;
            dgvKupci.Name = "dgvKupci";
            dgvKupci.ReadOnly = true;
            dgvKupci.RowHeadersWidth = 51;
            dgvKupci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKupci.Size = new Size(560, 250);
            dgvKupci.TabIndex = 12;
            // 
            // UCKupac
            // 
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblPrezime);
            Controls.Add(txtPrezime);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSkola);
            Controls.Add(cmbOsnovnaSkola);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvKupci);
            Name = "UCKupac";
            Size = new Size(600, 430);
            ((System.ComponentModel.ISupportInitialize)dgvKupci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblIme; private TextBox txtIme;
        private Label lblPrezime; private TextBox txtPrezime;
        private Label lblEmail; private TextBox txtEmail;
        private Label lblSkola; private ComboBox cmbOsnovnaSkola;
        private Button btnSacuvaj; private Button btnIzmeni; private Button btnObrisi; private Button btnPretrazi;
        private DataGridView dgvKupci;
    }
}