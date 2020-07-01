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
            MessageBox.Show("Entro a Carga");
            Jugador NuevoJugador = new Jugador(MTBdni.Text, TNombre.Text, TApellido.Text, TDomicilio.Text, MTBTelefono.Text, TNacionalidad.Text, DTPFechaDeNacimiento.Value, RBMasculino.Text, NUDDorsal.Value, CBPosicion.Text, CBPiernaHabil.Text);
            parListPersona.Add(NuevoJugador);
            MTBdni.Clear();
            TNombre.Clear();
            TApellido.Clear();
        }
        private void Repetido()
        {
            MessageBox.Show("Entro a Repetido");
            foreach (Persona nuevo in parListPersona)
            {
                if (MTBdni.Text == Convert.ToString(nuevo.getDni()))
                {
                    MessageBox.Show("Dni repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MTBdni.Focus();
                }

            }
            Carga();
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
            if (!MTBdni.MaskFull)
            {
                MessageBox.Show("Ingrese DNI para buscar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBdni.Focus();
            }
            else
                foreach (Jugador unPersona in parListPersona)
                {
                    if (MTBdni.Text == unPersona.getDni())
                    {
                        TNombre.Text = unPersona.getNombre();
                        TApellido.Text = unPersona.getApellido();
                        TNacionalidad.Text = unPersona.getNacionalidad();
                        MTBTelefono.Text = unPersona.getTelefono();
                        TDomicilio.Text = unPersona.getDomicilio();
                        DTPFechaDeNacimiento.Value = unPersona.getFechaNac();
                        if (unPersona.getSexo() == "Masculino")
                        { RBMasculino.Checked = true; }
                        else
                        { RBFemenino.Checked = true; }

                        RBJugador.Checked = true;
                        NUDDorsal.Value = unPersona.getDorsal();
                        CBPosicion.Text = unPersona.getPosicion();
                        CBPiernaHabil.Text = unPersona.getPierna_Habil();
                    }
                    //RBCuerpoTecnico.Checked = < NombreDeLaLista > .CuerpoTecnico;
                    //RBJugador.Checked = < NombreDeLaLista > .Jugador;
                    //if (RBJugador.Checked)
                    //{
                    //    NUDDorsal.Value = < NombreDeLaLista > .Dorsal;
                    //    CBPosicion.SelectedIndex = < NombreDeLaLista > .Posicion;
                    //    CBPiernaHabil.SelectedIndex = < NombreDeLaLista > .PiernaHabil;
                    //}
                    //if (RBCuerpoTecnico.Checked)
                    //{
                    //    TCargo.Text = < NombreDeLaLista > .Cargo;
                    //    TEspecialidad.Text = < NombreDeLaLista > .Especialidad;
                    //}



                }

        }
        // Falta hacer boton eliminar
        private void BEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
