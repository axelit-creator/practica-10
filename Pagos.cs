using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_10
{
    internal class Pagos
    {
        private int idPagos;
        private DateTime fecha;
        private string formaPago;
        private double monto;
        private int idCarrito;
        private long numeroTarjeta; 

        //get y set 
        public int IdPagos 
        { 
            get { return idPagos; } 
            set { idPagos = value; } 
        } 
        public DateTime Fecha 
        { 
            get {  return fecha; } 
            set {  fecha = value; } 
        }
        public string FormaPago 
        { 
            get {  return formaPago; } 
            set {  formaPago = value; } 
        }
        public double Monto 
        { 
            get {  return monto; } 
            set {  monto = value; } 
        }
        public int IdCarrito 
        {
            get {  return idCarrito; } 
            set { idCarrito = value; } 
        }
        public long NumeroTarjeta 
        { 
            get {  return numeroTarjeta; } 
            set {  numeroTarjeta = value; } 
        }
    }
}
