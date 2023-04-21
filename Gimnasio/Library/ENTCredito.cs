using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library
{
    public class ENTCredito
    {
        private long numero;
        private int codigo;
        private static int MAXCODIGO = 1;

        public long _numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public ENTCredito()
        {
            numero = 0;
            codigo = 0;
        }

        public ENTCredito(long numero, int codigo)
        {
            this.numero = numero;
            this.codigo = codigo;
        }

        public ENTCredito(ENTCredito tcredito)
        {
            this.numero = tcredito.numero;
            this.codigo = tcredito.codigo;
        }

        public bool createTCredito()
        {
            CADTCredito tcredito = new CADTCredito();
            if (!tcredito.readTCredito(this))
            {
                return tcredito.createTCredito(this);
            }
            return false;
        }

        public bool readTCredito()
        {
            CADTCredito tcredito = new CADTCredito();
            return tcredito.readTCredito(this);
        }

        public bool updateTCredito()
        {
            CADTCredito tcredito = new CADTCredito();
            ENTCredito aux = new ENTCredito();
            aux.numero = this.numero;
            aux.codigo = this.codigo;
            if (tcredito.readTCredito(this))
            {
                this.numero = aux.numero;
                this.codigo = aux.codigo;
                return tcredito.updateTCredito(this);
            }
            return false;
        }

        public bool deleteTCredito()
        {
            CADTCredito tcredito = new CADTCredito();
            if (tcredito.readTCredito(this))
            {
                return tcredito.deleteTCredito(this);
            }
            return false;
        }
    }
}
