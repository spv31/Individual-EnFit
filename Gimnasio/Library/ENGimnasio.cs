using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class ENGimnasio
    {
        private string nombre;
        private string descripcion;
        private string horario;
        private string localidad;
        private string direccion;
        private byte[] imagen = new byte[1000];

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string _descripccion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string _horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string _localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string _direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public byte[] _imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public ENGimnasio()
        {
            nombre = "";
            descripcion = "";
            horario = "";
            localidad = "";
            direccion = "";
            imagen = null;
        }

        public ENGimnasio(string nombre, string descripcion, string horario, string localidad, string direccion, byte[] imagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.horario = horario;
            this.localidad = localidad;
            this.direccion = direccion;
            this.imagen = imagen;
        }

        public ENGimnasio(ENGimnasio gimnasio)
        {
            this.nombre = gimnasio.nombre;
            this.descripcion = gimnasio.descripcion;
            this.horario = gimnasio.horario;
            this.localidad = gimnasio.localidad;
            this.direccion = gimnasio.direccion;
            this.imagen = gimnasio.imagen;
        }

        public bool createGimnasio()
        {
            CADGimnasio gimnasio = new CADGimnasio();
            if (!gimnasio.readGimnasio(this))
            {
                return gimnasio.createGimnasio(this);
            }
            return false;
        }

        public bool readGimnasio()
        {
            CADGimnasio gimnasio = new CADGimnasio();
            return gimnasio.readGimnasio(this);
        }

        public bool updateGimnasio()
        {
            CADGimnasio gimnasio = new CADGimnasio();
            ENGimnasio aux = new ENGimnasio();
            aux.nombre = this.nombre;
            aux.descripcion = this.descripcion;
            aux.horario = this.horario;
            aux.localidad = this.localidad;
            aux.direccion = this.direccion;
            aux.imagen = this.imagen;
            if (gimnasio.readGimnasio(this))
            {
                this.nombre = aux.nombre;
                this.descripcion = aux.descripcion;
                this.horario = aux.horario;
                this.localidad = aux.localidad;
                this.direccion = aux.direccion;
                this.imagen = aux.imagen;
                return gimnasio.updateGimnasio(this);
            }
            return false;
        }

        public bool deleteGimnasio()
        {
            CADGimnasio gimnasio = new CADGimnasio();
            if (gimnasio.readGimnasio(this))
            {
                return gimnasio.deleteGimnasio(this);
            }
            return false;
        }
    }
}