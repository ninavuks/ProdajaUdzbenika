using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class OsnovnaSkola : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }

        public string TableName => "OsnovnaSkola";
        public string Values => $"'{Naziv}', '{Email}'";
        public string UpdateValues => $"naziv='{Naziv}', email='{Email}'";

        public string WhereUslov
        {
            get
            {
                if (Id > 0) return $"idOsnovnaSkola={Id}";
                List<string> uslovi = new List<string>();
                if (!string.IsNullOrWhiteSpace(Naziv)) uslovi.Add($"naziv LIKE '%{Naziv}%'");
                if (!string.IsNullOrWhiteSpace(Email)) uslovi.Add($"email LIKE '%{Email}%'");
                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new OsnovnaSkola
                {
                    Id = (int)reader["idOsnovnaSkola"],
                    Naziv = (string)reader["naziv"],
                    Email = (string)reader["email"]
                });
            }
            return lista;
        }

        public override string ToString() => Naziv;
    }
}
