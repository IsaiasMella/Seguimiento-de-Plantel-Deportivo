using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Jugador
    {
        #region Atributos
        private int Dorsal;
        private string Posicion;
        private string Pierna_Habil;
        #endregion
        #region Propiedades
        #endregion
        #region Consultas
        public int getDorsal()
        {
            return Dorsal;
        }
        public string getPosicion()
        {
            return Posicion;
        }
        public string getPierna_Habil()
        {
            return Pierna_Habil;
        }
        #endregion
        #region Comandos
        public void setDorsal(int Dorsal_Jugador)
        {
            if (Dorsal_Jugador >= 1)
            {
                this.Dorsal = Dorsal_Jugador;
            }
        }
        public void setPocion(string Posicion_Jugador)
        {
            this.Posicion = Posicion_Jugador;
        }
        public void setPierna_Habil(string PH_Jugador)
        {
            this.Pierna_Habil = PH_Jugador;
        }
        #endregion
        #region Constructores
        #endregion
    }
}
