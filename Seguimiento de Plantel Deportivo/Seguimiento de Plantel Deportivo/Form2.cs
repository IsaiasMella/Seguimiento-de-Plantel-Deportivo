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
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\FondoParaForm2.jpg");
            this.BackgroundImage = img;
        }
        private void Campos_Obligatorios_Completos()
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
                    MessageBox.Show("Dorsal fuera de Rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NUDDorsal.Focus();
                }
                else if ((CBPosicion.SelectedIndex < 0) || (CBPosicion.SelectedIndex > 3))
                {
                    MessageBox.Show("Seleccione la Posicion del Jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBPosicion.Focus();
                }
                else if ((CBPiernaHabil.SelectedIndex < 0) || (CBPiernaHabil.SelectedIndex > 1))
                {
                    MessageBox.Show("Seleccione la Pierna Habil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBPiernaHabil.Focus();
                }                
                else
                {
                    Campos_Opcionales();                     
                }
            }
            if (RBCuerpoTecnico.Checked == true)
            {
                if (TCargo.Text == "")
                {
                    MessageBox.Show("Seleccione el Cargo que ocupa en el Cuerpo Tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TCargo.Focus();
                }
                if (TEspecialidad.Text == "")
                {
                    MessageBox.Show("Seleccione la Especialidad ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TEspecialidad.Focus();
                }
                else
                {
                    Campos_Opcionales();                   
                }
            }            
        }

        private void Campos_Opcionales()
        {
            bool carg;
            carg = true ;
            if ((TNacionalidad.Text == "") ||(MTBTelefono.Text == "")||(TDomicilio.Text == ""))
            {
               DialogResult = MessageBox.Show("Hay campos vacios \n¿Desea continuar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.Yes)
                {
                    carg = true;
                }
                //este es el problema
                else if (DialogResult == DialogResult.No)
                {
                    if (TNacionalidad.Text == "")
                    {
                        TNacionalidad.Focus();                        
                    }
                    else if (!MTBTelefono.MaskFull)
                    {
                        MTBTelefono.Focus();
                    }
                    else if (TDomicilio.Text == "")
                    {
                        TDomicilio.Focus();
                    }
                    carg = false;
                }
            }
            if (carg == true)
            {
                    Repetido();    
            }
        }

        private void CargaJugador()
        {           
            MessageBox.Show("Entro a Carga");
            Jugador NuevoJugador = new Jugador(MTBdni.Text, TNombre.Text, TApellido.Text, TDomicilio.Text, MTBTelefono.Text, TNacionalidad.Text, DTPFechaDeNacimiento.Value, RBMasculino.Text, NUDDorsal.Value, CBPosicion.Text, CBPiernaHabil.Text);
            parListPersona.Add(NuevoJugador);
            MTBdni.Clear();
            TNombre.Clear();
            TApellido.Clear();
        }

        private void CargaCuerpo_Tecnico()
        {
            MessageBox.Show("Entro a Carga CuerpoTecnico");

            Cuerpo_Tecnico NuevoCuerpoTecnico = new Cuerpo_Tecnico(MTBdni.Text, TNombre.Text, TApellido.Text, TDomicilio.Text, MTBTelefono.Text, TNacionalidad.Text, DTPFechaDeNacimiento.Value, RBMasculino.Text, TCargo.Text, TEspecialidad.Text);
            parListPersona.Add(NuevoCuerpoTecnico);
            MTBdni.Clear();
            TNombre.Clear();
            TApellido.Clear();
        }

        private void Repetido()
        {
            int i;
            bool carg;           
            carg = true;
            foreach (Persona nuevo in parListPersona)
            {
                if (MTBdni.Text == Convert.ToString(nuevo.getDni()))
                {
                    DialogResult = MessageBox.Show("Dni repetido \n¿Desea Guardar Cambios?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        if (RBJugador.Checked == true)
                        {
                            Jugador NuevoJugador = new Jugador(MTBdni.Text, TNombre.Text, TApellido.Text, TDomicilio.Text, MTBTelefono.Text, TNacionalidad.Text, DTPFechaDeNacimiento.Value, RBMasculino.Text, NUDDorsal.Value, CBPosicion.Text, CBPiernaHabil.Text);                            
                            i = parListPersona.IndexOf(nuevo);
                            parListPersona.Insert(i, NuevoJugador);
                            carg = false;
                        }
                        else
                        {
                            Cuerpo_Tecnico NuevoCT = new Cuerpo_Tecnico(MTBdni.Text, TNombre.Text, TApellido.Text, TDomicilio.Text, MTBTelefono.Text, TNacionalidad.Text, DTPFechaDeNacimiento.Value, RBMasculino.Text, TCargo.Text, TEspecialidad.Text);
                            i = parListPersona.IndexOf(nuevo);
                            parListPersona.Insert(i, NuevoCT);
                            carg = false;
                        }
                    }
                    else
                    {
                        carg = false;
                    }
                }
            }  
            foreach (Jugador UnJugador in parListPersona)
            {
                if (UnJugador.getDorsal() == NUDDorsal.Value )
                {
                    MessageBox.Show("No se pueden cargar jugadores con el mismo Dorsal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carg = false;
                }
            }
            if (carg == true)
            {
                if (RBJugador.Checked == true)
                {
                    CargaJugador();
                }
                else
                {
                    CargaCuerpo_Tecnico();
                }
            }                                            
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            Campos_Obligatorios_Completos();           
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
            // se fija si esta completo el campo del DNI
            if (!MTBdni.MaskFull)
            {
                MessageBox.Show("Ingrese DNI para buscar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTBdni.Focus();
            }
            else
            //Busca en la lista de Jugador si coincide el DNI
            foreach (Persona Personal in parListPersona)
            {
                    if (Personal is Jugador)
                    {
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
                        }
                    }
                    else
                    {
                        //Busca en la lista de cuerpo tecnico si coincide el DNI
                        foreach (Cuerpo_Tecnico unPersonal in parListPersona)
                        {
                            if (MTBdni.Text == unPersonal.getDni())
                            {
                                TNombre.Text = unPersonal.getNombre();
                                TApellido.Text = unPersonal.getApellido();
                                TNacionalidad.Text = unPersonal.getNacionalidad();
                                MTBTelefono.Text = unPersonal.getTelefono();
                                TDomicilio.Text = unPersonal.getDomicilio();
                                DTPFechaDeNacimiento.Value = unPersonal.getFechaNac();
                                if (unPersonal.getSexo() == "Masculino")
                                { RBMasculino.Checked = true; }
                                else
                                { RBFemenino.Checked = true; }
                                RBCuerpoTecnico.Checked = true;
                                TCargo.Text = unPersonal.getCargo();
                                TEspecialidad.Text = unPersonal.getEspecialidad();
                            }
                        }
                    }
            }                       
            //si no existe el DNI entonces lo añade a la lista
            foreach (Persona nuevo in parListPersona)
            {
                if (MTBdni.Text != nuevo.getDni())
                {
                    DialogResult = MessageBox.Show("El DNI No Existe \n¿Desea Guardarlo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        BGuardar_Click(sender, e);
                    }
                }
            }                
        }
        // Falta hacer boton eliminar
        private void BEliminar_Click(object sender, EventArgs e)
        {            
            foreach (Persona nuevo in parListPersona)
            {
                if (MTBdni.Text == nuevo.getDni())
                {
                    DialogResult = MessageBox.Show("¿Desea Eliminar el Dni " + nuevo.getDni() + "?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DialogResult == DialogResult.Yes)
                    {
                        //parListPersona.IndexOf(nuevo);
                        parListPersona.Remove(nuevo);
                    }
                } 
            }
        }
    }
}
