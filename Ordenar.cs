﻿using System;
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
    public partial class Ordenar : Form
    {
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
    }
}