using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_10
{
    internal class Carrito
    {
        private List<DetalleCarrito> DetalleCarritos = new List<DetalleCarrito>();

        private int idCarrito;
        private DateTime fecha;
        private int idCliente;
        private double total;

        //get y set
        public int IdCarrito 
        { 
            get { return idCarrito; } 
            set { idCarrito = value; } 
        }
        public int IdCliente 
        { 
            get {  return idCliente; } 
            set { idCliente = value; } 
        }
        public DateTime Fecha
        { 
            get { return fecha; } 
            set { fecha = value; } 
        }
        public double Total 
        { 
            get { return total; } 
            set { total = value; } 
        }    
       

    }
}
