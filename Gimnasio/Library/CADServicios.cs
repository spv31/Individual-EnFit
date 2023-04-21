using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    class CADServicios
    {
        public string constring;

        public CADServicios()
        {
            constring = "";
        }

        public bool createServicio(ENServicios enservicio)
        {
            return true;
        }

        public bool readServicio(ENServicios enservicio)
        {
            return true;
        }

        public bool updateServicio(ENServicios enservicio)
        {
            return true;
        }

        public bool deleteServicio(ENServicios enservicio)
        {
            return true;
        }

        public DataTable mostrarServicios()
        {
            DataTable table = new DataTable();
            return table;
        }

        public DataTable filterTypeServicio(string TipoServicio)
        {
            DataTable table = new DataTable();
            return table;
        }

        public DataTable filterPriceServicio(float price)
        {
            DataTable table = new DataTable();
            return table;
        }
    }
}
