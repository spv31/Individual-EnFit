using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    class ENContacto
    {
        private int codigo;
        private string asunto;
        private string contenido;
        private string usuario;

        public int codigoMensaje
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string asuntoMensaje
        {
            get { return asunto; }
            set { asunto = value; }
        }
        public string contenidoMensaje
        {
            get { return contenido; }
            set { contenido = value; }
        }
        public string usuarioMensaje
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public ENContacto()
        {
            codigo = 0;
            asunto = "";
            contenido = "";
            usuario = "";
        }
        public ENContacto(int cod, string asun, string cont, string usua)
        {
            codigo = cod;
            asunto = asun;
            contenido = cont;
            usuario = usua;
        }
        public ENContacto(ENContacto contacto)
        {
            codigo = contacto.codigo;
            asunto = contacto.asunto;
            contenido = contacto.contenido;
            usuario = contacto.usuario;
        }
        static public DataTable listarMensajes()
        {
            CADContacto mensaje = new CADContacto();
            DataTable mensajes = new DataTable();
            mensajes = mensaje.listarMensajes();
            return mensajes;
        }
        public bool createMensajes()
        {
            CADContacto mensaje = new CADContacto();
            bool crea = false;
            if (!mensaje.readMensajes(this))
                crea = mensaje.createMensajes(this);
            return crea;
        }
        public bool readMensajes()
        {
            bool leido = false;
            CADContacto mensaje = new CADContacto();
            leido = mensaje.readMensajes(this);
            return leido;
        }
        public bool updateMensajes()
        {
            bool actualizado = false;
            ENContacto aux = new ENContacto(this);
            CADContacto mensaje = new CADContacto();
            if (aux.readMensajes())
            {
                actualizado = mensaje.updateMensajes(this);
            }
            return actualizado;
        }
        public bool deleteMensajes()
        {
            bool borrado = false;
            CADContacto mensaje = new CADContacto();
            if (mensaje.readMensajes(this))
            {
                borrado = mensaje.deleteMensajes(this);
            }
            return borrado;
        }
    }
}
