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
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void cambiarFormulario(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            ordenar.Show();
            this.Hide();
            
        }

        private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContraseña.Checked)
            {
                Contraseña.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                Contraseña.PasswordChar = '*'; // Ocultar texto con *
            }

        }
    }
}
