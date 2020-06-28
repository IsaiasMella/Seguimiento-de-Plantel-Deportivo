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
            this.GBLesion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BMostrarCarga = new System.Windows.Forms.Button();
            this.BMostrarLesion = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.Tlesion = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.DTPFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBLesion = new System.Windows.Forms.ListBox();
            this.GBCargar.SuspendLayout();
            this.GBLesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCargar
            // 
            this.GBCargar.Controls.Add(this.comboBox1);
            this.GBCargar.Controls.Add(this.DTPFechaDeFinalizacion);
            this.GBCargar.Controls.Add(this.DTPFechaDeInicio);
            this.GBCargar.Controls.Add(this.Tlesion);
            this.GBCargar.Controls.Add(this.BAgregar);
            this.GBCargar.Controls.Add(this.BMostrarCarga);
            this.GBCargar.Controls.Add(this.label5);
            this.GBCargar.Controls.Add(this.label3);
            this.GBCargar.Controls.Add(this.label2);
            this.GBCargar.Controls.Add(this.label1);
            this.GBCargar.Location = new System.Drawing.Point(24, 33);
            this.GBCargar.Name = "GBCargar";
            this.GBCargar.Size = new System.Drawing.Size(347, 296);
            this.GBCargar.TabIndex = 0;
            this.GBCargar.TabStop = false;
            this.GBCargar.Text = "Cargar";
            // 
            // GBLesion
            // 
            this.GBLesion.Controls.Add(this.LBLesion);
            this.GBLesion.Controls.Add(this.maskedTextBox1);
            this.GBLesion.Controls.Add(this.TNombre);
            this.GBLesion.Controls.Add(this.TApellido);
            this.GBLesion.Controls.Add(this.BMostrarLesion);
            this.GBLesion.Controls.Add(this.label7);
            this.GBLesion.Controls.Add(this.label6);
            this.GBLesion.Controls.Add(this.label4);
            this.GBLesion.Location = new System.Drawing.Point(403, 33);
            this.GBLesion.Name = "GBLesion";
            this.GBLesion.Size = new System.Drawing.Size(352, 296);
            this.GBLesion.TabIndex = 0;
            this.GBLesion.TabStop = false;
            this.GBLesion.Text = "Lesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Finalizacion";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // BMostrarCarga
            // 
            this.BMostrarCarga.Location = new System.Drawing.Point(253, 50);
            this.BMostrarCarga.Name = "BMostrarCarga";
            this.BMostrarCarga.Size = new System.Drawing.Size(75, 23);
            this.BMostrarCarga.TabIndex = 1;
            this.BMostrarCarga.Text = "Mostrar";
            this.BMostrarCarga.UseVisualStyleBackColor = true;
            // 
            // BMostrarLesion
            // 
            this.BMostrarLesion.Location = new System.Drawing.Point(249, 50);
            this.BMostrarLesion.Name = "BMostrarLesion";
            this.BMostrarLesion.Size = new System.Drawing.Size(75, 23);
            this.BMostrarLesion.TabIndex = 1;
            this.BMostrarLesion.Text = "Mostrar";
            this.BMostrarLesion.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(231, 166);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 1;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // Tlesion
            // 
            this.Tlesion.Location = new System.Drawing.Point(122, 28);
            this.Tlesion.Name = "Tlesion";
            this.Tlesion.Size = new System.Drawing.Size(108, 20);
            this.Tlesion.TabIndex = 2;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(96, 57);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 2;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(96, 85);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 2;
            // 
            // DTPFechaDeInicio
            // 
            this.DTPFechaDeInicio.Location = new System.Drawing.Point(122, 55);
            this.DTPFechaDeInicio.Name = "DTPFechaDeInicio";
            this.DTPFechaDeInicio.Size = new System.Drawing.Size(108, 20);
            this.DTPFechaDeInicio.TabIndex = 3;
            // 
            // DTPFechaDeFinalizacion
            // 
            this.DTPFechaDeFinalizacion.Location = new System.Drawing.Point(122, 82);
            this.DTPFechaDeFinalizacion.Name = "DTPFechaDeFinalizacion";
            this.DTPFechaDeFinalizacion.Size = new System.Drawing.Size(108, 20);
            this.DTPFechaDeFinalizacion.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 28);
            this.maskedTextBox1.Mask = "99.999.999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // LBLesion
            // 
            this.LBLesion.FormattingEnabled = true;
            this.LBLesion.Location = new System.Drawing.Point(33, 146);
            this.LBLesion.Name = "LBLesion";
            this.LBLesion.Size = new System.Drawing.Size(291, 121);
            this.LBLesion.TabIndex = 4;
            // 
            // FLesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker DTPFechaDeFinalizacion;
        private System.Windows.Forms.DateTimePicker DTPFechaDeInicio;
        private System.Windows.Forms.TextBox Tlesion;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BMostrarCarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBLesion;
        private System.Windows.Forms.ListBox LBLesion;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BMostrarLesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}