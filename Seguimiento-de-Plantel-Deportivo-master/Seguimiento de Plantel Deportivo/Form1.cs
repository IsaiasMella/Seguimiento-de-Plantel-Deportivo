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
    }
}
