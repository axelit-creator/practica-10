﻿namespace practica_10
{
    partial class Ordenar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
            this.label1 = new System.Windows.Forms.Label();
            this.SegPedido = new System.Windows.Forms.DataGridView();
            this.tx_salsa = new System.Windows.Forms.TextBox();
            this.tx_frijoles = new System.Windows.Forms.TextBox();
            this.tx_queso = new System.Windows.Forms.TextBox();
            this.tx_cebolla = new System.Windows.Forms.TextBox();
            this.tx_huevo = new System.Windows.Forms.TextBox();
            this.tx_bebida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
>>>>>>> 7b417766a4ba2cdcbe624d35144ec96aa4e1672c
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
=======
            this.label1 = new System.Windows.Forms.Label();
>>>>>>> Stashed changes
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(6)))), ((int)(((byte)(2)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< Updated upstream
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
<<<<<<< HEAD
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
=======
            this.menuStrip1.Size = new System.Drawing.Size(1171, 28);
>>>>>>> Stashed changes
=======
            this.menuStrip1.Size = new System.Drawing.Size(970, 28);
>>>>>>> 7b417766a4ba2cdcbe624d35144ec96aa4e1672c
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carritoToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesToolStripMenuItem});
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.carritoToolStripMenuItem.Text = "Carrito";
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.ordenesToolStripMenuItem.Text = "Ordenes ";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tomar orden";
            // 
            // SegPedido
            // 
            this.SegPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegPedido.Location = new System.Drawing.Point(0, 412);
            this.SegPedido.Name = "SegPedido";
            this.SegPedido.RowHeadersWidth = 51;
            this.SegPedido.RowTemplate.Height = 24;
            this.SegPedido.Size = new System.Drawing.Size(970, 150);
            this.SegPedido.TabIndex = 4;
            // 
            // tx_salsa
            // 
            this.tx_salsa.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salsa.Location = new System.Drawing.Point(198, 66);
            this.tx_salsa.Name = "tx_salsa";
            this.tx_salsa.Size = new System.Drawing.Size(100, 44);
            this.tx_salsa.TabIndex = 5;
            // 
            // tx_frijoles
            // 
            this.tx_frijoles.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_frijoles.Location = new System.Drawing.Point(198, 144);
            this.tx_frijoles.Name = "tx_frijoles";
            this.tx_frijoles.Size = new System.Drawing.Size(100, 44);
            this.tx_frijoles.TabIndex = 6;
            // 
            // tx_queso
            // 
            this.tx_queso.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_queso.Location = new System.Drawing.Point(198, 222);
            this.tx_queso.Name = "tx_queso";
            this.tx_queso.Size = new System.Drawing.Size(100, 44);
            this.tx_queso.TabIndex = 7;
            // 
            // tx_cebolla
            // 
            this.tx_cebolla.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cebolla.Location = new System.Drawing.Point(653, 66);
            this.tx_cebolla.Name = "tx_cebolla";
            this.tx_cebolla.Size = new System.Drawing.Size(100, 44);
            this.tx_cebolla.TabIndex = 8;
            // 
            // tx_huevo
            // 
            this.tx_huevo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_huevo.Location = new System.Drawing.Point(653, 144);
            this.tx_huevo.Name = "tx_huevo";
            this.tx_huevo.Size = new System.Drawing.Size(100, 44);
            this.tx_huevo.TabIndex = 9;
            // 
            // tx_bebida
            // 
            this.tx_bebida.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_bebida.Location = new System.Drawing.Point(653, 222);
            this.tx_bebida.Name = "tx_bebida";
            this.tx_bebida.Size = new System.Drawing.Size(100, 44);
            this.tx_bebida.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Frijoles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salsa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Queso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Seguimiento de orden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 38);
            this.label9.TabIndex = 11;
            this.label9.Text = "Frijoles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 38);
            this.label10.TabIndex = 12;
            this.label10.Text = "Salsa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 38);
            this.label11.TabIndex = 13;
            this.label11.Text = "Queso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(468, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 38);
            this.label12.TabIndex = 14;
            this.label12.Text = "Cebolla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(510, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 38);
            this.label13.TabIndex = 15;
            this.label13.Text = "Huevo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(500, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 38);
            this.label14.TabIndex = 16;
            this.label14.Text = "Bebida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 95);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Anotarorden);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::practica_10.Properties.Resources.Picadas2;
            this.pictureBox3.Location = new System.Drawing.Point(790, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::practica_10.Properties.Resources.Picadas;
            this.pictureBox2.Location = new System.Drawing.Point(304, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
>>>>>>> 7b417766a4ba2cdcbe624d35144ec96aa4e1672c
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practica_10.Properties.Resources.tialulasinfondo;
            this.pictureBox1.Location = new System.Drawing.Point(760, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "EN ESTE FORMULARIO IRA EL MENÚ Y AQUI MISMO SE ORDENARAN LAS COSAS Y SE ENVIARAN " +
    "AL FORMULARIO DE ORDENES\r\n";
>>>>>>> Stashed changes
            // 
            // Ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            this.ClientSize = new System.Drawing.Size(970, 563);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_bebida);
            this.Controls.Add(this.tx_huevo);
            this.Controls.Add(this.tx_cebolla);
            this.Controls.Add(this.tx_queso);
            this.Controls.Add(this.tx_frijoles);
            this.Controls.Add(this.tx_salsa);
            this.Controls.Add(this.SegPedido);
            this.Controls.Add(this.label1);
>>>>>>> 7b417766a4ba2cdcbe624d35144ec96aa4e1672c
            this.Controls.Add(this.pictureBox1);
=======
            this.ClientSize = new System.Drawing.Size(1171, 584);
            this.Controls.Add(this.label1);
>>>>>>> Stashed changes
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ordenar";
            this.Text = "Ordenar";
            this.Load += new System.EventHandler(this.Ordenar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
<<<<<<< Updated upstream
        private System.Windows.Forms.PictureBox pictureBox1;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label label1;
>>>>>>> Stashed changes
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SegPedido;
        private System.Windows.Forms.TextBox tx_salsa;
        private System.Windows.Forms.TextBox tx_frijoles;
        private System.Windows.Forms.TextBox tx_queso;
        private System.Windows.Forms.TextBox tx_cebolla;
        private System.Windows.Forms.TextBox tx_huevo;
        private System.Windows.Forms.TextBox tx_bebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
>>>>>>> 7b417766a4ba2cdcbe624d35144ec96aa4e1672c
    }
}