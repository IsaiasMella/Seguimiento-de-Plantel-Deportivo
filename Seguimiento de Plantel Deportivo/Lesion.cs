using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Lesion
    {
        #region Atributos
        private int DNI;
        private string Apellido;
        private string Nombre;
        private string Tipo_De_Lesion;
        private DateTime Fecha_De_Inicio_De_Lesion;
        private int Tiempo_Estimado_De_Recuperacion;
        #endregion
        #region Propiedades
        #endregion
        #region Consultas
        public int getDNI()
        {
            return DNI;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getTipo_De_Lesion()
        {
            return Tipo_De_Lesion;
        }
        public DateTime getFecha_De_Inicio_De_Lesion()
        {
            return Fecha_De_Inicio_De_Lesion;
        }
        public int getTiempo_Estimado_De_Recuperacion()
        {
            return Tiempo_Estimado_De_Recuperacion;
        }
        #endregion
        #region Comandos
        public void setDni (int Dni_Jugador)
        {
            this.DNI = Dni_Jugador;
        }
        public void setApellido(string Apellido_Jugador)
        {
            this.Apellido = Apellido_Jugador;
        }
        public void setNombre(string Nombre_Jugador)
        {
            this.Nombre = Nombre_Jugador;
        }
        public void setTipo_De_Lesion(string Tipo_De_Lesion_Jugador)
        {
            this.Tipo_De_Lesion = Tipo_De_Lesion_Jugador;
        }
        public void setFecha_De_Inicio_De_Lesion(DateTime Fecha_De_Inicio_De_Lesion_Jugador)
        {
            this.Fecha_De_Inicio_De_Lesion = Fecha_De_Inicio_De_Lesion_Jugador;
        }
        public void setTiempo_Estimado_De_Recuperacion(int Tiempo_Estimado_De_Recuperacion_Jugador)
        {
            this.Tiempo_Estimado_De_Recuperacion = Tiempo_Estimado_De_Recuperacion_Jugador;
        }

        #endregion
        #region Constructores
        #endregion
    }
}
