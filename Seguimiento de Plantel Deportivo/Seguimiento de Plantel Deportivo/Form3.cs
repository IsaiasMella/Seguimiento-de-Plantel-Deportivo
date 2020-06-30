using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguimiento_de_Plantel_Deportivo
{
    public partial class FContratos : Form
    {
        public FContratos()
        {
            InitializeComponent();
        }
        private void CamposCompletosConfirmar()
        {
            if (DTPFechaInicio.Value < DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha de inicio válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DTPFechaInicio.Value > DTPFechaFinalizacionContrato_CrearContrato.Value)
            {
                MessageBox.Show("Ingrese una fecha de finalización válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!MTBSueldo.MaskFull)
            {
                MessageBox.Show("Ingrese sueldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBSueldo.Focus();
            }
        }

        private int Duracion()
        {
            int Duracion_contrato;
            Duracion_contrato = Convert.ToInt32(DTPFechaFinalizacionContrato_CrearContrato.Value - DTPFechaInicio.Value);
            return Duracion_contrato;
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (!MTBDni.MaskFull)
            {
                MessageBox.Show("Ingrese DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBDni.Focus();
            }
            /*else foreach (int _dni in < NombreDeLaLista >.dni)
            {
                {
                    if (MTBDni.Text == < NombreDeLaLista >.Dni)
                    {
                       //Guardar en la lista persona
                       LPersona.Text = < NombreDeLaLista >.Nombre + < NombreDeLaLista >.Apellido;
                    }
                    else
                    {
                       MessageBox.Show("El DNI no se encuentra en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       MTBDni.Clear();
                       MTBDni.Focus();

                    }
                }

            }*/
        }
        private void BConfirmar_Click(object sender, EventArgs e)
        {
            CamposCompletosConfirmar();
            LDuracionDeContrato.Text = "Duración de contrato: " + Convert.ToString(Duracion()) + " años";
        }
    }
}
