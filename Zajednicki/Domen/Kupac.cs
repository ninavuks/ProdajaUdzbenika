using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Kupac : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int IdOsnovnaSkola { get; set; }

        public string PunoIme => $"{Ime} {Prezime}";

        public string TableName => "Kupac";
        public string Values => $"'{Ime}', '{Prezime}', '{Email}', {IdOsnovnaSkola}";
        public string UpdateValues =>
            $"ime='{Ime}', prezime='{Prezime}', email='{Email}', idOsnovnaSkola={IdOsnovnaSkola}";

        public string WhereUslov
        {
            get
            {
                if (Id > 0) return $"idKupac={Id}";

                List<string> uslovi = new List<string>();
                if (!string.IsNullOrWhiteSpace(Ime)) uslovi.Add($"ime LIKE '%{Ime}%'");
                if (!string.IsNullOrWhiteSpace(Prezime)) uslovi.Add($"prezime LIKE '%{Prezime}%'");
                if (!string.IsNullOrWhiteSpace(Email)) uslovi.Add($"email LIKE '%{Email}%'");
                if (IdOsnovnaSkola > 0) uslovi.Add($"idOsnovnaSkola={IdOsnovnaSkola}");

                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new Kupac
                {
                    Id = (int)reader["idKupac"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    Email = (string)reader["email"],
                    IdOsnovnaSkola = (int)reader["idOsnovnaSkola"]
                });
            }
            return lista;
        }

        public override string ToString() => $"{Ime} {Prezime}";
    }
}
