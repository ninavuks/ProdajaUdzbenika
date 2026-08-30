using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using Zajednicki.Domen;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker() { connection = new DbConnection(); }

        public void OpenConnection() => connection.OpenConnection();
        public void CloseConnection() => connection.CloseConnection();
        public void BeginTransaction() => connection.BeginTransaction();
        public void Commit() => connection.Commit();
        public void Rollback() => connection.Rollback();

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}";
            using SqlDataReader reader = command.ExecuteReader();
            return entity.GetReaderList(reader);
        }

        public List<IEntity> GetByCriteria(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName} where {entity.WhereUslov}";
            using SqlDataReader reader = command.ExecuteReader();
            return entity.GetReaderList(reader);
        }

        public int Add(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {entity.TableName} values({entity.Values}); select SCOPE_IDENTITY();";
            object rezultat = cmd.ExecuteScalar();
            return Convert.ToInt32(rezultat);
        }

        public void Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"update {entity.TableName} set {entity.UpdateValues} where {entity.WhereUslov}";
            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Nije pronađen zapis za izmenu.");
        }

        public void Delete(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete from {entity.TableName} where {entity.WhereUslov}";
            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Nije pronađen zapis za brisanje.");
        }
    }
}
