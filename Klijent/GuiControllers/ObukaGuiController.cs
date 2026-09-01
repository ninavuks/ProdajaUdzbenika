using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class ObukaGuiController
    {
        private static ObukaGuiController instance;
        public static ObukaGuiController Instance
        { get { if (instance == null) instance = new ObukaGuiController(); return instance; } }
        private ObukaGuiController() { }

        private UCObuka uc;
        private int izabranId = 0;

        internal Control CreatePanel()
        {
            uc = new UCObuka();
            uc.BtnSacuvaj.Click += Sacuvaj;
            uc.BtnIzmeni.Click += Izmeni;
            uc.BtnObrisi.Click += Obrisi;
            uc.BtnPretrazi.Click += Pretrazi;
            uc.DgvObuke.SelectionChanged += SelekcijaPromenjena;
            UcitajSve();
            return uc;
        }

        private void UcitajSve()
        {
            try { uc.DgvObuke.DataSource = Komunikacija.Instance.VratiListuSviObuka(); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju: " + ex.Message); }
        }

        private Obuka ProcitajPolja()
        {
            if (string.IsNullOrWhiteSpace(uc.TxtNaziv.Text) || string.IsNullOrWhiteSpace(uc.TxtMesto.Text))
            {
                MessageBox.Show("Naziv i mesto moraju biti popunjeni!");
                return null;
            }
            return new Obuka { Naziv = uc.TxtNaziv.Text, Mesto = uc.TxtMesto.Text };
        }

        private void Sacuvaj(object sender, EventArgs e)
        {
            var o = ProcitajPolja(); if (o == null) return;
            try { Komunikacija.Instance.KreirajObuka(o); MessageBox.Show("Obuka je sačuvana."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void SelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvObuke.CurrentRow?.DataBoundItem is not Obuka o) return;
            izabranId = o.Id;
            uc.TxtNaziv.Text = o.Naziv;
            uc.TxtMesto.Text = o.Mesto;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }
            var o = ProcitajPolja(); if (o == null) return;
            o.Id = izabranId;
            try { Komunikacija.Instance.PromeniObuka(o); MessageBox.Show("Obuka je izmenjena."); UcitajSve(); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (izabranId == 0) { MessageBox.Show("Prvo izaberi red u tabeli."); return; }
            try
            {
                Komunikacija.Instance.ObrisiObuka(new Obuka { Id = izabranId });
                MessageBox.Show("Obuka je obrisana."); izabranId = 0; UcitajSve();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            var kriterijum = new Obuka { Naziv = uc.TxtNaziv.Text, Mesto = uc.TxtMesto.Text };
            try { uc.DgvObuke.DataSource = Komunikacija.Instance.PretraziObuka(kriterijum); }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }
    }
}
