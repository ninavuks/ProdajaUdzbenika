namespace Klijent.UserControls
{
    partial class UCOsnovnaSkola
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNaziv = new Label(); txtNaziv = new TextBox();
            lblEmail = new Label(); txtEmail = new TextBox();
            btnSacuvaj = new Button(); btnIzmeni = new Button();
            btnObrisi = new Button(); btnPretrazi = new Button();
            dgvSkole = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSkole).BeginInit();
            SuspendLayout();

            lblNaziv.Location = new Point(20, 20); lblNaziv.Size = new Size(80, 23); lblNaziv.Text = "Naziv:";
            txtNaziv.Location = new Point(110, 17); txtNaziv.Size = new Size(200, 23);

            lblEmail.Location = new Point(20, 55); lblEmail.Size = new Size(80, 23); lblEmail.Text = "Email:";
            txtEmail.Location = new Point(110, 52); txtEmail.Size = new Size(200, 23);

            btnSacuvaj.Location = new Point(340, 17); btnSacuvaj.Size = new Size(110, 30); btnSacuvaj.Text = "Sačuvaj (novi)";
            btnIzmeni.Location = new Point(340, 52); btnIzmeni.Size = new Size(110, 30); btnIzmeni.Text = "Izmeni izabrani";
            btnObrisi.Location = new Point(340, 87); btnObrisi.Size = new Size(110, 30); btnObrisi.Text = "Obriši izabrani";
            btnPretrazi.Location = new Point(340, 122); btnPretrazi.Size = new Size(110, 30); btnPretrazi.Text = "Pretraži / Osveži";

            dgvSkole.Location = new Point(20, 165); dgvSkole.Size = new Size(560, 250);
            dgvSkole.AllowUserToAddRows = false; dgvSkole.ReadOnly = true;
            dgvSkole.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvSkole.MultiSelect = false;
            dgvSkole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(lblNaziv); Controls.Add(txtNaziv);
            Controls.Add(lblEmail); Controls.Add(txtEmail);
            Controls.Add(btnSacuvaj); Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi); Controls.Add(btnPretrazi);
            Controls.Add(dgvSkole);

            Name = "UCOsnovnaSkola"; Size = new Size(600, 430);
            ((System.ComponentModel.ISupportInitialize)dgvSkole).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private Label lblNaziv; private TextBox txtNaziv;
        private Label lblEmail; private TextBox txtEmail;
        private Button btnSacuvaj; private Button btnIzmeni; private Button btnObrisi; private Button btnPretrazi;
        private DataGridView dgvSkole;
    }
}