using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Library;

namespace Library
{
    class CADProducto
    {

        private string constring;

        public CADProducto()
        {
            constring = "";
        }

        public int obtenerCodigo(ENProducto prod)
        {
            return 1;
        }

        public bool crearProducto(ENProducto prod)
        {
            return true;
        }

        public bool leerProducto(ENProducto prod)
        {
            return true;
        }

        public int actualizarProducto(ENProducto prod)
        {
            return 0;
        }

        public bool borrarProducto(ENProducto prod)
        {
            return true;
        }


        public DataTable mostrarProductos()
        {
            DataTable baseDatos = new DataTable();

            return baseDatos;
        }

        public DataTable mostrarTipoProductos(int tipoProd)
        {
            DataTable baseDatos = new DataTable();

            return baseDatos;
        }

        public DataTable mostrarProductosStock(int stock)
        {
            DataTable baseDatos = new DataTable();

            return baseDatos;
        }


        public DataTable mostrarProductosAscendente(string tipoProducto, int stock)
        {
            DataTable baseDatos = new DataTable();

            return baseDatos;
        }

        public DataTable mostrarProductosDescendente(string tipoProducto, int stock)
        {
            DataTable baseDatos = new DataTable();

            return baseDatos;
        }
    }
}