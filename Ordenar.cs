using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_10//llllllllllll
{//Prueba
    //otraprueba


    public partial class Ordenar : Form
    {

        private List<Pedido> PedidoRealizado = new List<Pedido>();
        public Ordenar()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicioSesion form = new inicioSesion();
            form.Show();
            this.Hide();
        }
        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenes ordenes = new Ordenes();
            ordenes.Show();
            this.Hide();
        }
        private void PicadasNegras_Click(object sender, EventArgs e)
        {
            double PrecioNegras = 100;
        }

        private void Ordenar_Load(object sender, EventArgs e)
        {

        }

        private void Anotarorden(object sender, EventArgs e)
        {
            SegPedido.DataSource = null;

            Pedido pd = new Pedido();
            pd.Salsa = tx_salsa.Text;
            pd.Frijoles = tx_frijoles.Text;
            pd.Queso = tx_queso.Text;
            pd.Cebolla = tx_cebolla.Text;
            pd.Huevo = tx_huevo.Text;
            pd.Bebida = tx_bebida.Text;

            PedidoRealizado.Add(pd);

            SegPedido.DataSource = PedidoRealizado;
        }
    }
}
