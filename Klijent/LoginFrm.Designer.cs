namespace Klijent
{
    partial class LoginFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblKorisnickoIme = new Label();
            txtKorisnickoIme = new TextBox();
            lblSifra = new Label();
            txtSifra = new TextBox();
            btnPrijava = new Button();
            SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.Location = new Point(30, 30);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new Size(110, 23);
            lblKorisnickoIme.TabIndex = 0;
            lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(181, 30);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(180, 27);
            txtKorisnickoIme.TabIndex = 1;
            // 
            // lblSifra
            // 
            lblSifra.Location = new Point(30, 89);
            lblSifra.Name = "lblSifra";
            lblSifra.Size = new Size(110, 23);
            lblSifra.TabIndex = 2;
            lblSifra.Text = "Šifra:";
            // 
            // txtSifra
            // 
            txtSifra.Location = new Point(181, 86);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(180, 27);
            txtSifra.TabIndex = 3;
            txtSifra.UseSystemPasswordChar = true;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(127, 143);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(129, 37);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijavi se";
            btnPrijava.Click += btnPrijava_Click;
            // 
            // LoginFrm
            // 
            AcceptButton = btnPrijava;
            ClientSize = new Size(383, 215);
            Controls.Add(lblKorisnickoIme);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(lblSifra);
            Controls.Add(txtSifra);
            Controls.Add(btnPrijava);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblKorisnickoIme;
        private TextBox txtKorisnickoIme;
        private Label lblSifra;
        private TextBox txtSifra;
        private Button btnPrijava;
    }
}