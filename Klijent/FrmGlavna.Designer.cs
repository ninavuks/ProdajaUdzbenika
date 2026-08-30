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
            pnlGlavni = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sifarniciToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 1;
            // 
            // sifarniciToolStripMenuItem
            // 
            sifarniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { udzbeniciToolStripMenuItem });
            sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            sifarniciToolStripMenuItem.Size = new Size(76, 24);
            sifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // udzbeniciToolStripMenuItem
            // 
            udzbeniciToolStripMenuItem.Name = "udzbeniciToolStripMenuItem";
            udzbeniciToolStripMenuItem.Size = new Size(158, 26);
            udzbeniciToolStripMenuItem.Text = "Udžbenici";
            // 
            // pnlGlavni
            // 
            pnlGlavni.BackColor = Color.LightSteelBlue;
            pnlGlavni.Dock = DockStyle.Fill;
            pnlGlavni.Location = new Point(0, 28);
            pnlGlavni.Name = "pnlGlavni";
            pnlGlavni.Size = new Size(900, 622);
            pnlGlavni.TabIndex = 0;
            // 
            // FrmGlavna
            // 
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
        private Panel pnlGlavni;
    }
}