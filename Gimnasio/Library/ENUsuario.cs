using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class ENUsuario
    {
        private string dni;
        private string nombre;
        private string apellidos;
        private string nif;
        private int edad;
        private DateTime fechaNac;
        private string email;
        private string telefono;
        private string direccion;
        private string ciudad;
        private string provincia;
        private string pais;
        private string codPostal;
        private string contraseña;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public ENUsuario()
        {
            Dni = "";
            Nombre = "";
            Apellidos = "";
            Nif = "";
            Edad = 0;
            FechaNac = DateTime.Today;
            Email = "";
            Telefono = "";
            Direccion = "";
            Ciudad = "";
            Provincia = "";
            Pais = "";
            CodPostal = "";
            Contraseña = "";
        }

        public ENUsuario(ENUsuario usuario)
        {
            Dni = usuario.dni;
            Nombre = usuario.nombre;
            Apellidos = usuario.apellidos;
            Nif = usuario.nif;
            Edad = usuario.edad;
            FechaNac = usuario.fechaNac;
            Email = usuario.email;
            Telefono = usuario.telefono;
            Direccion = usuario.direccion;
            Ciudad = usuario.ciudad;
            Provincia = usuario.provincia;
            Pais = usuario.pais;
            CodPostal = usuario.codPostal;
            Contraseña = usuario.contraseña;
        }

        public ENUsuario(string dni, string nombre, string apellidos, string nif, int edad, DateTime fechaNac, string email, string telefono, string direccion, string ciudad, string provincia, string pais, string codPostal, string contraseña)
        {
            Dni = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            Nif = nif;
            Edad = edad;
            FechaNac = fechaNac;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad = ciudad;
            Provincia = provincia;
            Pais = pais;
            CodPostal = codPostal;
            Contraseña = contraseña;
        }

        public bool readUsuario()
        {
            CADUsuario user = new CADUsuario();
            bool read = user.readUsuario(this);
            return read;
        }

        public bool createUsuario()
        {
            CADUsuario user = new CADUsuario();
            bool created = false;
            if (!user.readUsuario(this))
                created = user.createUsuario(this);
            return created;
        }

        public bool updateUsuario()
        {
            ENUsuario aux = new ENUsuario();
            CADUsuario user = new CADUsuario();

            bool updated = false;
            aux.nombre = this.nombre;
            aux.nif = this.nif;
            aux.edad = this.edad;

            if (user.readUsuario(this))
            {
                this.nombre = aux.nombre;
                this.nif = aux.nif;
                this.edad = aux.edad;
                updated = user.updateUsuario(this);
            }
            return updated;
        }

        public bool deleteUsuario()
        {
            CADUsuario user = new CADUsuario();
            bool delete = false;
            if (user.readUsuario(this))
                delete = user.deleteUsuario(this);
            return delete;
        }

        public bool checkUsuario()
        {
            CADUsuario user = new CADUsuario();
            bool check = false;
            if (user.readUsuario(this))
            {
                check = user.checkUsuario(this);
            }
            return check;
        }
    }
}