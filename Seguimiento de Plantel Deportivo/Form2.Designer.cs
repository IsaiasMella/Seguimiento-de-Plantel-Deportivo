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
            this.BNuevo = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(106, 99);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 1;
            // 
            // MTBdni
            // 
            this.MTBdni.Location = new System.Drawing.Point(106, 66);
            this.MTBdni.Mask = "99.999.99";
            this.MTBdni.Name = "MTBdni";
            this.MTBdni.Size = new System.Drawing.Size(100, 20);
            this.MTBdni.TabIndex = 2;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(106, 133);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 1;
            // 
            // BNuevo
            // 
            this.BNuevo.Location = new System.Drawing.Point(336, 55);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(75, 23);
            this.BNuevo.TabIndex = 3;
            this.BNuevo.Text = "Nuevo";
            this.BNuevo.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(336, 84);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 3;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(336, 113);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 3;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(336, 142);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 3;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // FPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BNuevo);
            this.Controls.Add(this.MTBdni);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FPersonal";
            this.Text = "Personal";
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
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BGuardar;
    }
}