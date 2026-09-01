namespace Klijent.UserControls
{
    partial class UCProdavac
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIme = new Label(); txtIme = new TextBox();
            lblPrezime = new Label(); txtPrezime = new TextBox();
            lblKorisnickoIme = new Label(); txtKorisnickoIme = new TextBox();
            lblSifra = new Label(); txtSifra = new TextBox();
            btnSacuvaj = new Button(); btnIzmeni = new Button();
            btnObrisi = new Button(); btnPretrazi = new Button();
            dgvProdavci = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdavci).BeginInit();
            SuspendLayout();

            lblIme.Location = new Point(20, 20); lblIme.Size = new Size(90, 23); lblIme.Text = "Ime:";
            txtIme.Location = new Point(120, 17); txtIme.Size = new Size(190, 23);

            lblPrezime.Location = new Point(20, 55); lblPrezime.Size = new Size(90, 23); lblPrezime.Text = "Prezime:";
            txtPrezime.Location = new Point(120, 52); txtPrezime.Size = new Size(190, 23);

            lblKorisnickoIme.Location = new Point(20, 90); lblKorisnickoIme.Size = new Size(90, 23); lblKorisnickoIme.Text = "Korisničko ime:";
            txtKorisnickoIme.Location = new Point(120, 87); txtKorisnickoIme.Size = new Size(190, 23);

            lblSifra.Location = new Point(20, 125); lblSifra.Size = new Size(90, 23); lblSifra.Text = "Šifra:";
            txtSifra.Location = new Point(120, 122); txtSifra.Size = new Size(190, 23);
            txtSifra.UseSystemPasswordChar = true;

            btnSacuvaj.Location = new Point(330, 17); btnSacuvaj.Size = new Size(110, 30); btnSacuvaj.Text = "Sačuvaj (novi)";
            btnIzmeni.Location = new Point(330, 52); btnIzmeni.Size = new Size(110, 30); btnIzmeni.Text = "Izmeni izabrani";
            btnObrisi.Location = new Point(330, 87); btnObrisi.Size = new Size(110, 30); btnObrisi.Text = "Obriši izabrani";
            btnPretrazi.Location = new Point(330, 122); btnPretrazi.Size = new Size(110, 30); btnPretrazi.Text = "Pretraži / Osveži";

            dgvProdavci.Location = new Point(20, 165); dgvProdavci.Size = new Size(560, 250);
            dgvProdavci.AllowUserToAddRows = false; dgvProdavci.ReadOnly = true;
            dgvProdavci.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvProdavci.MultiSelect = false;
            dgvProdavci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(lblIme); Controls.Add(txtIme);
            Controls.Add(lblPrezime); Controls.Add(txtPrezime);
            Controls.Add(lblKorisnickoIme); Controls.Add(txtKorisnickoIme);
            Controls.Add(lblSifra); Controls.Add(txtSifra);
            Controls.Add(btnSacuvaj); Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi); Controls.Add(btnPretrazi);
            Controls.Add(dgvProdavci);

            Name = "UCProdavac"; Size = new Size(600, 430);
            ((System.ComponentModel.ISupportInitialize)dgvProdavci).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private Label lblIme; private TextBox txtIme;
        private Label lblPrezime; private TextBox txtPrezime;
        private Label lblKorisnickoIme; private TextBox txtKorisnickoIme;
        private Label lblSifra; private TextBox txtSifra;
        private Button btnSacuvaj; private Button btnIzmeni; private Button btnObrisi; private Button btnPretrazi;
        private DataGridView dgvProdavci;
    }
}