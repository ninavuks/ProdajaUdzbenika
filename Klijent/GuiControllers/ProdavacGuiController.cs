using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class ProdavacGuiController
    {
        private static ProdavacGuiController instance;
        public static ProdavacGuiController Instance
        { get { if (instance == null) instance = new ProdavacGuiController(); return instance; } }
        private ProdavacGuiController() { }

        private UCProdavac uc;
        private int izabranId = 0;

        internal Control CreatePanel()
        {
            uc = new UCProdavac();
            uc.BtnSacuvaj.Click += Sacuvaj;
            uc.BtnIzmeni.Click += Izmeni;
            uc.BtnObrisi.Click += Obrisi;
            uc.BtnPretrazi.Click += Pretrazi;
            uc.DgvProdavci.SelectionChanged += SelekcijaPromenjena;
            UcitajSve();
            return uc;
        }

        private void UcitajSve()
        {
            try { uc.DgvProdavci.DataSource = Komunikacija.Instance.VratiListuSviProdavac(); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju: " + ex.Message); }
        }

        private Prodavac ProcitajPolja()
        {
            if (string.IsNullOrWhiteSpace(uc.TxtIme.Text) ||
                string.IsNullOrWhiteSpace(uc.TxtPrezime.Text) ||
                string.IsNullOrWhiteSpace(uc.TxtKorisnickoIme.Text) ||
                uc.TxtSifra.Text.Length <= 6)
            {
                MessageBox.Show("Sva polja moraju biti popunjena, šifra mora imati više od 6 karaktera.");
                return null;
            }
            return new Prodavac
            {
                Ime = uc.TxtIme.Text,
                Prezime = uc.TxtPrezime.Text,
                KorisnickoIme = uc.TxtKorisnickoIme.Text,
                Sifra = uc.TxtSifra.Text
            };
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            var p = ProcitajPolja(); if (p == null) return;
            try { Komunikacija.Instance.KreirajProdavac(p); MessageBox.Show("Prodavac je sačuvan."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void SelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvProdavci.CurrentRow?.DataBoundItem is not Prodavac p) return;
            izabranId = p.Id;
            uc.TxtIme.Text = p.Ime;
            uc.TxtPrezime.Text = p.Prezime;
            uc.TxtKorisnickoIme.Text = p.KorisnickoIme;
            uc.TxtSifra.Text = p.Sifra;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }
            var p = ProcitajPolja(); if (p == null) return;
            p.Id = izabranId;
            try { Komunikacija.Instance.PromeniProdavac(p); MessageBox.Show("Prodavac je izmenjen."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izabrati red u tabeli."); return; }
            try
            {
                Komunikacija.Instance.ObrisiProdavac(new Prodavac { Id = izabranId });
                MessageBox.Show("Prodavac je obrisan."); izabranId = 0; UcitajSve();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            var kriterijum = new Prodavac { Ime = uc.TxtIme.Text, Prezime = uc.TxtPrezime.Text, KorisnickoIme = uc.TxtKorisnickoIme.Text };
            try { uc.DgvProdavci.DataSource = Komunikacija.Instance.PretraziProdavac(kriterijum); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }
    }
}
