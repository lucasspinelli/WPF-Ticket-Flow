using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.Model
{
    public interface IDBConnection
    {
        DBInterface GetDBConnection();

    }
}
