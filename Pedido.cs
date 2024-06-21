using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_10
{
    internal class Pedido
    {
        public string tipoorden;
        public string queso;
        public string cebolla;
        public string frijoles;
        public string salsa;
        public string huevo;
        public string bebida;

        //get y set

        public string Tipoorden
        {
            get { return tipoorden; }
            set { tipoorden = value; }
        }

        public string Queso
        {
            get { return queso; }
            set { queso = value; }
        }

        public string Cebolla
        {
            get { return cebolla; }
            set { cebolla = value; }
        }

        public string Frijoles
        {
            get { return frijoles;}
            set { frijoles = value;}
        }

        public string Salsa
        {
            get { return salsa; }
            set { salsa = value; }
        }

        public string Huevo
        {
            get { return huevo; }
            set { huevo = value; }
        }

        public string Bebida
        {
            get { return bebida; }
            set { bebida = value; }
        }
    }
}
