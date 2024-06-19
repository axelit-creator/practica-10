using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_10
{
    
    internal class Cliente

    {
        public List<Tarjeta> Tarjeta = new List<Tarjeta>();

        private int id;
        private string nombre;
        private string direccion;
        private int telefono;
        private int CP;
        private string estado;
        private string municipio;
        private string referencia;
        private string rfc;


        // Get y set 

        public int ID
        {
            get { return id; }
            set { id = value; }
        }    
        public string Nombre
        { 
            get {  return nombre; }
            set {  nombre = value; } 
        }
        public string Direccion
        { 
            get {return direccion; } 
            set {  direccion = value; } 
        }
        public int Telefono 
        {   
            get {  return telefono; } 
            set {  telefono = value; } 
        }   
        public int Cp
        {  
            get { return CP; } 
            set { CP = value; } 
        }    
        public string Municipio
        {  
            get {  return municipio; }
            set {  municipio = value; }
        }
        public string Referencia 
        {  
            get {  return referencia; }
            set {  referencia = value; }
        }
        public string RFC 
        {  
            get { return rfc; } 
            set {  rfc = value; }
        } 
    }
}
