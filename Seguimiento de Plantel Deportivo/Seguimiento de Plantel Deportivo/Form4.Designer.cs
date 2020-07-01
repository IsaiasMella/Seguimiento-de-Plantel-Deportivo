namespace Seguimiento_de_Plantel_Deportivo
{
    partial class FLesion
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
            this.GBCargar = new System.Windows.Forms.GroupBox();
            this.MTBTiempoEstimadoDeLesion = new System.Windows.Forms.MaskedTextBox();
            this.MTBdniCarga = new System.Windows.Forms.MaskedTextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.DTPFechaDeInicioLesion = new System.Windows.Forms.DateTimePicker();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.Tlesion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BCargar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBLesion = new System.Windows.Forms.GroupBox();
            this.LBLesion = new System.Windows.Forms.ListBox();
            this.MTBdniBusquedaDeLesion = new System.Windows.Forms.MaskedTextBox();
            this.BBuscarLesion = new System.Windows.Forms.Button();
            this.LJugador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.GBCargar.SuspendLayout();
            this.GBLesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCargar
            // 
            this.GBCargar.Controls.Add(this.MTBTiempoEstimadoDeLesion);
            this.GBCargar.Controls.Add(this.MTBdniCarga);
            this.GBCargar.Controls.Add(this.TNombre);
            this.GBCargar.Controls.Add(this.DTPFechaDeInicioLesion);
            this.GBCargar.Controls.Add(this.TApellido);
            this.GBCargar.Controls.Add(this.Tlesion);
            this.GBCargar.Controls.Add(this.label10);
            this.GBCargar.Controls.Add(this.BBuscar);
            this.GBCargar.Controls.Add(this.BCargar);
            this.GBCargar.Controls.Add(this.label9);
            this.GBCargar.Controls.Add(this.label5);
            this.GBCargar.Controls.Add(this.label8);
            this.GBCargar.Controls.Add(this.label3);
            this.GBCargar.Controls.Add(this.label2);
            this.GBCargar.Controls.Add(this.label1);
            this.GBCargar.Location = new System.Drawing.Point(24, 33);
            this.GBCargar.Name = "GBCargar";
            this.GBCargar.Size = new System.Drawing.Size(347, 229);
            this.GBCargar.TabIndex = 0;
            this.GBCargar.TabStop = false;
            this.GBCargar.Text = "Cargar";
            // 
            // MTBTiempoEstimadoDeLesion
            // 
            this.MTBTiempoEstimadoDeLesion.Location = new System.Drawing.Point(130, 160);
            this.MTBTiempoEstimadoDeLesion.Mask = "99990";
            this.MTBTiempoEstimadoDeLesion.Name = "MTBTiempoEstimadoDeLesion";
            this.MTBTiempoEstimadoDeLesion.Size = new System.Drawing.Size(108, 20);
            this.MTBTiempoEstimadoDeLesion.TabIndex = 3;
            // 
            // MTBdniCarga
            // 
            this.MTBdniCarga.Location = new System.Drawing.Point(130, 19);
            this.MTBdniCarga.Mask = "99,999,999";
            this.MTBdniCarga.Name = "MTBdniCarga";
            this.MTBdniCarga.Size = new System.Drawing.Size(108, 20);
            this.MTBdniCarga.TabIndex = 3;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(130, 48);
            this.TNombre.Name = "TNombre";
            this.TNombre.ReadOnly = true;
            this.TNombre.Size = new System.Drawing.Size(108, 20);
            this.TNombre.TabIndex = 2;
            // 
            // DTPFechaDeInicioLesion
            // 
            this.DTPFechaDeInicioLesion.Location = new System.Drawing.Point(130, 133);
            this.DTPFechaDeInicioLesion.Name = "DTPFechaDeInicioLesion";
            this.DTPFechaDeInicioLesion.Size = new System.Drawing.Size(108, 20);
            this.DTPFechaDeInicioLesion.TabIndex = 3;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(130, 76);
            this.TApellido.Name = "TApellido";
            this.TApellido.ReadOnly = true;
            this.TApellido.Size = new System.Drawing.Size(108, 20);
            this.TApellido.TabIndex = 2;
            // 
            // Tlesion
            // 
            this.Tlesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tlesion.Location = new System.Drawing.Point(130, 106);
            this.Tlesion.Name = "Tlesion";
            this.Tlesion.Size = new System.Drawing.Size(108, 20);
            this.Tlesion.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // BCargar
            // 
            this.BCargar.Location = new System.Drawing.Point(266, 88);
            this.BCargar.Name = "BCargar";
            this.BCargar.Size = new System.Drawing.Size(75, 23);
            this.BCargar.TabIndex = 1;
            this.BCargar.Text = "Cargar";
            this.BCargar.UseVisualStyleBackColor = true;
            this.BCargar.Click += new System.EventHandler(this.BCargar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiempo Estimado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // GBLesion
            // 
            this.GBLesion.Controls.Add(this.LBLesion);
            this.GBLesion.Controls.Add(this.MTBdniBusquedaDeLesion);
            this.GBLesion.Controls.Add(this.BBuscarLesion);
            this.GBLesion.Controls.Add(this.LJugador);
            this.GBLesion.Controls.Add(this.label4);
            this.GBLesion.Location = new System.Drawing.Point(403, 33);
            this.GBLesion.Name = "GBLesion";
            this.GBLesion.Size = new System.Drawing.Size(352, 229);
            this.GBLesion.TabIndex = 0;
            this.GBLesion.TabStop = false;
            this.GBLesion.Text = "Lesión";
            // 
            // LBLesion
            // 
            this.LBLesion.FormattingEnabled = true;
            this.LBLesion.Location = new System.Drawing.Point(33, 88);
            this.LBLesion.Name = "LBLesion";
            this.LBLesion.Size = new System.Drawing.Size(291, 108);
            this.LBLesion.TabIndex = 4;
            this.LBLesion.Visible = false;
            // 
            // MTBdniBusquedaDeLesion
            // 
            this.MTBdniBusquedaDeLesion.Location = new System.Drawing.Point(96, 28);
            this.MTBdniBusquedaDeLesion.Mask = "99,999,999";
            this.MTBdniBusquedaDeLesion.Name = "MTBdniBusquedaDeLesion";
            this.MTBdniBusquedaDeLesion.Size = new System.Drawing.Size(100, 20);
            this.MTBdniBusquedaDeLesion.TabIndex = 3;
            // 
            // BBuscarLesion
            // 
            this.BBuscarLesion.Location = new System.Drawing.Point(249, 27);
            this.BBuscarLesion.Name = "BBuscarLesion";
            this.BBuscarLesion.Size = new System.Drawing.Size(75, 23);
            this.BBuscarLesion.TabIndex = 1;
            this.BBuscarLesion.Text = "Buscar";
            this.BBuscarLesion.UseVisualStyleBackColor = true;
            this.BBuscarLesion.Click += new System.EventHandler(this.BBuscarLesion_Click);
            // 
            // LJugador
            // 
            this.LJugador.AutoSize = true;
            this.LJugador.Location = new System.Drawing.Point(30, 72);
            this.LJugador.Name = "LJugador";
            this.LJugador.Size = new System.Drawing.Size(45, 13);
            this.LJugador.TabIndex = 0;
            this.LJugador.Text = "Jugador";
            this.LJugador.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI";
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(266, 50);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 1;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // FLesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 285);
            this.Controls.Add(this.GBLesion);
            this.Controls.Add(this.GBCargar);
            this.Name = "FLesion";
            this.Text = "Lesión";
            this.GBCargar.ResumeLayout(false);
            this.GBCargar.PerformLayout();
            this.GBLesion.ResumeLayout(false);
            this.GBLesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCargar;
        private System.Windows.Forms.DateTimePicker DTPFechaDeInicioLesion;
        private System.Windows.Forms.TextBox Tlesion;
        private System.Windows.Forms.Button BCargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBLesion;
        private System.Windows.Forms.ListBox LBLesion;
        private System.Windows.Forms.MaskedTextBox MTBdniBusquedaDeLesion;
        private System.Windows.Forms.Button BBuscarLesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTBdniCarga;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LJugador;
        private System.Windows.Forms.MaskedTextBox MTBTiempoEstimadoDeLesion;
        private System.Windows.Forms.Button BBuscar;
    }
}