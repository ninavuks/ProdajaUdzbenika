namespace Server
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            txtServer = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSeaGreen;
            btnStart.Location = new Point(63, 78);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(290, 100);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.RosyBrown;
            btnStop.Location = new Point(63, 259);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(290, 100);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // txtServer
            // 
            txtServer.BackColor = SystemColors.ButtonFace;
            txtServer.Location = new Point(421, 189);
            txtServer.Name = "txtServer";
            txtServer.ReadOnly = true;
            txtServer.Size = new Size(320, 27);
            txtServer.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtServer);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Server";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnStart;
        private Button btnStop;
        private TextBox txtServer;
    }
}