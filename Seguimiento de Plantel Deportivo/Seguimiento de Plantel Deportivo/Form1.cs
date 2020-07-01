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

        private void FSeguimientoDePlantelDepo_Load(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPersonal FormPersonal = new FPersonal();
            FormPersonal.parListPersona = ListPersona;
            FormPersonal.Show();
        }

        private void BBuscarJugador_Click(object sender, EventArgs e)
        {
            foreach (Jugador UnJugador in ListPersona)
            {
                LBJugadores.Items.Add(UnJugador.getDni() + " - " + UnJugador.getPosicion());
            }
        }
        private void lesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLesion FormLesion = new FLesion();
            FormLesion.parListPersona = ListPersona;
            FormLesion.parListLesion = ListLesion;
            FormLesion.Show();

        }
    }
}
