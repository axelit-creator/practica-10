using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_10
{
    internal class ListaProductos
    {
        private string sku;
        private double precio;
        private string descripcion;
        private string unidad; 

        //get y set 
        public string Sku 
        { 
            get { return sku; } 
            set {  sku = value; }
        }
        public double Precio 
        { 
            get { return precio; } 
            set {  precio = value; }
        }    
        public string Descripcion
        { 
            get {  return descripcion; } 
            set {  descripcion = value; } 
        }
        public string Unidad 
        {
            get {  return unidad; } 
            set {  unidad = value; }
        }

    }
}
