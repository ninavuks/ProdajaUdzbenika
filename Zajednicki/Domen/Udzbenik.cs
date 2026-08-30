using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Udzbenik : IEntity
    {
         public int Id { get; set; }
         public string Naziv {  get; set; }
         public string Izdavac {  get; set; }
         public decimal CenaUdzbenika { get; set; }
         public int Razred {  get; set; }

        public string TableName => "Udzbenik";

        public string Values => $"'{Naziv}', '{Izdavac}', {CenaUdzbenika.ToString(CultureInfo.InvariantCulture)}, {Razred}";

        public string UpdateValues => $"naziv='{Naziv}', izdavac='{Izdavac}', " +
            $"cenaUdzbenika={CenaUdzbenika.ToString(CultureInfo.InvariantCulture)}, razred={Razred}";

        public string WhereUslov
        {
            get {
                if(Id > 0) return $"idUdzbenik={Id}";

                List<string> uslovi = new List<string>();
                if (!string.IsNullOrWhiteSpace(Naziv))
                    uslovi.Add($"naziv LIKE '%{Naziv}%'");
                if (!string.IsNullOrWhiteSpace(Izdavac))
                    uslovi.Add($"izdavac LIKE '%{Izdavac}%'");
                if (Razred > 0)
                    uslovi.Add($"razred={Razred}");

                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new Udzbenik
                {
                    Id = (int)reader["idUdzbenik"],
                    Naziv = (string)reader["naziv"],
                    Izdavac = (string)reader["izdavac"],
                    CenaUdzbenika = (decimal)reader["cenaUdzbenika"],
                    Razred = (int)reader["razred"]
                });
            }
            return lista;
        }
        public override string ToString() => $"{Naziv} ({Razred}. razred) - {Izdavac}";
    }
}
