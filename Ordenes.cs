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
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        private void agregarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            ordenar.Show();
            this.Close();
        }
    }
}
