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
        public FLesion()
        {
            InitializeComponent();
        }
        private void CamposCompletos()
        {
            if (!MTBdniCarga.MaskFull)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBdniCarga.Focus();
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
            else if (Tlesion.Text == "")
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tlesion.Focus();
            }
            else if (DTPFechaDeInicio.Value < DateTime.Today)
            {
                MessageBox.Show("Ingrese una Fecha valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPFechaDeInicio.Focus();
            }
            if (!MTBTiempoEstimadoDeLesion.MaskFull)
            {
                MessageBox.Show("Campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBTiempoEstimadoDeLesion.Focus();
            }
            else
            {
                Repetido();
            }

        }
        private void Repetido()
        {
            if ((DTPFechaDeInicio.Value == < Nombre de la lista >.FechaDeLesion) && (Tlesion.Text == < Nombre de la lista >.Lesion ))
            {
                MessageBox.Show("La lesion ya fue cargada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             else
            {
                Cargar();
            }

        }
        private void Cargar()
        {
            foreach (Lesion nuevo in <Nombre de lista>)
            {
                #region Agregar Nuevos Items a la Lista
                //parListPersona.Add(Convert.ToInt32(MTBdni.Text));
                #endregion
            }
        }
        private void BCargar_Click(object sender, EventArgs e)
        {
            CamposCompletos();
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
                LJugador.Text = <TNombre de lista>.Nombre + " " + < TNombre de lista>.Apellido;
                //No se que parametros querian pasar al listbox
            }
        }
    }
}
