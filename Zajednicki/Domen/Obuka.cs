using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Obuka : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Mesto { get; set; }

        public string TableName => "Obuka";
        public string Values => $"'{Naziv}', '{Mesto}'";
        public string UpdateValues => $"naziv='{Naziv}', mesto='{Mesto}'";

        public string WhereUslov
        {
            get
            {
                if (Id > 0) return $"idObuka={Id}";
                List<string> uslovi = new List<string>();
                if (!string.IsNullOrWhiteSpace(Naziv)) uslovi.Add($"naziv LIKE '%{Naziv}%'");
                if (!string.IsNullOrWhiteSpace(Mesto)) uslovi.Add($"mesto LIKE '%{Mesto}%'");
                return uslovi.Count > 0 ? string.Join(" AND ", uslovi) : "1=1";
            }
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new Obuka
                {
                    Id = (int)reader["idObuka"],
                    Naziv = (string)reader["naziv"],
                    Mesto = (string)reader["mesto"]
                });
            }
            return lista;
        }

        public override string ToString() => $"{Naziv} ({Mesto})";
    }
}
