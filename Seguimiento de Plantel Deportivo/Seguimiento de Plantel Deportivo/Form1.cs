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
            LBContratos.Items.Clear();
            foreach (Persona UnaPersona in ListPersona)
            {
                if ((CBContratos.SelectedIndex == 0))
                {
                    LBContratos.Items.Add( UnaPersona.getApellido() + " " + UnaPersona.getNombre() + " Le quedan " + UnaPersona.getPlazoContrato() + " Años, Inició: " +
                    UnaPersona.getFechaContratacion() + " y finaliza: ");
                }
                if ((UnaPersona is Jugador)&& (CBContratos.SelectedIndex == 1))
                {
                    LBContratos.Items.Add(UnaPersona.getApellido() + " " + UnaPersona.getNombre() + " Le quedan " + UnaPersona.getPlazoContrato() + " Años, Inició: " +
                    UnaPersona.getFechaContratacion() + " y finaliza: ");
                }
                if ((UnaPersona is Cuerpo_Tecnico)&& (CBContratos.SelectedIndex == 2))
                {
                    LBContratos.Items.Add(UnaPersona.getApellido() + " " + UnaPersona.getNombre() + " Le quedan " + UnaPersona.getPlazoContrato() + " Años, Inició: " +
                    UnaPersona.getFechaContratacion() + " y finaliza: ");
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
                    LBLesiones.Items.Add("El tipo de lesion es: "+ UnJugador.getLesion()+ " ,se lesiono el: "+ UnJugador.getLesion().getFecha_De_Inicio_De_Lesion() + " El tiepo estimado de recuperacion es " + UnJugador.getLesion().getTiempo_Estimado_De_Recuperacion()) ;
                }
                if ((Convert.ToString(CBLesion.SelectedItem )== UnJugador.getPosicion())&& (CBLesion.SelectedIndex > 0))
                {
                    LBLesiones.Items.Add("El tipo de lesion es: " + UnJugador.getLesion() + " ,se lesiono el: " + UnJugador.getLesion().getFecha_De_Inicio_De_Lesion() + " El tiepo estimado de recuperacion es " + UnJugador.getLesion().getTiempo_Estimado_De_Recuperacion());
                }                
            }
        }
    }
}
