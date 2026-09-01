namespace Klijent
{
    partial class FrmGlavna
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sifarniciToolStripMenuItem = new ToolStripMenuItem();
            udzbeniciToolStripMenuItem = new ToolStripMenuItem();
            osnovneSkoleToolStripMenuItem = new ToolStripMenuItem();
            obukeToolStripMenuItem = new ToolStripMenuItem();
            prodavciToolStripMenuItem = new ToolStripMenuItem();
            kupciToolStripMenuItem = new ToolStripMenuItem();
            racuniToolStripMenuItem = new ToolStripMenuItem();

            pnlGlavni = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
             
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sifarniciToolStripMenuItem, prodavciToolStripMenuItem, kupciToolStripMenuItem, racuniToolStripMenuItem }); 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 1;
             
            sifarniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            udzbeniciToolStripMenuItem, osnovneSkoleToolStripMenuItem, obukeToolStripMenuItem});
            osnovneSkoleToolStripMenuItem.Text = "Osnovne škole";
            obukeToolStripMenuItem.Text = "Obuke";
            sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            sifarniciToolStripMenuItem.Size = new Size(76, 24);
            sifarniciToolStripMenuItem.Text = "Šifarnici";
             
            udzbeniciToolStripMenuItem.Name = "udzbeniciToolStripMenuItem";
            udzbeniciToolStripMenuItem.Size = new Size(158, 26);
            udzbeniciToolStripMenuItem.Text = "Udžbenici";
             
            prodavciToolStripMenuItem.Name = "prodavciToolStripMenuItem";      
            prodavciToolStripMenuItem.Size = new Size(90, 24);                 
            prodavciToolStripMenuItem.Text = "Prodavci";

            kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            kupciToolStripMenuItem.Size = new Size(90, 24);
            kupciToolStripMenuItem.Text = "Kupci";

            racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            racuniToolStripMenuItem.Size = new Size(90, 24);
            racuniToolStripMenuItem.Text = "Racuni";
            
            // pnlGlavni
             
            pnlGlavni.BackColor = Color.LightSteelBlue;
            pnlGlavni.Dock = DockStyle.Fill;
            pnlGlavni.Location = new Point(0, 28);
            pnlGlavni.Name = "pnlGlavni";
            pnlGlavni.Size = new Size(900, 622);
            pnlGlavni.TabIndex = 0;
            
            // FrmGlavna
             
            ClientSize = new Size(900, 650);
            Controls.Add(pnlGlavni);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            Text = "Prodaja udžbenika";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sifarniciToolStripMenuItem;
        private ToolStripMenuItem udzbeniciToolStripMenuItem;
        private ToolStripMenuItem osnovneSkoleToolStripMenuItem;  
        private ToolStripMenuItem obukeToolStripMenuItem;          
        private ToolStripMenuItem prodavciToolStripMenuItem;

        private ToolStripMenuItem racuniToolStripMenuItem;

        private ToolStripMenuItem kupciToolStripMenuItem;
        private Panel pnlGlavni;
    }
}