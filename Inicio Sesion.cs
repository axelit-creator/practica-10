using System;
using System.Windows.Forms;

namespace practica_10
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void cambiarFormulario(object sender, EventArgs e)
        {
            string nombre = "Derek";//ususario
            string password = "yy130808";//contraseña del usuario correspondiente
            string nombre2 = "Alex";//ususario
            string password2 = "1327";//contraseña del usuario correspondiente
            string nombre3 = "Axel";//ususario
            string password3 = "1234";//contraseña del usuario correspondiente
            string nombre4 = "Carlos";//ususario
            string password4 = "1234";//contraseña del usuario correspondiente
            if (!string.IsNullOrEmpty(tx_usuario.Text) && !string.IsNullOrEmpty(tx_contraseña.Text))//comprobar si hay algo en los textbox
            {
                if ((tx_usuario.Text == nombre && tx_contraseña.Text == password) ||//comprobar contraseñas de los ususarios
        (tx_usuario.Text == nombre2 && tx_contraseña.Text == password2) ||
        (tx_usuario.Text == nombre3 && tx_contraseña.Text == password3) ||
        (tx_usuario.Text == nombre4 && tx_contraseña.Text == password4))
                {
                    Ordenar ordenar = new Ordenar();//si es correcto pasar al formilario
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

        private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContraseña.Checked)//comprovar si esta o no marcado el cuiadro de lista
            {
                tx_contraseña.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                tx_contraseña.PasswordChar = '*'; // Ocultar texto con *
            }

        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {
            tx_contraseña.PasswordChar = '*';
        }

        private void Lb_Admin_Click(object sender, EventArgs e)
        {
            InicioDeSesionAdmin form = new InicioDeSesionAdmin();
            form.Show();
            this.Hide();
        }

        private void tx_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
