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
    public partial class FLesion : Form
    {
        public List<Persona> parListPersona;
        public List<Lesion> parListLesion;
        public FLesion()
        {
            InitializeComponent();
        }
        private void CamposCompletos()
        {


            if (Tlesion.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tlesion.Focus();
            }
            else if (DTPFechaDeInicio.Value < DateTime.Today)
            {
                MessageBox.Show("Ingrese una Fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPFechaDeInicio.Focus();
            }
            if (!MTBTiempoEstimadoDeLesion.MaskCompleted)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBTiempoEstimadoDeLesion.Focus();
            }
            else
            {
                Cargar();
            }

        }
        private void Repetido()
        {

        }
        private void Cargar()
        {
            foreach (Jugador unJugador in parListPersona)
            {

                if (MTBdniCarga.Text == unJugador.getDni())
                {
                    Lesion UnaLesion = new Lesion(Tlesion.Text, DTPFechaDeInicio.Value, Convert.ToInt32(MTBTiempoEstimadoDeLesion.Text));
                    unJugador.setLesion(UnaLesion);

                }
            }
            MessageBox.Show("La lesion ya fue cargada", "Lesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BCargar_Click(object sender, EventArgs e)
        {
            CamposCompletos();
            MTBdniCarga.Clear();
            TNombre.Clear();
            TApellido.Clear();
            Tlesion.Clear();
            DTPFechaDeInicio.Value = DateTime.Today;
            MTBTiempoEstimadoDeLesion.Clear();
        }

        private void BBuscarLesion_Click(object sender, EventArgs e)
        {
            if (!MTBdniBusquedaDeLesion.MaskFull)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBdniBusquedaDeLesion.Focus();
            }
            else
            {

                LBLesion.Visible = true;
                foreach (Jugador unJugador in parListPersona)
                {

                    if (MTBdniBusquedaDeLesion.Text == unJugador.getDni())
                    {

                        LBLesion.Items.Add(unJugador.getApellido() + unJugador.getLesion().ToString());
                    }

                }

                //No se que parametros querian pasar al listbox
            }
        }

        private void MTBdniCarga_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            foreach (Jugador unJugador in parListPersona)
            {

                if (MTBdniCarga.Text == unJugador.getDni())
                {
                    TNombre.Enabled = true;
                    TApellido.Enabled = true;
                    TNombre.Text = unJugador.getNombre();
                    TApellido.Text = unJugador.getApellido();
                }
            }
        }
    }
}
