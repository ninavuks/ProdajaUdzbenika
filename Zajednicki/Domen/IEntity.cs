using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string UpdateValues { get; }
        string WhereUslov {  get; }

        List<IEntity> GetReaderList(SqlDataReader reader);


    }
}
