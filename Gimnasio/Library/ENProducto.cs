using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using Library;

namespace Library
{
    public class ENProducto
    {
        private int codigo;
        private string tipo_prod;
        private DateTime fecha_cad;
        private float precio;
        private int stock;
        private byte[] imagen = new byte[1000];


        public int codigoProducto
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string tipoProducto
        {
            get { return tipo_prod; }
            set { tipo_prod = value; }
        }

        public DateTime fechaCaducidadProducto
        {
            get { return fecha_cad; }
            set { fecha_cad = value; }
        }

        public float precioProducto
        {
            get { return precio; }
            set { precio = value; }
        }

        public int stockProducto
        {
            get { return stock; }
            set { stock = value; }
        }

        public byte[] imagenProducto
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public ENProducto()
        {
            this.codigo = 0;
            this.tipo_prod = "";
            this.fecha_cad = DateTime.Now;
            this.precio = 0;
            this.stock = 0;
        }

        public ENProducto(int cod, string tipo, DateTime fecha, float costo, int disponible, byte[] imagen)
        {
            this.codigo = cod;
            this.tipo_prod = tipo;
            this.fecha_cad = fecha;
            this.precio = costo;
            this.stock = disponible;
            this.imagen = imagen;
        }

        public ENProducto(ENProducto producto)
        {
            this.codigo = producto.codigo;
            this.tipo_prod = producto.tipo_prod;
            this.fecha_cad = producto.fecha_cad;
            this.precio = producto.precio;
            this.stock = producto.stock;
            this.imagen = producto.imagen;
        }


        public bool crearProducto()
        {
            bool creado = false;

            CADProducto producto = new CADProducto();
            creado = producto.crearProducto(this);

            return creado;
        }

        public bool leerProducto()
        {
            bool leido = false;

            CADProducto producto = new CADProducto();
            leido = producto.leerProducto(this);

            return leido;
        }

        public int actualizarProducto()
        {
            int actualizado = 0;

            ENProducto nuevo = new ENProducto(this);
            CADProducto producto = new CADProducto();

            if (producto.leerProducto(nuevo))
            {
                actualizado = producto.actualizarProducto(this);
            }

            return actualizado;
        }

        public bool borrarProducto()
        {
            bool borrado = false;

            CADProducto producto = new CADProducto();
            if (producto.leerProducto(this))
            {
                borrado = producto.borrarProducto(this);
            }
            return borrado;
        }


        public static DataTable mostrarProductos()
        {
            DataTable mostrado = new DataTable();

            CADProducto producto = new CADProducto();
            mostrado = producto.mostrarProductos();

            return mostrado;
        }

        // muestra únicamente los productos de ese tipo (ya sea alimentación, accesorios, ...)
        public static DataTable mostrarTipoProductos(int tipoProd)
        {
            DataTable mostrado = new DataTable();

            CADProducto producto = new CADProducto();
            mostrado = producto.mostrarTipoProductos(tipoProd);

            return mostrado;
        }

        // no muestra los productos cuyo stock es inferior al que nos pasan
        public static DataTable mostrarProductosStock(int stock)
        {
            DataTable mostrado = new DataTable();

            CADProducto producto = new CADProducto();
            mostrado = producto.mostrarProductosStock(stock);

            return mostrado;
        }


        // muestra los precios de cada producto de forma ascendente (de menor a mayor)
        public static DataTable mostrarProductosAscendente(string tipoProducto, int stock)
        {
            DataTable mostrado = new DataTable();

            CADProducto producto = new CADProducto();
            mostrado = producto.mostrarProductosAscendente(tipoProducto, stock);

            return mostrado;
        }

        // muestra los precios de cada producto de forma descendente (de mayor a menor)
        public static DataTable mostrarProductosDescendente(string tipoProducto, int stock)
        {
            DataTable mostrado = new DataTable();

            CADProducto producto = new CADProducto();
            mostrado = producto.mostrarProductosDescendente(tipoProducto, stock);

            return mostrado;
        }

    }
}