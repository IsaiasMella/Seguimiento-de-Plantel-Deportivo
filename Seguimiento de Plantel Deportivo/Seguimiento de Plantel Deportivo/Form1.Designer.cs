﻿namespace Seguimiento_de_Plantel_Deportivo
{
    partial class FSeguimientoDePlantelDepo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBPiernaHabil = new System.Windows.Forms.ComboBox();
            this.LBJugadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBJugador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BBuscarJugador = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BBuscarLesion = new System.Windows.Forms.Button();
            this.LBLesiones = new System.Windows.Forms.ListBox();
            this.CBLesion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BBuscarContratos = new System.Windows.Forms.Button();
            this.LBContratos = new System.Windows.Forms.ListBox();
            this.CBContratos = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.lesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // lesiónToolStripMenuItem
            // 
            this.lesiónToolStripMenuItem.Name = "lesiónToolStripMenuItem";
            this.lesiónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lesiónToolStripMenuItem.Text = "Lesión";
            this.lesiónToolStripMenuItem.Click += new System.EventHandler(this.lesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // CBPiernaHabil
            // 
            this.CBPiernaHabil.FormattingEnabled = true;
            this.CBPiernaHabil.Items.AddRange(new object[] {
            "Todos",
            "Derecha",
            "Izquierda"});
            this.CBPiernaHabil.Location = new System.Drawing.Point(26, 83);
            this.CBPiernaHabil.Name = "CBPiernaHabil";
            this.CBPiernaHabil.Size = new System.Drawing.Size(150, 21);
            this.CBPiernaHabil.TabIndex = 1;
            // 
            // LBJugadores
            // 
            this.LBJugadores.BackColor = System.Drawing.SystemColors.Window;
            this.LBJugadores.FormattingEnabled = true;
            this.LBJugadores.Location = new System.Drawing.Point(26, 139);
            this.LBJugadores.Name = "LBJugadores";
            this.LBJugadores.Size = new System.Drawing.Size(150, 160);
            this.LBJugadores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Posicion";
            // 
            // CBJugador
            // 
            this.CBJugador.FormattingEnabled = true;
            this.CBJugador.Items.AddRange(new object[] {
            "Todos",
            "Arquero",
            "Defensor",
            "Mediocampista",
            "Delantero"});
            this.CBJugador.Location = new System.Drawing.Point(26, 43);
            this.CBJugador.Name = "CBJugador";
            this.CBJugador.Size = new System.Drawing.Size(150, 21);
            this.CBJugador.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pierna Habil";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BBuscarJugador);
            this.groupBox1.Controls.Add(this.LBJugadores);
            this.groupBox1.Controls.Add(this.CBJugador);
            this.groupBox1.Controls.Add(this.CBPiernaHabil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores";
            // 
            // BBuscarJugador
            // 
            this.BBuscarJugador.Location = new System.Drawing.Point(62, 110);
            this.BBuscarJugador.Name = "BBuscarJugador";
            this.BBuscarJugador.Size = new System.Drawing.Size(75, 23);
            this.BBuscarJugador.TabIndex = 5;
            this.BBuscarJugador.Text = "Buscar";
            this.BBuscarJugador.UseVisualStyleBackColor = true;
            this.BBuscarJugador.Click += new System.EventHandler(this.BBuscarJugador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BBuscarLesion);
            this.groupBox2.Controls.Add(this.LBLesiones);
            this.groupBox2.Controls.Add(this.CBLesion);
            this.groupBox2.Location = new System.Drawing.Point(218, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 316);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lesion";
            // 
            // BBuscarLesion
            // 
            this.BBuscarLesion.Location = new System.Drawing.Point(64, 70);
            this.BBuscarLesion.Name = "BBuscarLesion";
            this.BBuscarLesion.Size = new System.Drawing.Size(75, 23);
            this.BBuscarLesion.TabIndex = 5;
            this.BBuscarLesion.Text = "Buscar";
            this.BBuscarLesion.UseVisualStyleBackColor = true;
            this.BBuscarLesion.Click += new System.EventHandler(this.BBuscarLesion_Click);
            // 
            // LBLesiones
            // 
            this.LBLesiones.FormattingEnabled = true;
            this.LBLesiones.Location = new System.Drawing.Point(29, 139);
            this.LBLesiones.Name = "LBLesiones";
            this.LBLesiones.Size = new System.Drawing.Size(150, 160);
            this.LBLesiones.TabIndex = 2;
            // 
            // CBLesion
            // 
            this.CBLesion.FormattingEnabled = true;
            this.CBLesion.Items.AddRange(new object[] {
            "Todos",
            "Arqueros",
            "Defensores",
            "Mediocampistas",
            "Delanteros"});
            this.CBLesion.Location = new System.Drawing.Point(42, 43);
            this.CBLesion.Name = "CBLesion";
            this.CBLesion.Size = new System.Drawing.Size(121, 21);
            this.CBLesion.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BBuscarContratos);
            this.groupBox3.Controls.Add(this.LBContratos);
            this.groupBox3.Controls.Add(this.CBContratos);
            this.groupBox3.Location = new System.Drawing.Point(424, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 316);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contratos";
            // 
            // BBuscarContratos
            // 
            this.BBuscarContratos.Location = new System.Drawing.Point(64, 70);
            this.BBuscarContratos.Name = "BBuscarContratos";
            this.BBuscarContratos.Size = new System.Drawing.Size(75, 23);
            this.BBuscarContratos.TabIndex = 5;
            this.BBuscarContratos.Text = "Buscar";
            this.BBuscarContratos.UseVisualStyleBackColor = true;
            this.BBuscarContratos.Click += new System.EventHandler(this.BBuscarContratos_Click);
            // 
            // LBContratos
            // 
            this.LBContratos.FormattingEnabled = true;
            this.LBContratos.Location = new System.Drawing.Point(29, 139);
            this.LBContratos.Name = "LBContratos";
            this.LBContratos.Size = new System.Drawing.Size(625, 160);
            this.LBContratos.TabIndex = 2;
            // 
            // CBContratos
            // 
            this.CBContratos.FormattingEnabled = true;
            this.CBContratos.Items.AddRange(new object[] {
            "Todos",
            "Jugadores",
            "Cuerpo Técnico"});
            this.CBContratos.Location = new System.Drawing.Point(42, 43);
            this.CBContratos.Name = "CBContratos";
            this.CBContratos.Size = new System.Drawing.Size(121, 21);
            this.CBContratos.TabIndex = 4;
            // 
            // FSeguimientoDePlantelDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 356);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSeguimientoDePlantelDepo";
            this.Text = "Seguimiento del Plantel";
            this.Load += new System.EventHandler(this.FSeguimientoDePlantelDepo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBPiernaHabil;
        private System.Windows.Forms.ListBox LBJugadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BBuscarJugador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BBuscarLesion;
        private System.Windows.Forms.ListBox LBLesiones;
        private System.Windows.Forms.ComboBox CBLesion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BBuscarContratos;
        private System.Windows.Forms.ListBox LBContratos;
        private System.Windows.Forms.ComboBox CBContratos;
    }
}

