using Microsoft.CSharp.RuntimeBinder;
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
    public partial class FPersonal : Form
    {
        public List<Persona> parListPersona;


        public FPersonal()
        {
            InitializeComponent();           
        }
        private void Campos_Completos()
        {
            string sexo;            
            if (!MTBdni.MaskFull)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBdni.Focus();
            }
            else if (TNombre.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNombre.Focus();
            }
            else if (TApellido.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TApellido.Focus();
            }
            else if (TNacionalidad.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNacionalidad.Focus();
            }
            if (!MTBTelefono.MaskFull)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBTelefono.Focus();
            }
            else if (TDomicilio.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TDomicilio.Focus();
            }
            else if (DTPFechaDeNacimiento.Value >= DateTime.Today)
            {
                MessageBox.Show("Ingrese una Fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPFechaDeNacimiento.Focus();
            }
            else if ((!RBJugador.Checked) && (!RBCuerpoTecnico.Checked))
            {
                MessageBox.Show("Indicar la profesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((!RBMasculino.Checked) && (!RBFemenino.Checked))
            {
                MessageBox.Show("Indicar el Sexo de la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (RBMasculino.Checked)
            {
                sexo = RBMasculino.Text;
            }
            else if (RBFemenino.Checked)
            {
                sexo = RBFemenino.Text;
            }
            if (RBJugador.Checked == true)
            {              
                if ((NUDDorsal.Value < 1) && (NUDDorsal.Value > 99))
                {
                    MessageBox.Show("Dorsal fuera de Rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NUDDorsal.Focus();
                }
                else if ((CBPosicion.SelectedIndex < 0) || (CBPosicion.SelectedIndex > 3))
                {
                    MessageBox.Show("Seleccione la Posicion del Jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CBPosicion.Focus();
                }
                else if ((CBPiernaHabil.SelectedIndex < 0) || (CBPiernaHabil.SelectedIndex > 1))
                {
                    MessageBox.Show("Seleccione la Pierna Habil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CBPiernaHabil.Focus();
                }
                //guarda en la lista todo respecto al jugador
                else
                {
                    Repetido();          
                }
            }
            if (RBCuerpoTecnico.Checked == true)
            {
                if (TCargo.Text == "")
                {
                    MessageBox.Show("Seleccione el Cargo que ocupa en el Cuerpo Tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TCargo.Focus();
                }
                if (TEspecialidad.Text == "")
                {
                    MessageBox.Show("Seleccione la Especialidad ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TEspecialidad.Focus();
                }
                //guarda en la lista todo respecto al Cuerpo Tecnico
                else
                {
                    Repetido();
                }
            }            
        }

        private void Carga()
        {
          
            foreach (Jugador nuevo in parListPersona)
            {
                #region Agregar Nuevos Items a la Lista
                //parListPersona.Add(Convert.ToInt32(MTBdni.Text));
                #endregion
            }
            
        }
        private void Repetido()
        {
            foreach (int Dni in parListPersona.Dni )
            {
                if (MTBdni.Text == parListPersona.Dni)
                {
                    MessageBox.Show("Dni repetdio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MTBdni.Focus();
                }
                else
                {
                    Carga();
                }
            }
        }       
        private void BGuardar_Click(object sender, EventArgs e)
        {
            Campos_Completos();
        }

        private void BContrato_Click(object sender, EventArgs e)
        {
            FContratos FormContratos = new FContratos();           
            FormContratos.Show();
        }

        private void RBJugador_CheckedChanged(object sender, EventArgs e)
        {
            GBJugador.Visible = true;
            GBCuerpoTecnico.Visible = false;
        }

        private void RBCuerpoTecnico_CheckedChanged(object sender, EventArgs e)
        {
            GBCuerpoTecnico.Visible = true;
            GBJugador.Visible = false;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
           /* if (!MTBdni.MaskFull)
            {
                MessageBox.Show("Ingrese DNI para buscar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBdni.Focus();
            }
            else foreach (int _dni in < NombreDeLaLista>.Dni)
            {
                 {
                      if (MTBdni.Text == < NombreDeLaLista >.Dni)
                      {
                            TNombre.Text = < NombreDeLaLista >.Nombre;
                            TApellido.Text = < NombreDeLaLista >.Apellido;
                            TNacionalidad.Text = < NombreDeLaLista >.Nacionalidad;
                            MTBTelefono.Text = < NombreDeLaLista >.Telefono;
                            TDomicilio.Text = < NombreDeLaLista >.Telefono;
                            DTPFechaDeNacimiento.Value = < NombreDeLaLista >.DTPFechaDeNacimiento;
                            RBMasculino.Checked = < NombreDeLaLista > .SexoMasculino;
                            RBFemenino.Checked = < NombreDeLaLista > .SexoFemenino;
                            RBCuerpoTecnico.Checked = < NombreDeLaLista > .CuerpoTecnico;
                            RBJugador.Checked = < NombreDeLaLista > .Jugador;
                            if (RBJugador.Checked)
                            {
                                NUDDorsal.Value = < NombreDeLaLista > .Dorsal;
                                CBPosicion.SelectedIndex = < NombreDeLaLista > .Posicion;
                                CBPiernaHabil.SelectedIndex = < NombreDeLaLista > .PiernaHabil;
                            }
                            if (RBCuerpoTecnico.Checked)
                            {
                                TCargo.Text = < NombreDeLaLista > .Cargo;
                                TEspecialidad.Text = < NombreDeLaLista > .Especialidad;
                            }
                      }
                 }
                
            }  */          
        }
        // Falta hacer boton eliminar
        private void BEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
