using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Security.Permissions;
using Library;

namespace Library
{
    class CADContacto
    {
        private string constring;
        public CADContacto()
        {
        }
        public DataTable listarMensajes()
        {
            DataTable table = new DataTable();
            return table;
        }
        public bool createMensajes(ENContacto en)
        {
            return true;
        }
        public bool updateMensajes(ENContacto en)
        {
            return true;
        }
        public bool readMensajes(ENContacto en)
        {
            return true;
        }
        public bool deleteMensajes(ENContacto en)
        {
            return true;
        }
    }
}
