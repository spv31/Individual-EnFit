using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using Library;

namespace Library
{
    public class CADPedido
    {
        public bool readPedido(ENPedido pedido)
        {
            return true;   
        }
        public void agregarProducto(ENPedido pedido)
        {

        }
        public bool EliminarProducto(ENPedido pedido)
        {
            return true;
        }
        public float CalcularImpuesto(ENPedido pedido)
        {
            return -1;
        }
        public bool EliminarPedido(ENPedido pedido)
        {
            return true;
        }
        public void VerPedido(ENPedido pedido)
        {
            
        }
        public List<ENProducto> getListadoPedidos(ENPedido pedido)
        {
            
        }

        public bool updatePedido(ENPedido)
        {

        }
    }
}