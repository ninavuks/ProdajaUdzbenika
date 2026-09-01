using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klijent.UserControls;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class RacunGuiController
    {
        private static RacunGuiController instance;
        public static RacunGuiController Instance
        { get { if (instance == null) instance = new RacunGuiController(); return instance; } }
        private RacunGuiController() { }

        private UCRacun uc;
        private int izabranIdRacun = 0;
        private List<Udzbenik> udzbenici = new List<Udzbenik>();
        private List<StavkaZaPrikaz> noveStavke = new List<StavkaZaPrikaz>();

        private class StavkaZaPrikaz
        {
            public int IdUdzbenik { get; set; }
            public string Naziv { get; set; }
            public int Kolicina { get; set; }
            public decimal Cena { get; set; }
            public decimal Iznos => Cena * Kolicina;
        }

        internal Control CreatePanel()
        {
            uc = new UCRacun();
            uc.DgvRacuni.SelectionChanged += RacunSelekcijaPromenjena;
            uc.BtnIzmeniZaglavlje.Click += IzmeniZaglavlje;
            uc.BtnDodajStavku.Click += DodajStavku;
            uc.BtnUkloniStavku.Click += UkloniStavku;
            uc.BtnSacuvajRacun.Click += SacuvajRacun;

            noveStavke.Clear();

            UcitajPadajuceListe();
            UcitajRacune();
            OsveziPrikazStavki();
            return uc;
        }

        private void UcitajPadajuceListe()
        {
            try
            {
                var kupci = Komunikacija.Instance.VratiListuSviKupac();
                uc.CmbKupac.DisplayMember = "PunoIme";
                uc.CmbKupac.ValueMember = "Id";
                uc.CmbKupac.DataSource = kupci;

                var prodavci = Komunikacija.Instance.VratiListuSviProdavac();
                uc.CmbIzmenaProdavac.DisplayMember = "PunoIme";
                uc.CmbIzmenaProdavac.ValueMember = "Id";
                uc.CmbIzmenaProdavac.DataSource = prodavci;

                udzbenici = Komunikacija.Instance.VratiListuSviUdzbenik();
                uc.CmbUdzbenik.DisplayMember = "PunNaziv";
                uc.CmbUdzbenik.ValueMember = "Id";
                uc.CmbUdzbenik.DataSource = udzbenici;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju padajućih lista: " + ex.Message);
            }
        }

        private void UcitajRacune()
        {
            try { uc.DgvRacuni.DataSource = Komunikacija.Instance.VratiListuSviRacun(); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju računa: " + ex.Message); }
        }

        private void RacunSelekcijaPromenjena(object sender, EventArgs e)
        {
            if (uc.DgvRacuni.CurrentRow?.DataBoundItem is not Racun r) return;
            izabranIdRacun = r.Id;
            uc.DtpIzmenaDatum.Value = r.Datum;
            uc.CmbIzmenaProdavac.SelectedValue = r.IdProdavac;

            try { uc.DgvStavkePregled.DataSource = Komunikacija.Instance.VratiListuStavkaRacunaZaRacun(r.Id); }
            catch (Exception ex) { MessageBox.Show("Greška pri učitavanju stavki: " + ex.Message); }
        }

        private void IzmeniZaglavlje(object sender, EventArgs e)
        {
            if (izabranIdRacun == 0) { MessageBox.Show("Prvo izaberi račun u tabeli."); return; }
            if (uc.CmbIzmenaProdavac.SelectedValue == null) { MessageBox.Show("Izaberi prodavca."); return; }

            var racun = new Racun
            {
                Id = izabranIdRacun,
                Datum = uc.DtpIzmenaDatum.Value,
                IdProdavac = (int)uc.CmbIzmenaProdavac.SelectedValue
            };

            try
            {
                Komunikacija.Instance.PromeniRacun(racun);
                MessageBox.Show("Račun je izmenjen.");
                UcitajRacune();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }

        private void DodajStavku(object sender, EventArgs e)
        {
            if (uc.CmbUdzbenik.SelectedValue == null) { MessageBox.Show("Izaberi udžbenik."); return; }

            int idUdzbenik = (int)uc.CmbUdzbenik.SelectedValue;
            var udzbenik = udzbenici.FirstOrDefault(u => u.Id == idUdzbenik);
            if (udzbenik == null) return;

            noveStavke.Add(new StavkaZaPrikaz
            {
                IdUdzbenik = udzbenik.Id,
                Naziv = udzbenik.Naziv,
                Kolicina = (int)uc.NumKolicina.Value,
                Cena = udzbenik.CenaUdzbenika
            });

            OsveziPrikazStavki();
        }

        private void UkloniStavku(object sender, EventArgs e)
        {
            if (uc.DgvNoveStavke.CurrentRow?.DataBoundItem is not StavkaZaPrikaz s) return;
            noveStavke.Remove(s);
            OsveziPrikazStavki();
        }

        private void OsveziPrikazStavki()
        {
            uc.DgvNoveStavke.DataSource = null;
            uc.DgvNoveStavke.DataSource = noveStavke.ToList();
            uc.LblUkupno.Text = "Ukupno: " + noveStavke.Sum(s => s.Iznos).ToString("0.00");
        }

        private void SacuvajRacun(object sender, EventArgs e)
        {
            if (uc.CmbKupac.SelectedValue == null) { MessageBox.Show("Izaberi kupca."); return; }
            if (noveStavke.Count == 0) { MessageBox.Show("Dodaj bar jednu stavku pre čuvanja."); return; }

            var racun = new Racun
            {
                Datum = uc.DtpDatum.Value,
                IdKupac = (int)uc.CmbKupac.SelectedValue,
                IdProdavac = MainCoordinator.Instance.UlogovaniProdavac.Id
            };

            var stavke = noveStavke.Select(s => new StavkaRacuna
            {
                IdUdzbenik = s.IdUdzbenik,
                Kolicina = s.Kolicina,
                Cena = s.Cena
            }).ToList();

            var paket = new RacunSaStavkama { Racun = racun, Stavke = stavke };

            try
            {
                Komunikacija.Instance.KreirajRacunSaStavkama(paket);
                MessageBox.Show("Račun je sačuvan.");
                noveStavke.Clear();
                OsveziPrikazStavki();
                UcitajRacune();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }
        }
    }
}