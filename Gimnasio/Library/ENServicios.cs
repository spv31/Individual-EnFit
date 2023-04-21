using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library;

namespace Library
{
    public class ENServicios
    {
        private int codigo;
        private string tipoServicio;
        private string informacion;
        private float precio;
        private byte[] imagen = new byte[1000];

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string TipoServicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }
        public string Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENServicios()
        {
            Codigo = -1;
            TipoServicio = "";
            Informacion = "";
            Precio = -1;
        }
        /// <summary>
        /// Constructor por parámetros
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="tipoServicio"></param>
        /// <param name="informacion"></param>
        /// <param name="precio"></param>
        /// <param name="imagen"></param>
        public ENServicios(int codigo, string tipoServicio, string informacion, float precio, byte[] imagen)
        {
            Codigo = codigo;
            TipoServicio = tipoServicio;
            Informacion = informacion;
            Precio = precio;
            Imagen = imagen;
        }
        /// <summary>
        /// Constructor de copia (no se va a utilizar)
        /// </summary>
        /// <param name="enservicios"></param>
        public ENServicios(ENServicios enservicios)
        {
            this.Codigo = enservicios.codigo;
            this.TipoServicio = enservicios.tipoServicio;
            this.Informacion = enservicios.informacion;
            this.Precio = enservicios.precio;
            this.Imagen = enservicios.imagen;
        }
        /// <summary>
        /// Método para crear un servicio (superusuario)
        /// </summary>
        /// <returns></returns>
        public bool createServicio()
        {
            CADServicios servicio = new CADServicios();
            if (!servicio.readServicio(this))
            {
                return servicio.createServicio(this);
            }
            return false;
        }
        /// <summary>
        /// Método para leer un determinado servicio
        /// </summary>
        /// <returns></returns>
        public bool readServicio()
        {
            CADServicios servicio = new CADServicios();
            return servicio.readServicio(this);
        }
        /// <summary>
        /// Método para actualizar un servicio (superusuario)
        /// </summary>
        /// <returns></returns>
        public bool updateServicio()
        {
            CADServicios servicio = new CADServicios();
            ENServicios servicio_auxiliar = new ENServicios();
            servicio_auxiliar.Codigo = this.Codigo;
            servicio_auxiliar.TipoServicio = this.TipoServicio;
            servicio_auxiliar.Informacion = this.Informacion;
            servicio_auxiliar.Precio = this.Precio;
            servicio_auxiliar.Imagen = this.Imagen;
            if (servicio.readServicio(this))
            {
                this.Codigo = servicio_auxiliar.Codigo;
                this.TipoServicio = servicio_auxiliar.TipoServicio;
                this.Informacion = servicio_auxiliar.Informacion;
                this.Precio = servicio_auxiliar.Precio;
                this.Imagen = servicio_auxiliar.Imagen;
                return servicio.updateServicio(this);
            }
            return false;
        }
        /// <summary>
        /// Método para eliminar un servicio (superusuario)
        /// </summary>
        /// <returns></returns>
        public bool deleteServicio()
        {
            CADServicios servicio = new CADServicios();
            if (servicio.readServicio(this))
            {
                return servicio.deleteServicio(this);
            }
            return false;
        }
        public DataTable mostrarServicios()
        {
            CADServicios servicio = new CADServicios();
            DataTable servicios;
            servicios = servicio.mostrarServicios();
            return servicios;
        }
        /// <summary>
        /// Metodo para filtrar por tipos de servicio
        /// </summary>
        /// <param name="tipoServicio"></param>
        /// <returns></returns>
        public DataTable filterTypeServicio(string tipoServicio)
        {
            CADServicios servicio = new CADServicios();
            DataTable servicios;
            // Controlar en el CAD EXCEPCIONES
            servicios = servicio.filterTypeServicio(tipoServicio);
            return servicios;
        }
        /// <summary>
        /// Método para filtrar por precios
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public DataTable filterPriceServicio(float precio)
        {
            CADServicios servicio = new CADServicios();
            DataTable servicios;
            // Controlar en el CAD EXCEPCIONES
            servicios = servicio.filterPriceServicio(precio);
            return servicios;
        }
    }
}