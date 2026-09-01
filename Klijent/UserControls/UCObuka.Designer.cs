namespace Klijent.UserControls
{
    partial class UCObuka
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
            lblMesto = new Label(); txtMesto = new TextBox();
            btnSacuvaj = new Button(); btnIzmeni = new Button();
            btnObrisi = new Button(); btnPretrazi = new Button();
            dgvObuke = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObuke).BeginInit();
            SuspendLayout();

            lblNaziv.Location = new Point(20, 20); lblNaziv.Size = new Size(80, 23); lblNaziv.Text = "Naziv:";
            txtNaziv.Location = new Point(110, 17); txtNaziv.Size = new Size(200, 23);

            lblMesto.Location = new Point(20, 55); lblMesto.Size = new Size(80, 23); lblMesto.Text = "Mesto:";
            txtMesto.Location = new Point(110, 52); txtMesto.Size = new Size(200, 23);

            btnSacuvaj.Location = new Point(340, 17); btnSacuvaj.Size = new Size(110, 30); btnSacuvaj.Text = "Sačuvaj (novi)";
            btnIzmeni.Location = new Point(340, 52); btnIzmeni.Size = new Size(110, 30); btnIzmeni.Text = "Izmeni izabrani";
            btnObrisi.Location = new Point(340, 87); btnObrisi.Size = new Size(110, 30); btnObrisi.Text = "Obriši izabrani";
            btnPretrazi.Location = new Point(340, 122); btnPretrazi.Size = new Size(110, 30); btnPretrazi.Text = "Pretraži / Osveži";

            dgvObuke.Location = new Point(20, 165); dgvObuke.Size = new Size(560, 250);
            dgvObuke.AllowUserToAddRows = false; dgvObuke.ReadOnly = true;
            dgvObuke.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgvObuke.MultiSelect = false;
            dgvObuke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(lblNaziv); Controls.Add(txtNaziv);
            Controls.Add(lblMesto); Controls.Add(txtMesto);
            Controls.Add(btnSacuvaj); Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi); Controls.Add(btnPretrazi);
            Controls.Add(dgvObuke);

            Name = "UCObuka"; Size = new Size(600, 430);
            ((System.ComponentModel.ISupportInitialize)dgvObuke).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private Label lblNaziv; private TextBox txtNaziv;
        private Label lblMesto; private TextBox txtMesto;
        private Button btnSacuvaj; private Button btnIzmeni; private Button btnObrisi; private Button btnPretrazi;
        private DataGridView dgvObuke;
    }
}