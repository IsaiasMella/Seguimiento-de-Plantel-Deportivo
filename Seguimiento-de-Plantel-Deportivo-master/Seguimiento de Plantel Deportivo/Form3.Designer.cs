namespace Seguimiento_de_Plantel_Deportivo
{
    partial class FContratos
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BConfirmar = new System.Windows.Forms.Button();
            this.LPersona = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.MTBSueldo = new System.Windows.Forms.MaskedTextBox();
            this.DTPFechaFinalizacionContrato_CrearContrato = new System.Windows.Forms.DateTimePicker();
            this.LDuracionDeContrato = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(130, 27);
            this.maskedTextBox1.Mask = "99.999.999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(130, 61);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(75, 23);
            this.BModificar.TabIndex = 3;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BModificar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LDuracionDeContrato);
            this.groupBox2.Controls.Add(this.BConfirmar);
            this.groupBox2.Controls.Add(this.DTPFechaInicio);
            this.groupBox2.Controls.Add(this.DTPFechaFinalizacionContrato_CrearContrato);
            this.groupBox2.Controls.Add(this.LPersona);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MTBSueldo);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Contrato";
            this.groupBox2.Visible = false;
            // 
            // BConfirmar
            // 
            this.BConfirmar.Location = new System.Drawing.Point(115, 189);
            this.BConfirmar.Name = "BConfirmar";
            this.BConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BConfirmar.TabIndex = 3;
            this.BConfirmar.Text = "Confirmar";
            this.BConfirmar.UseVisualStyleBackColor = true;
            // 
            // LPersona
            // 
            this.LPersona.AutoSize = true;
            this.LPersona.Location = new System.Drawing.Point(159, 26);
            this.LPersona.Name = "LPersona";
            this.LPersona.Size = new System.Drawing.Size(46, 13);
            this.LPersona.TabIndex = 0;
            this.LPersona.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Finalización:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Inicio:";
            // 
            // DTPFechaInicio
            // 
            this.DTPFechaInicio.Location = new System.Drawing.Point(115, 56);
            this.DTPFechaInicio.Name = "DTPFechaInicio";
            this.DTPFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaInicio.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sueldo:";
            // 
            // MTBSueldo
            // 
            this.MTBSueldo.Location = new System.Drawing.Point(115, 122);
            this.MTBSueldo.Mask = "000,099,999.00";
            this.MTBSueldo.Name = "MTBSueldo";
            this.MTBSueldo.Size = new System.Drawing.Size(100, 20);
            this.MTBSueldo.TabIndex = 1;
            // 
            // DTPFechaFinalizacionContrato_CrearContrato
            // 
            this.DTPFechaFinalizacionContrato_CrearContrato.Location = new System.Drawing.Point(115, 88);
            this.DTPFechaFinalizacionContrato_CrearContrato.Name = "DTPFechaFinalizacionContrato_CrearContrato";
            this.DTPFechaFinalizacionContrato_CrearContrato.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaFinalizacionContrato_CrearContrato.TabIndex = 2;
            // 
            // LDuracionDeContrato
            // 
            this.LDuracionDeContrato.AutoSize = true;
            this.LDuracionDeContrato.Location = new System.Drawing.Point(80, 158);
            this.LDuracionDeContrato.Name = "LDuracionDeContrato";
            this.LDuracionDeContrato.Size = new System.Drawing.Size(111, 13);
            this.LDuracionDeContrato.TabIndex = 4;
            this.LDuracionDeContrato.Text = "Duración de Contrato:";
            // 
            // FContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FContratos";
            this.Text = "Contratos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LDuracionDeContrato;
        private System.Windows.Forms.Button BConfirmar;
        private System.Windows.Forms.DateTimePicker DTPFechaInicio;
        private System.Windows.Forms.DateTimePicker DTPFechaFinalizacionContrato_CrearContrato;
        private System.Windows.Forms.Label LPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTBSueldo;
    }
}