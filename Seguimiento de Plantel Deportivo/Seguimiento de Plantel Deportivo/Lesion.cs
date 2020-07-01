using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    public class Lesion
    {
        #region Atributos
        private string _tipoDeLesion;
        private DateTime _fechaDeInicioDeLesion;
        private int _tiempoEstimadoDeRecuperacion;
        #endregion
        #region Propiedades
        #endregion
        #region Consultas

        public string getTipo_De_Lesion()
        {
            return _tipoDeLesion;
        }
        public DateTime getFecha_De_Inicio_De_Lesion()
        {
            return _fechaDeInicioDeLesion;
        }
        public int getTiempo_Estimado_De_Recuperacion()
        {
            return _tiempoEstimadoDeRecuperacion;
        }
        public override string ToString()
        {

            return "- Tipo: " + _tipoDeLesion + "- Plazo: " + _tiempoEstimadoDeRecuperacion + " dias";
        }
        #endregion
        #region Comandos
        public void setTipo_De_Lesion(string Tipo_De_Lesion_Jugador)
        {
            this._tipoDeLesion = Tipo_De_Lesion_Jugador;
        }
        public void setFecha_De_Inicio_De_Lesion(DateTime Fecha_De_Inicio_De_Lesion_Jugador)
        {
            this._fechaDeInicioDeLesion = Fecha_De_Inicio_De_Lesion_Jugador;
        }
        public void setTiempo_Estimado_De_Recuperacion(int Tiempo_Estimado_De_Recuperacion_Jugador)
        {
            this._tiempoEstimadoDeRecuperacion = Tiempo_Estimado_De_Recuperacion_Jugador;
        }

        #endregion
        #region Constructores
        public Lesion(string Tipo_De_Lesion_Jugador, DateTime Fecha_De_Inicio_De_Lesion_Jugador, int Tiempo_Estimado_De_Recuperacion_Jugador)
        {
            this._tipoDeLesion = Tipo_De_Lesion_Jugador;
            this._fechaDeInicioDeLesion = Fecha_De_Inicio_De_Lesion_Jugador;
            this._tiempoEstimadoDeRecuperacion = Tiempo_Estimado_De_Recuperacion_Jugador;
        }
        #endregion
    }
}
