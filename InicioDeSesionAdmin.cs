using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_10
{
    public partial class InicioDeSesionAdmin : Form
    {
        public InicioDeSesionAdmin()
        {
            InitializeComponent();
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            inicioSesion form = new inicioSesion();
            form.Show();
            this.Hide();
        }

        private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContraseña.Checked)//comprovar si esta o no marcado el cuiadro de lista
            {
                tx_contraseñaAdmin.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                tx_contraseñaAdmin.PasswordChar = '*'; // Ocultar texto con *
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = "Derek";//ususario
            string password = "yy130808";//contraseña del usuario correspondiente
            string nombre2 = "Alex";//ususario
            string password2 = "1327";//contraseña del usuario correspondiente
            string nombre3 = "Axel";//ususario
            string password3 = "1234";//contraseña del usuario correspondiente
            string nombre4 = "Carlos";//ususario
            string password4 = "1234";//contraseña del usuario correspondiente
            if (!string.IsNullOrEmpty(tx_usuarioAdmin.Text) && !string.IsNullOrEmpty(tx_contraseñaAdmin.Text))//comprovar si hay algo en los textbox
            {
                if ((tx_usuarioAdmin.Text == nombre && tx_contraseñaAdmin.Text == password) ||//comprobar contraseñas de los ususarios
        (tx_usuarioAdmin.Text == nombre2 && tx_contraseñaAdmin.Text == password2) ||
        (tx_usuarioAdmin.Text == nombre3 && tx_contraseñaAdmin.Text == password3) ||
        (tx_usuarioAdmin.Text == nombre4 && tx_contraseñaAdmin.Text == password4))
                {
                    Administrador ordenar = new Administrador();//si es correcto pasar al formilario
                    ordenar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.❌");//si no, mostrar cuadro de texto
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña😃.");//si no mostrar cuadro de texto
            }
        }
    }
}
