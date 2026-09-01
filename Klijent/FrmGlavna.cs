using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.GuiControllers;

namespace Klijent
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
            udzbeniciToolStripMenuItem.Click += MainCoordinator.Instance.ShowUdzbenikPanel;
            osnovneSkoleToolStripMenuItem.Click += MainCoordinator.Instance.ShowOsnovnaSkolaPanel;
            obukeToolStripMenuItem.Click += MainCoordinator.Instance.ShowObukaPanel;
            prodavciToolStripMenuItem.Click += MainCoordinator.Instance.ShowProdavacPanel;
            kupciToolStripMenuItem.Click += MainCoordinator.Instance.ShowKupacPanel;
            racuniToolStripMenuItem.Click += MainCoordinator.Instance.ShowRacunPanel;
        }

        public void ChangePanel(Control control)
        {
            pnlGlavni.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(control);
        }
    }
}
