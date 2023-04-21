using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class ENEmpleado
    {
        private string dni;
        private string email;
        private string nombre;
        private int edad;
        private int telefono;
        private int cod_postal;
        private byte[] imagen = new byte[1000];

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int EDAD
        {
            get { return edad; }
            set { edad = value; }
        }

        public int TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int COD_POSTAL
        {
            get { return cod_postal; }
            set { cod_postal = value; }
        }

        public byte[] IMAGEN
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public ENEmpleado()
        {
            CADEmpleado empleado = new CADEmpleado();
            DNI = "";
            EMAIL = "";
            NOMBRE = "";
            EDAD = 0;
            TELEFONO = 0;
            COD_POSTAL = 0;
            empleado.imagenDefault(ref imagen);
        }

        public ENEmpleado(string dni, string email, string nombre, int edad, int telefono, int cod_postal, byte[] imagen)
        {
            this.dni = dni;
            this.email = email;
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            this.cod_postal = cod_postal;
            this.imagen = imagen;
        }

        public ENEmpleado(ENEmpleado empleado)
        {
            this.dni = empleado.dni;
            this.email = empleado.email;
            this.nombre = empleado.nombre;
            this.edad = empleado.edad;
            this.telefono = empleado.telefono;
            this.cod_postal = empleado.cod_postal;
            this.imagen = empleado.imagen;
        }

        public bool createEmpleado()
        {
            bool creado = false;

            CADEmpleado empleado = new CADEmpleado();

            if (!empleado.readEmpleado(this))
                creado = empleado.createEmpleado(this);

            return creado;
        }

        public bool readEmpleado()
        {
            CADEmpleado empleado = new CADEmpleado();

            bool leer = empleado.readEmpleado(this);

            return leer;
        }

        public bool updateEmpleado()
        {
            bool actualizado = false;

            ENEmpleado aux = new ENEmpleado();
            CADEmpleado empleado = new CADEmpleado();

            aux.dni = this.dni;
            aux.email = this.email;
            aux.nombre = this.nombre;
            aux.edad = this.edad;
            aux.telefono = this.telefono;
            aux.cod_postal = this.cod_postal;
            aux.imagen = this.imagen;

            if (empleado.readEmpleado(this))
            {
                this.dni = aux.dni;
                this.email = aux.email;
                this.nombre = aux.nombre;
                this.edad = aux.edad;
                this.telefono = aux.telefono;
                this.cod_postal = aux.cod_postal;
                this.imagen = aux.imagen;
            }

            return actualizado;
        }

        public bool delete()
        {
            bool borrar = false;

            CADEmpleado empleado = new CADEmpleado();

            if (empleado.readEmpleado(this))
                borrar = empleado.deleteEmpleado(this);

            return borrar;
        }

    }
}