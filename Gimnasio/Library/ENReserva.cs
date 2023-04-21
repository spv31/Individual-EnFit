using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    class ENReserva
    {
        private string usuario;
        private DateTime fecha;
        private TimeSpan hora;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public TimeSpan Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public ENReserva()
        {
            Usuario = "";
            Fecha = DateTime.Today;
            Hora = DateTime.Now.TimeOfDay;
        }

        public ENReserva(ENReserva reserva)
        {
            Usuario = reserva.usuario;
            Fecha = reserva.fecha;
            Hora = reserva.hora;
        }

        public ENReserva(string usuario, DateTime fecha, TimeSpan hora)
        {
            Usuario = usuario;
            Fecha = fecha;
            Hora = hora;
        }

        public bool readReserva()
        {
            CADReserva reserva = new CADReserva();
            bool read = reserva.readReserva(this);
            return read;
        }

        public bool createReserva()
        {
            bool created = false;
            CADReserva reserva = new CADReserva();
            if (!reserva.readReserva(this))
            {
                created = reserva.createReserva(this);
            }
            return created;
        }

        public bool updateReserva()
        {
            ENReserva aux = new ENReserva();
            CADReserva reserva = new CADReserva();

            bool updated = false;
            aux.usuario = this.usuario;
            aux.fecha = this.fecha;
            aux.hora = this.hora;

            if (reserva.readReserva(this))
            {
                this.usuario = aux.usuario;
                this.fecha = aux.fecha;
                this.hora = aux.hora;
                updated = reserva.updateReserva(this);
            }
            return updated;
        }

        public bool deleteReserva()
        {
            bool delete = false;
            CADReserva reserva = new CADReserva();

            if (reserva.readReserva(this))
            {
                delete = reserva.deleteReserva(this);
            }
            return delete;
        }
    }
}