using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    class ENOfertas
    {
        private string prod_desc;
        private int descuento;
        private DateTime fin_desc;
        private DateTime in_desc;

        public string prod_descrip
        {
            get { return prod_desc; }
            set { prod_desc = value; }
        }
        public int descuentoProd
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public DateTime fin_descProd
        {
            get { return fin_desc; }
            set { fin_desc = value; }
        }
        public DateTime in_descProd
        {
            get { return in_desc; }
            set { in_desc = value; }
        }
        public ENOfertas()
        {
            prod_desc = "";
            descuento = 0;
            this.fin_desc = DateTime.Now;
            this.in_desc = DateTime.Now;
        }
        public ENOfertas(string prod, int desc, DateTime fin, DateTime ini)
        {
            prod_desc = prod;
            descuento = desc;
            fin_desc = fin;
            in_desc = ini;
        }
        public ENOfertas(ENOfertas ofertas)
        {
            prod_desc = ofertas.prod_desc;
            descuento = ofertas.descuento;
            fin_desc = ofertas.fin_desc;
            in_desc = ofertas.in_desc;
        }
        static public DataSet listarOfertas()
        {
            CADOfertas oferta = new CADOfertas();
            DataSet ofertas;
            ofertas = oferta.listarOfertas();
            return ofertas;
        }
        static public DataTable listarProductos()
        {
            CADOfertas oferta = new CADOfertas();
            DataTable ofertas = new DataTable();
            ofertas = oferta.listarProductos();
            return ofertas;
        }
        public bool createOfertas()
        {
            CADOfertas oferta = new CADOfertas();
            bool crea = false;
            if (!oferta.readOfertas(this))
                crea = oferta.createOfertas(this);
            return crea;
        }
        public bool readOfertas()
        {
            bool leido = false;
            CADOfertas oferta = new CADOfertas();
            leido = oferta.readOfertas(this);
            return leido;
        }
        public bool updateOfertas()
        {
            bool actualizado = false;
            ENOfertas aux = new ENOfertas(this);
            CADOfertas oferta = new CADOfertas();
            if (aux.readOfertas())
            {
                actualizado = oferta.updateOfertas(this);
            }
            return actualizado;
        }
        public bool deleteOfertas()
        {
            bool borrado = false;
            CADOfertas oferta = new CADOfertas();
            if (oferta.readOfertas(this))
            {
                borrado = oferta.DeleteOfertas(this);
            }
            return borrado;
        }
    }
}