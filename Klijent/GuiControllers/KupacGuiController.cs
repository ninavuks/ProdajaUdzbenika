using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class KupacGuiController
    {
        private static KupacGuiController instance;
        public static KupacGuiController Instance
        { get { if (instance == null) instance = new KupacGuiController(); return instance; } }
        private KupacGuiController() { }

        private UCKupac uc;
        private int izabranId = 0;

        internal Control CreatePanel()
        {
            uc = new UCKupac();
            uc.BtnSacuvaj.Click += Sacuvaj;
            uc.BtnIzmeni.Click += Izmeni;
            uc.BtnObrisi.Click += Obrisi;
            uc.BtnPretrazi.Click += Pretrazi;
            uc.DgvKupci.SelectionChanged += SelekcijaPromenjena;

            UcitajSkole();
            UcitajSve();
            return uc;
        }

        private void UcitajSkole()
        {
            try
            {
                var skole = Komunikacija.Instance.VratiListuSviOsnovnaSkola();
                uc.CmbOsnovnaSkola.DisplayMember = "Naziv";
                uc.CmbOsnovnaSkola.ValueMember = "Id";
                uc.CmbOsnovnaSkola.DataSource = skole;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju škola: " + ex.Message);
            }
        }

        private void UcitajSve()
        {
            try { uc.DgvKupci.DataSource = Komunikacija.Instance.VratiListuSviKupac(); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju: " + ex.Message); }
        }

        private Kupac ProcitajPolja()
        {
            if (string.IsNullOrWhiteSpace(uc.TxtIme.Text) ||
                string.IsNullOrWhiteSpace(uc.TxtPrezime.Text) ||
                string.IsNullOrWhiteSpace(uc.TxtEmail.Text) ||
                uc.CmbOsnovnaSkola.SelectedValue == null)
            {
                MessageBox.Show("Sva polja moraju biti popunjena i mora biti izabrana škola.");
                return null;
            }

            return new Kupac
            {
                Ime = uc.TxtIme.Text,
                Prezime = uc.TxtPrezime.Text,
                Email = uc.TxtEmail.Text,
                IdOsnovnaSkola = (int)uc.CmbOsnovnaSkola.SelectedValue
            };
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            var k = ProcitajPolja(); if (k == null) return;
            try { Komunikacija.Instance.KreirajKupac(k); MessageBox.Show("Kupac je sačuvan."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void SelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvKupci.CurrentRow?.DataBoundItem is not Kupac k) return;
            izabranId = k.Id;
            uc.TxtIme.Text = k.Ime;
            uc.TxtPrezime.Text = k.Prezime;
            uc.TxtEmail.Text = k.Email;
            uc.CmbOsnovnaSkola.SelectedValue = k.IdOsnovnaSkola;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izabrati red u tabeli."); return; }
            var k = ProcitajPolja(); if (k == null) return;
            k.Id = izabranId;
            try { Komunikacija.Instance.PromeniKupac(k); MessageBox.Show("Kupac je izmenjen."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izabrati red u tabeli."); return; }
            try
            {
                Komunikacija.Instance.ObrisiKupac(new Kupac { Id = izabranId });
                MessageBox.Show("Kupac je obrisan."); izabranId = 0; UcitajSve();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            var kriterijum = new Kupac { Ime = uc.TxtIme.Text, Prezime = uc.TxtPrezime.Text, Email = uc.TxtEmail.Text };
            try { uc.DgvKupci.DataSource = Komunikacija.Instance.PretraziKupac(kriterijum); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }
    }
}
