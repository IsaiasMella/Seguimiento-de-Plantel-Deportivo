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
        public List<Persona> parListPersona;
        public List<Lesion> parListLesion;
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
            else
            {
                foreach (Persona unaPersona in parListPersona)
                {

                    if (MTBDni.Text == unaPersona.getDni())
                    {
                        unaPersona.setFechaContratacion(DTPFechaInicio.Value);
                        unaPersona.setPlazoContrato(Duracion());
                        unaPersona.setSueldo(Convert.ToDouble(MTBSueldo.Text));

                    }
                }
                MessageBox.Show("La lesion ya fue cargada", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private int Duracion()
        {
            int Duracion_contrato;
            TimeSpan Dura = DTPFechaFinalizacionContrato_CrearContrato.Value.Date - DTPFechaInicio.Value.Date;

            return Duracion_contrato = Dura.Days;
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (!MTBDni.MaskFull)
            {
                MessageBox.Show("Ingrese DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBDni.Focus();

            }

            else
            {
                GBCrearContratos.Visible = true;
                foreach (Persona unaPersona in parListPersona)

                {
                    if (MTBDni.Text == unaPersona.getDni())
                    {
                        //Guardar en la lista persona
                        LPersona.Text = unaPersona.getNombre() + " " + unaPersona.getApellido();

                    }
                    else
                    {
                        MessageBox.Show("El DNI no se encuentra en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MTBDni.Clear();
                        MTBDni.Focus();

                    }
                }

            }
        }
        private void BConfirmar_Click(object sender, EventArgs e)
        {
            CamposCompletosConfirmar();
            LDuracionDeContrato.Text = "Duración de contrato: " + Convert.ToString(Duracion()) + " dias";
        }
    }
}
