using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class UdzbenikGuiController
    {
        private static UdzbenikGuiController instance;
        public static UdzbenikGuiController Instance
        {
            get { if (instance == null) instance = new UdzbenikGuiController(); return instance; }
        }
        private UdzbenikGuiController() { }

        private UCUdzbenik uc;

        internal Control CreateUdzbenikPanel()
        {
            uc = new UCUdzbenik();
            uc.BtnSacuvaj.Click += Sacuvaj;
            uc.BtnIzmeni.Click += Izmeni;
            uc.BtnObrisi.Click += Obrisi;
            uc.BtnPretrazi.Click += Pretrazi;
            uc.DgvUdzbenici.SelectionChanged += SelekcijaPromenjena;
            UcitajSve();
            return uc;
        }

        private void UcitajSve()
        {
            try
            {
                uc.DgvUdzbenici.DataSource = Komunikacija.Instance.VratiListuSviUdzbenik();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju: " + ex.Message);
            }
        }

        private Udzbenik ProcitajPolja()
        {
            if (string.IsNullOrWhiteSpace(uc.TxtNaziv.Text) ||
                string.IsNullOrWhiteSpace(uc.TxtIzdavac.Text) ||
                !decimal.TryParse(uc.TxtCena.Text, out decimal cena))
            {
                MessageBox.Show("Naziv, izdavač i cena moraju biti popunjeni ispravno.");
                return null;
            }

            return new Udzbenik
            {
                Naziv = uc.TxtNaziv.Text,
                Izdavac = uc.TxtIzdavac.Text,
                CenaUdzbenika = cena,
                Razred = (int)uc.NumRazred.Value
            };
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            Udzbenik udzbenik = ProcitajPolja();
            if (udzbenik == null) return;

            try
            {
                Komunikacija.Instance.KreirajUdzbenik(udzbenik);
                MessageBox.Show("Udžbenik je sačuvan.");
                UcitajSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private int izabranId = 0;

        private void SelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvUdzbenici.CurrentRow?.DataBoundItem is not Udzbenik u) return;

            izabranId = u.Id;
            uc.TxtNaziv.Text = u.Naziv;
            uc.TxtIzdavac.Text = u.Izdavac;
            uc.TxtCena.Text = u.CenaUdzbenika.ToString();
            uc.NumRazred.Value = u.Razred;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }

            Udzbenik udzbenik = ProcitajPolja();
            if (udzbenik == null) return;
            udzbenik.Id = izabranId;

            try
            {
                Komunikacija.Instance.PromeniUdzbenik(udzbenik);
                MessageBox.Show("Udžbenik je izmenjen.");
                UcitajSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }

            try
            {
                Komunikacija.Instance.ObrisiUdzbenik(new Udzbenik { Id = izabranId });
                MessageBox.Show("Udžbenik je obrisan.");
                izabranId = 0;
                UcitajSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            Udzbenik kriterijum = new Udzbenik
            {
                Naziv = uc.TxtNaziv.Text,
                Izdavac = uc.TxtIzdavac.Text,
                Razred = (int)uc.NumRazred.Value
            };

            try
            {
                uc.DgvUdzbenici.DataSource = Komunikacija.Instance.PretraziUdzbenik(kriterijum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
