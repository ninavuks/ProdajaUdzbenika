using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class StavkaRacuna : IEntity
    {
        public int IdRacun { get; set; }
        public int Rb { get; set; }
        public int Kolicina { get; set; }
        public decimal Cena { get; set; }
        public decimal Iznos { get; set; }
        public int IdUdzbenik { get; set; }

        public string TableName => "StavkaRacuna";

        public string Values =>
            $"{IdRacun}, {Rb}, {Kolicina}, {Cena.ToString(CultureInfo.InvariantCulture)}, " +
            $"{Iznos.ToString(CultureInfo.InvariantCulture)}, {IdUdzbenik}";

        public string UpdateValues => ""; 
        public string WhereUslov => $"idRacun={IdRacun}" + (Rb > 0 ? $" AND rb={Rb}" : "");

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();
            while (reader.Read())
            {
                lista.Add(new StavkaRacuna
                {
                    IdRacun = (int)reader["idRacun"],
                    Rb = (int)reader["rb"],
                    Kolicina = (int)reader["kolicina"],
                    Cena = (decimal)reader["cena"],
                    Iznos = (decimal)reader["iznos"],
                    IdUdzbenik = (int)reader["idUdzbenik"]
                });
            }
            return lista;
        }
    }
}
