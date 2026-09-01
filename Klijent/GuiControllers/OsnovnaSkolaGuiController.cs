using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class OsnovnaSkolaGuiController
    {
        private static OsnovnaSkolaGuiController instance;
        public static OsnovnaSkolaGuiController Instance
        { get { if (instance == null) instance = new OsnovnaSkolaGuiController(); return instance; } }
        private OsnovnaSkolaGuiController() { }

        private UCOsnovnaSkola uc;
        private int izabranId = 0;

        internal Control CreatePanel()
        {
            uc = new UCOsnovnaSkola();
            uc.BtnSacuvaj.Click += Sacuvaj;
            uc.BtnIzmeni.Click += Izmeni;
            uc.BtnObrisi.Click += Obrisi;
            uc.BtnPretrazi.Click += Pretrazi;
            uc.DgvSkole.SelectionChanged += SelekcijaPromenjena;
            UcitajSve();
            return uc;
        }

        private void UcitajSve()
        {
            try { uc.DgvSkole.DataSource = Komunikacija.Instance.VratiListuSviOsnovnaSkola(); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju: " + ex.Message); }
        }

        private OsnovnaSkola ProcitajPolja()
        {
            if (string.IsNullOrWhiteSpace(uc.TxtNaziv.Text) || string.IsNullOrWhiteSpace(uc.TxtEmail.Text))
            {
                MessageBox.Show("Naziv i email moraju biti popunjeni!");
                return null;
            }
            return new OsnovnaSkola { Naziv = uc.TxtNaziv.Text, Email = uc.TxtEmail.Text };
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            var s = ProcitajPolja(); if (s == null) return;
            try { Komunikacija.Instance.KreirajOsnovnaSkola(s); MessageBox.Show("Škola je sačuvana."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void SelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvSkole.CurrentRow?.DataBoundItem is not OsnovnaSkola s) return;
            izabranId = s.Id;
            uc.TxtNaziv.Text = s.Naziv;
            uc.TxtEmail.Text = s.Email;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }
            var s = ProcitajPolja(); if (s == null) return;
            s.Id = izabranId;
            try { Komunikacija.Instance.PromeniOsnovnaSkola(s); MessageBox.Show("Škola je izmenjena."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }
            try
            {
                Komunikacija.Instance.ObrisiOsnovnaSkola(new OsnovnaSkola { Id = izabranId });
                MessageBox.Show("Škola je obrisana."); izabranId = 0; UcitajSve();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            var kriterijum = new OsnovnaSkola { Naziv = uc.TxtNaziv.Text, Email = uc.TxtEmail.Text };
            try { uc.DgvSkole.DataSource = Komunikacija.Instance.PretraziOsnovnaSkola(kriterijum); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }
    }
}
