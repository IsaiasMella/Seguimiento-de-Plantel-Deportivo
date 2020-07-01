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
    public partial class FSeguimientoDePlantelDepo : Form
    {
        public List<Persona> ListPersona = new List<Persona>();
        public List<Lesion> ListLesion = new List<Lesion>();
        public FSeguimientoDePlantelDepo()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\FondoPrincipal.jpg");
            this.BackgroundImage = img;
        }
        #region Apertura de Formularios
        private void FSeguimientoDePlantelDepo_Load(object sender, EventArgs e)
        {

        }
        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPersonal FormPersonal = new FPersonal();
            FormPersonal.parListPersona = ListPersona;
            FormPersonal.Show();
        }
        private void lesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLesion FormLesion = new FLesion();
            FormLesion.parListPersona = ListPersona;
            FormLesion.parListLesion = ListLesion;
            FormLesion.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FContratos FormContratos = new FContratos();
            FormContratos.parListPersona = ListPersona;
            FormContratos.parListLesion = ListLesion;
            FormContratos.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void BBuscarJugador_Click(object sender, EventArgs e)
        {
            foreach (Jugador UnJugador in ListPersona)
            {
                LBJugadores.Items.Add(UnJugador.getDni() + " - " + UnJugador.getPosicion());
            }
        }
        
        private void BBuscarContratos_Click(object sender, EventArgs e)
        {
            int i;
            i = 1;
            foreach (Persona UnaPersona in ListPersona)
            {
                if (CBContratos.SelectedIndex == 0)
                {
                    LBContratos.Items.Clear();
                    LBContratos.Items.Add(i + "- " + UnaPersona.getApellido() + " " + UnaPersona.getNombre() + " Le quedan " + UnaPersona.getPlazoContrato() + " Años, Inició: " +
                        UnaPersona.getFechaContratacion() + " y finaliza: ");

                }
                else if ((CBContratos.SelectedIndex == 1) && (UnaPersona is Jugador))
                {
                    LBContratos.Items.Clear();
                    foreach (Jugador UnJugador in ListPersona)
                    {
                        LBContratos.Items.Add(i + "- " + UnJugador.getApellido() + " " + UnJugador.getNombre() + " Le quedan " + UnJugador.getPlazoContrato() + " Años, Inició: " +
                            UnJugador.getFechaContratacion() + " y finaliza: ");
                    }
                }
                else if ((CBContratos.SelectedIndex == 2)&&(UnaPersona is Cuerpo_Tecnico))
                {
                    LBContratos.Items.Clear();
                    foreach (Cuerpo_Tecnico UnCT in ListPersona)
                    {
                        LBContratos.Items.Add(i + "- " + UnCT.getApellido() + " " + UnCT.getNombre() + " Le quedan " + UnCT.getPlazoContrato() + " Años, Inició: " +
                            UnCT.getFechaContratacion() + " y finaliza: ");
                    }
                }
            }
                
        }        
    }
}
