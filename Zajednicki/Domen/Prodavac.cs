using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Prodavac : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public string TableName => "Prodavac";
        public string Values => $"'{Ime}', '{Prezime}', '{KorisnickoIme}', '{Sifra}'";
        public string UpdateValues =>
            $"ime='{Ime}', prezime='{Prezime}', korisnickoIme='{KorisnickoIme}', sifra='{Sifra}'";

        public string WhereUslov
        {
            get
            {
                if (Id > 0) return $"idProdavac={Id}";
                List<string> uslovi = new List<string>();
                if (!string.IsNullOrWhiteSpace(Ime)) uslovi.Add($"ime LIKE '%{Ime}%'");
                if (!string.IsNullOrWhiteSpace(Prezime)) uslovi.Add($"prezime LIKE '%{Prezime}%'");
                if (!string.IsNullOrWhiteSpace(KorisnickoIme)) uslovi.Add($"korisnickoIme LIKE '%{KorisnickoIme}%'");
                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new Prodavac
                {
                    Id = (int)reader["idProdavac"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    KorisnickoIme = (string)reader["korisnickoIme"],
                    Sifra = (string)reader["sifra"]
                });
            }
            return lista;
        }

        public override string ToString() => $"{Ime} {Prezime} ({KorisnickoIme})";
    }
}
