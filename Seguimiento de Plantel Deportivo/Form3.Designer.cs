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
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DTPFinalizacionDeContrato = new System.Windows.Forms.DateTimePicker();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Finalización:\r\n";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(199, 30);
            this.maskedTextBox1.Mask = "99.999.999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // DTPFinalizacionDeContrato
            // 
            this.DTPFinalizacionDeContrato.Location = new System.Drawing.Point(199, 57);
            this.DTPFinalizacionDeContrato.Name = "DTPFinalizacionDeContrato";
            this.DTPFinalizacionDeContrato.Size = new System.Drawing.Size(200, 20);
            this.DTPFinalizacionDeContrato.TabIndex = 2;
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(505, 19);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 3;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(505, 48);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(75, 23);
            this.BModificar.TabIndex = 3;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(179, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 173);
            this.listBox1.TabIndex = 4;
            // 
            // FContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.DTPFinalizacionDeContrato);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FContratos";
            this.Text = "Contratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker DTPFinalizacionDeContrato;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.ListBox listBox1;
    }
}