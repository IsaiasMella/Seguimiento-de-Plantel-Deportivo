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
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\FondoParaFormPrincipal.jpg");
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
            LBJugadores.Items.Clear();
            if ((CBJugador.SelectedIndex == -1) && (Convert.ToString(CBPiernaHabil.SelectedItem) == ""))
            {
                MessageBox.Show("Seleccione algun parametro para filtrar a los jugadores", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Jugador UnJugador in ListPersona)
            {
                // entra siempre que jugador sea "todos" o no este selec. y pierna sea "todos" o coinsidan las piernas
                if ((CBJugador.SelectedIndex <= 0) && ((CBPiernaHabil.SelectedIndex <= 0)||(Convert.ToString(CBPiernaHabil.SelectedItem) == UnJugador.getPierna_Habil())))
                {
                   LBJugadores.Items.Add(UnJugador.getApellido() + " " + UnJugador.getNombre() + " - " + UnJugador.getPosicion());
                }
                //entra a jugador y compara por posicion y mira que pierna no este selec
                if (Convert.ToString(CBJugador.SelectedItem) == UnJugador.getPosicion()&&(CBPiernaHabil.SelectedIndex == -1))
                {
                    LBJugadores.Items.Add(UnJugador.getApellido() + " " + UnJugador.getNombre() + " - " + UnJugador.getPosicion());
                }
                //entra a pierna y jugador y si coinsiden los lista
                if (Convert.ToString(CBPiernaHabil.SelectedItem) == UnJugador.getPierna_Habil()&& (Convert.ToString(CBJugador.SelectedItem) == UnJugador.getPosicion()))
                {
                    LBJugadores.Items.Add(UnJugador.getApellido() + " " + UnJugador.getNombre() + " - " + UnJugador.getPosicion());
                }                
            }
        }
        
        private void BBuscarContratos_Click(object sender, EventArgs e)
        {
            DGVContratos.Rows.Clear();
            foreach (Persona UnaPersona in ListPersona)
            {
                //Carga todos los contratos
                if ((CBContratos.SelectedIndex == 0))
                {
                    int n = DGVContratos.Rows.Add();
                    DGVContratos.Rows[n].Cells[0].Value = UnaPersona.getApellido() + " " + UnaPersona.getNombre();
                    DGVContratos.Rows[n].Cells[1].Value = UnaPersona.getPlazoContrato();
                    DGVContratos.Rows[n].Cells[2].Value = UnaPersona.getFechaContratacion();
                    DGVContratos.Rows[n].Cells[3].Value = UnaPersona.getFechaContratacion().AddDays(UnaPersona.getPlazoContrato());
                    DGVContratos.Rows[n].Cells[4].Value = UnaPersona.getSueldo();

                    DGVContratos.Visible = true;

                }
                //Carga contratos de jugadores
                if ((UnaPersona is Jugador) && (CBContratos.SelectedIndex == 1))
                {

                    int J = DGVContratos.Rows.Add();
                    DGVContratos.Rows[J].Cells[0].Value = UnaPersona.getApellido() + " " + UnaPersona.getNombre();
                    DGVContratos.Rows[J].Cells[1].Value = UnaPersona.getPlazoContrato();
                    DGVContratos.Rows[J].Cells[2].Value = UnaPersona.getFechaContratacion();
                    DGVContratos.Rows[J].Cells[3].Value = UnaPersona.getFechaContratacion().AddDays(UnaPersona.getPlazoContrato());
                    DGVContratos.Rows[J].Cells[4].Value = UnaPersona.getSueldo();
                    DGVContratos.Visible = true;
                }
                //Carga contratos de CT
                if ((UnaPersona is Cuerpo_Tecnico) && (CBContratos.SelectedIndex == 2))
                {
                    int T = DGVContratos.Rows.Add();
                    DGVContratos.Rows[T].Cells[0].Value = UnaPersona.getApellido() + " " + UnaPersona.getNombre();
                    DGVContratos.Rows[T].Cells[1].Value = UnaPersona.getPlazoContrato();
                    DGVContratos.Rows[T].Cells[2].Value = UnaPersona.getFechaContratacion();
                    DGVContratos.Rows[T].Cells[3].Value = UnaPersona.getFechaContratacion().AddDays(UnaPersona.getPlazoContrato());
                    DGVContratos.Rows[T].Cells[4].Value = UnaPersona.getSueldo();
                    DGVContratos.Visible = true;
                }
            }

        }

        private void BBuscarLesion_Click(object sender, EventArgs e)
        {
            LBLesiones.Items.Clear();
            foreach (Jugador UnJugador in ListPersona)
            {
                if (CBLesion.SelectedIndex == 0)
                {
                    // + " ,se lesiono el: " + UnJugador.getLesion().getFecha_De_Inicio_De_Lesion() + " El tiepo estimado de recuperacion es " + UnJugador.getLesion().getTiempo_Estimado_De_Recuperacion()) ;
                    LBLesiones.Items.Add(UnJugador.getApellido() + " " + UnJugador.getNombre() + UnJugador.getLesion().ToString());
                }
                else if ((Convert.ToString(CBLesion.SelectedItem) == UnJugador.getPosicion()) && (CBLesion.SelectedIndex > 0))
                {
                    //"El tipo de lesion es: " + UnJugador.getLesion() + " ,se lesiono el: " + UnJugador.getLesion().getFecha_De_Inicio_De_Lesion() + " El tiepo estimado de recuperacion es " + UnJugador.getLesion().getTiempo_Estimado_De_Recuperacion());
                    LBLesiones.Items.Add(UnJugador.getApellido() + " " + UnJugador.getNombre() + UnJugador.getLesion().ToString());
                }
            }
        }
    }
}