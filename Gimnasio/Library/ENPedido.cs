using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class ENPedido
    {
        private int num_ped;
        public DateTime fecha;
        public string dir_envio;
        public float precio;
        public float total_pagar;
        public List<ENProducto> productos { get; set; }
        public int Num_ped
        {
            get { return num_ped; }
            set { num_ped = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Dir_envio
        {
            get { return dir_envio; }
            set { dir_envio = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public float Total_pagar
        {
            get { return total_pagar; }
            set { total_pagar = value; }
        }
        public ENPedido()
        {
            num_ped = 0;
            fecha = default(DateTime);
            precio = 0;
            dir_envio = "";
            total_pagar = 0;
        }
        public ENPedido(int numeroPedido, DateTime Fecha, string direccionEnvio, float totalAPagar)
        {
            this.num_ped = numeroPedido;
            this.fecha = Fecha;
            this.dir_envio = direccionEnvio;
            this.precio = totalAPagar;
            this.productos = new List<ENProducto>();
        }
        public bool readPedido()
        {
            CADPedido pedido = new CADPedido();
            return pedido.readPedido(this);
        }
        public void agregarProducto(ENProducto producto)
        {
            productos.Add(producto);
            this.total_pagar += producto.precio;
        }
        public bool EliminarProducto(int id) // Esto creo que es del que tiene que hacer pedido
        {
            bool ok = false;
            if (this.productos.Count > id)
            {
                ENProducto producto = this.productos[id];
                this.productos.RemoveAt(id);
                this.total_pagar -= producto.precioProducto;
                ok = true;
            }
            return ok;
        }
        public float CalcularImpuesto(float imp)
        {
            float impuesto;
            impuesto = this.total_pagar * imp;
            this.total_pagar = impuesto;

            return impuesto;
        }
        public bool EliminarPedido() // Y este también
        {
            bool ok = false;
            CADPedido ped = new CADPedido();
            if (ped.readPedido(this))
            {
                ok = ped.EliminarPedido(this);
            }
            return ok;
        }
        public List<ENPedido> getListadoPedidos()
        {
            CADPedido pedido = new CADPedido();
            List<ENPedido> listaPedidos = new List<ENPedido>();

            DataTable dt = pedido.getListaPedidos();

            foreach (DataRow dr in dt.Rows)
            {
                ENPedido p = new ENPedido();
                p.num_ped = (int)dr["idPedido"];
                p.fecha = (DateTime)dr["fechaPedido"];
                p.dir_envio = (string)dr["envio"];
                p.total_pagar = (int)dr["cantidad"];
                p.precio = (decimal)dr["precio"];
                listaPedidos.Add(p);
            }

            return listaPedidos;
        }

        public bool updatePedido()
        {
            ENPedido aux = new ENPedido();
            CADPedido user = new CADPedido();

            bool updated = false;
            aux.num_ped = this.num_ped;
            aux.fecha = this.fecha;
            aux.dir_envio = this.dir_envio;
            aux.total_pagar = this.total_pagar;
            aux.precio = this.precio;

            if (user.readPedido(this))
            {
                this.num_ped = aux.num_ped;
                this.fecha = aux.fecha;
                this.dir_envio = aux.dir_envio;
                this.total_pagar = aux.total_pagar;
                this.precio = aux.precio;
                updated = user.updatePedido(this);
            }

            return updated;
        }
    }
}
