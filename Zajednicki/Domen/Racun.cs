using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Racun : IEntity
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public decimal UkupanIznos { get; set; }
        public int IdProdavac { get; set; }
        public int IdKupac { get; set; }

        public string TableName => "Racun";

        public string Values =>
            $"'{Datum:yyyy-MM-dd}', {UkupanIznos.ToString(CultureInfo.InvariantCulture)}, {IdProdavac}, {IdKupac}";

        public string UpdateValues => $"datum='{Datum:yyyy-MM-dd}', idProdavac={IdProdavac}";

        public string WhereUslov
        {
            get
            {
                if (Id > 0) return $"idRacun={Id}";

                List<string> uslovi = new List<string>();
                if (IdProdavac > 0) uslovi.Add($"idProdavac={IdProdavac}");
                if (IdKupac > 0) uslovi.Add($"idKupac={IdKupac}");
                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new Racun
                {
                    Id = (int)reader["idRacun"],
                    Datum = (DateTime)reader["datum"],
                    UkupanIznos = (decimal)reader["ukupanIznos"],
                    IdProdavac = (int)reader["idProdavac"],
                    IdKupac = (int)reader["idKupac"]
                });
            }
            return lista;
        }
    }
}
