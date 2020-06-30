namespace Seguimiento_de_Plantel_Deportivo
{
    partial class FPersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.MTBdni = new System.Windows.Forms.MaskedTextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TNacionalidad = new System.Windows.Forms.TextBox();
            this.MTBTelefono = new System.Windows.Forms.MaskedTextBox();
            this.GBSexo = new System.Windows.Forms.GroupBox();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.DTPFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.GBProfesion = new System.Windows.Forms.GroupBox();
            this.RBJugador = new System.Windows.Forms.RadioButton();
            this.RBCuerpoTecnico = new System.Windows.Forms.RadioButton();
            this.GBJugador = new System.Windows.Forms.GroupBox();
            this.GBCuerpoTecnico = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TCargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CBPiernaHabil = new System.Windows.Forms.ComboBox();
            this.CBPosicion = new System.Windows.Forms.ComboBox();
            this.NUDDorsal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BContrato = new System.Windows.Forms.Button();
            this.GBSexo.SuspendLayout();
            this.GBProfesion.SuspendLayout();
            this.GBJugador.SuspendLayout();
            this.GBCuerpoTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDorsal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(126, 53);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 1;
            // 
            // MTBdni
            // 
            this.MTBdni.Location = new System.Drawing.Point(127, 19);
            this.MTBdni.Mask = "99,999,999";
            this.MTBdni.Name = "MTBdni";
            this.MTBdni.Size = new System.Drawing.Size(100, 20);
            this.MTBdni.TabIndex = 2;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(126, 87);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 1;
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(352, 225);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 3;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(514, 225);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 3;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(433, 225);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 3;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(126, 192);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(100, 20);
            this.TDomicilio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nacionalidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // TNacionalidad
            // 
            this.TNacionalidad.Location = new System.Drawing.Point(126, 118);
            this.TNacionalidad.Name = "TNacionalidad";
            this.TNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.TNacionalidad.TabIndex = 4;
            // 
            // MTBTelefono
            // 
            this.MTBTelefono.Location = new System.Drawing.Point(126, 152);
            this.MTBTelefono.Mask = "+99-999-999990000";
            this.MTBTelefono.Name = "MTBTelefono";
            this.MTBTelefono.Size = new System.Drawing.Size(100, 20);
            this.MTBTelefono.TabIndex = 2;
            // 
            // GBSexo
            // 
            this.GBSexo.Controls.Add(this.RBMasculino);
            this.GBSexo.Controls.Add(this.RBFemenino);
            this.GBSexo.Location = new System.Drawing.Point(271, 113);
            this.GBSexo.Name = "GBSexo";
            this.GBSexo.Size = new System.Drawing.Size(200, 69);
            this.GBSexo.TabIndex = 5;
            this.GBSexo.TabStop = false;
            this.GBSexo.Text = "Sexo";
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Location = new System.Drawing.Point(19, 32);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(73, 17);
            this.RBMasculino.TabIndex = 0;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            this.RBFemenino.AutoSize = true;
            this.RBFemenino.Location = new System.Drawing.Point(111, 32);
            this.RBFemenino.Name = "RBFemenino";
            this.RBFemenino.Size = new System.Drawing.Size(71, 17);
            this.RBFemenino.TabIndex = 0;
            this.RBFemenino.TabStop = true;
            this.RBFemenino.Text = "Femenino";
            this.RBFemenino.UseVisualStyleBackColor = true;
            // 
            // DTPFechaDeNacimiento
            // 
            this.DTPFechaDeNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPFechaDeNacimiento.Location = new System.Drawing.Point(37, 246);
            this.DTPFechaDeNacimiento.Name = "DTPFechaDeNacimiento";
            this.DTPFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaDeNacimiento.TabIndex = 6;
            // 
            // GBProfesion
            // 
            this.GBProfesion.Controls.Add(this.RBJugador);
            this.GBProfesion.Controls.Add(this.RBCuerpoTecnico);
            this.GBProfesion.Location = new System.Drawing.Point(271, 34);
            this.GBProfesion.Name = "GBProfesion";
            this.GBProfesion.Size = new System.Drawing.Size(200, 73);
            this.GBProfesion.TabIndex = 7;
            this.GBProfesion.TabStop = false;
            this.GBProfesion.Text = "Profesion";
            // 
            // RBJugador
            // 
            this.RBJugador.AutoSize = true;
            this.RBJugador.Location = new System.Drawing.Point(19, 31);
            this.RBJugador.Name = "RBJugador";
            this.RBJugador.Size = new System.Drawing.Size(63, 17);
            this.RBJugador.TabIndex = 0;
            this.RBJugador.TabStop = true;
            this.RBJugador.Text = "Jugador";
            this.RBJugador.UseVisualStyleBackColor = true;
            // 
            // RBCuerpoTecnico
            // 
            this.RBCuerpoTecnico.AutoSize = true;
            this.RBCuerpoTecnico.Location = new System.Drawing.Point(93, 31);
            this.RBCuerpoTecnico.Name = "RBCuerpoTecnico";
            this.RBCuerpoTecnico.Size = new System.Drawing.Size(101, 17);
            this.RBCuerpoTecnico.TabIndex = 0;
            this.RBCuerpoTecnico.TabStop = true;
            this.RBCuerpoTecnico.Text = "Cuerpo Técnico";
            this.RBCuerpoTecnico.UseVisualStyleBackColor = true;
            // 
            // GBJugador
            // 
            this.GBJugador.Controls.Add(this.CBPiernaHabil);
            this.GBJugador.Controls.Add(this.CBPosicion);
            this.GBJugador.Controls.Add(this.NUDDorsal);
            this.GBJugador.Controls.Add(this.label11);
            this.GBJugador.Controls.Add(this.label10);
            this.GBJugador.Controls.Add(this.label9);
            this.GBJugador.Controls.Add(this.label8);
            this.GBJugador.Location = new System.Drawing.Point(504, 47);
            this.GBJugador.Name = "GBJugador";
            this.GBJugador.Size = new System.Drawing.Size(238, 125);
            this.GBJugador.TabIndex = 8;
            this.GBJugador.TabStop = false;
            this.GBJugador.Text = "Jugador";
            this.GBJugador.Visible = false;
            // 
            // GBCuerpoTecnico
            // 
            this.GBCuerpoTecnico.Controls.Add(this.textBox1);
            this.GBCuerpoTecnico.Controls.Add(this.TCargo);
            this.GBCuerpoTecnico.Controls.Add(this.label13);
            this.GBCuerpoTecnico.Controls.Add(this.label12);
            this.GBCuerpoTecnico.Location = new System.Drawing.Point(779, 56);
            this.GBCuerpoTecnico.Name = "GBCuerpoTecnico";
            this.GBCuerpoTecnico.Size = new System.Drawing.Size(238, 122);
            this.GBCuerpoTecnico.TabIndex = 8;
            this.GBCuerpoTecnico.TabStop = false;
            this.GBCuerpoTecnico.Text = "Cuerpo Técnico";
            this.GBCuerpoTecnico.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TCargo
            // 
            this.TCargo.Location = new System.Drawing.Point(92, 26);
            this.TCargo.Name = "TCargo";
            this.TCargo.Size = new System.Drawing.Size(100, 20);
            this.TCargo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Especialidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cargo";
            // 
            // CBPiernaHabil
            // 
            this.CBPiernaHabil.FormattingEnabled = true;
            this.CBPiernaHabil.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda"});
            this.CBPiernaHabil.Location = new System.Drawing.Point(87, 84);
            this.CBPiernaHabil.Name = "CBPiernaHabil";
            this.CBPiernaHabil.Size = new System.Drawing.Size(121, 21);
            this.CBPiernaHabil.TabIndex = 2;
            // 
            // CBPosicion
            // 
            this.CBPosicion.FormattingEnabled = true;
            this.CBPosicion.Items.AddRange(new object[] {
            "Arquero",
            "Defensor",
            "Mediocampista",
            "Delantero"});
            this.CBPosicion.Location = new System.Drawing.Point(87, 48);
            this.CBPosicion.Name = "CBPosicion";
            this.CBPosicion.Size = new System.Drawing.Size(121, 21);
            this.CBPosicion.TabIndex = 2;
            // 
            // NUDDorsal
            // 
            this.NUDDorsal.Location = new System.Drawing.Point(87, 18);
            this.NUDDorsal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUDDorsal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDDorsal.Name = "NUDDorsal";
            this.NUDDorsal.Size = new System.Drawing.Size(44, 20);
            this.NUDDorsal.TabIndex = 1;
            this.NUDDorsal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Posición";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pierna Habil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Posición";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dorsal";
            // 
            // BContrato
            // 
            this.BContrato.Location = new System.Drawing.Point(595, 225);
            this.BContrato.Name = "BContrato";
            this.BContrato.Size = new System.Drawing.Size(75, 23);
            this.BContrato.TabIndex = 3;
            this.BContrato.Text = "Contrato";
            this.BContrato.UseVisualStyleBackColor = true;
            this.BContrato.Click += new System.EventHandler(this.BContrato_Click);
            // 
            // FPersonal
            // 
            this.AcceptButton = this.BGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 287);
            this.Controls.Add(this.GBCuerpoTecnico);
            this.Controls.Add(this.GBJugador);
            this.Controls.Add(this.GBProfesion);
            this.Controls.Add(this.DTPFechaDeNacimiento);
            this.Controls.Add(this.GBSexo);
            this.Controls.Add(this.TNacionalidad);
            this.Controls.Add(this.TDomicilio);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BContrato);
            this.Controls.Add(this.MTBTelefono);
            this.Controls.Add(this.MTBdni);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FPersonal";
            this.Text = "Personal";
            this.GBSexo.ResumeLayout(false);
            this.GBSexo.PerformLayout();
            this.GBProfesion.ResumeLayout(false);
            this.GBProfesion.PerformLayout();
            this.GBJugador.ResumeLayout(false);
            this.GBJugador.PerformLayout();
            this.GBCuerpoTecnico.ResumeLayout(false);
            this.GBCuerpoTecnico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDorsal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.MaskedTextBox MTBdni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TNacionalidad;
        private System.Windows.Forms.MaskedTextBox MTBTelefono;
        private System.Windows.Forms.GroupBox GBSexo;
        private System.Windows.Forms.RadioButton RBMasculino;
        private System.Windows.Forms.RadioButton RBFemenino;
        private System.Windows.Forms.DateTimePicker DTPFechaDeNacimiento;
        private System.Windows.Forms.GroupBox GBProfesion;
        private System.Windows.Forms.RadioButton RBJugador;
        private System.Windows.Forms.RadioButton RBCuerpoTecnico;
        private System.Windows.Forms.GroupBox GBJugador;
        private System.Windows.Forms.GroupBox GBCuerpoTecnico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBPiernaHabil;
        private System.Windows.Forms.ComboBox CBPosicion;
        private System.Windows.Forms.NumericUpDown NUDDorsal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BContrato;
    }
}