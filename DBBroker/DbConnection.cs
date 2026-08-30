using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DBBroker
{
    internal class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConnection () {
            connection = new SqlConnection ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProdajaUdzbenika;Integrated Security=True");

        }
        public void OpenConnection() => connection?.Open();
        public void CloseConnection() => connection?.Close();
        public void BeginTransaction() => transaction = connection.BeginTransaction();
        public void Commit() => transaction?.Commit();

        public void Rollback() => transaction?.Rollback();

        public SqlCommand CreateCommand() => new SqlCommand("",connection,transaction);
    }
}
