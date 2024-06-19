using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practica_10
{
    internal class Tarjeta
    {
        private long idTarjeta;
        private int cve;
        private DateTime fechaVencimiento;
        private string tipo;
        private string banco;
        private int cliente;

        //get y set
        public long IdTarjeta
        {
            get { return idTarjeta; }
            set { idTarjeta = value; }
        }
        public int Cve
        { 
            get { return cve; }
            set { cve = value; }
        }
        public DateTime FechaVencimiento 
        {   
            get {  return fechaVencimiento; } 
            set {  fechaVencimiento = value; } 
        }
        public string Tipo 
        {   get {  return tipo; } 
            set {  tipo = value; }
        }
        public string Banco 
        { 
            get {  return banco; } 
            set {  banco = value; } 
        }
        public int Cliente 
        { 
            get { return cliente; } 
            set {  cliente = value; }
        }
    }
}
