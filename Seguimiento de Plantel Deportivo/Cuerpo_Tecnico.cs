using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Cuerpo_Tecnico
    {
        #region Atributos
        private string Cargo;
        private string Especialidad;
        #endregion
        #region Propiedades

        #endregion
        #region Consultas
        public string getCargo()
        {
            return Cargo;
        }
        public string getEspecialidad()
        {
            return Especialidad;
        }
        #endregion
        #region Comandos
        public void setCargo (string Cargo_CT)
        {
            this.Cargo = Cargo_CT;
        }
        public void setEspecialidad(string Especialidad_CT)
        {
            this.Especialidad = Especialidad_CT;
        }
        #endregion
        #region Constructores
        #endregion
    }
}
