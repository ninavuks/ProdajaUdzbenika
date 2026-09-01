using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance


        {
            get { if (instance == null) instance = new MainCoordinator(); return instance; }
        }
        private MainCoordinator() { }

        private FrmGlavna frmGlavna;

        internal Prodavac UlogovaniProdavac { get; private set; }

        internal void ShowUdzbenikPanel(object sender, EventArgs e)
        {
            frmGlavna.ChangePanel(UdzbenikGuiController.Instance.CreateUdzbenikPanel());
        }

        internal void ShowFrmGlavna()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Komunikacija.Instance.Connect();

                LoginFrm loginFrm = new LoginFrm();
                if (loginFrm.ShowDialog() != DialogResult.OK)
                    return;

                UlogovaniProdavac = loginFrm.UlogovaniProdavac;

                frmGlavna = new FrmGlavna();
                Application.Run(frmGlavna);
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešna konekcija sa serverom.");
            }
        }

        internal void ShowOsnovnaSkolaPanel(object sender, EventArgs e)
        { 
            frmGlavna.ChangePanel(OsnovnaSkolaGuiController.Instance.CreatePanel()); 
        }
        internal void ShowObukaPanel(object sender, EventArgs e)
        { 
            frmGlavna.ChangePanel(ObukaGuiController.Instance.CreatePanel()); 
        }
        internal void ShowProdavacPanel(object sender, EventArgs e)
        { 
            frmGlavna.ChangePanel(ProdavacGuiController.Instance.CreatePanel()); 
        }

        internal void ShowKupacPanel(object sender, EventArgs e)
        { 
            frmGlavna.ChangePanel(KupacGuiController.Instance.CreatePanel()); 
        }

        internal void ShowRacunPanel(object sender, EventArgs e)
        { 
            frmGlavna.ChangePanel(RacunGuiController.Instance.CreatePanel()); 
        }
    }
}
