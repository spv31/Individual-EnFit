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
    public class CADOfertas
    {
        private string constring;
        public CADOfertas()
        {
            constring = "";
        }
        public DataSet listarOfertas()
        {
            DataSet table = new DataSet();
            return table;
        }
        public DataTable listarProductos()
        {
            DataTable table = new DataTable();
            return table;
        }
        public bool createOfertas(ENOfertas en)
        {
            return true;
        }
        public bool updateOfertas(ENOfertas en)
        {
            return true;
        }
        public bool readOfertas(ENOfertas en)
        {
            return true;
        }
        public bool deleteOfertas(ENOfertas en)
        {
            return true;
        }
    }
}