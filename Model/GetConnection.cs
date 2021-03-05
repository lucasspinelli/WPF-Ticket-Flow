using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.Model
{
    public class GetConnection : IDBConnection
    {
        public DBInterface GetDBConnection()
        {
            return new ConnectionDB();
        }
    }
}
