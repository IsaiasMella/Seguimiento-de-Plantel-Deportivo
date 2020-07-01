using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Cuerpo_Tecnico : Persona
    {
        #region Atributos
        private string _cargo;
        private string _especialidad;
        #endregion
        #region Propiedades

        #endregion
        #region Consultas
        public string getCargo()
        {
            return _cargo;
        }
        public string getEspecialidad()
        {
            return _especialidad;
        }
        public override int Edad()
        {
            int Edad_Persona;
            Edad_Persona = Convert.ToInt32(DateTime.Today - _fechaNac);
            return Edad_Persona;
        }
        #endregion
        #region Comandos
        public void setCargo(string Cargo_CT)
        {
            this._cargo = Cargo_CT;
        }
        public void setEspecialidad(string Especialidad_CT)
        {
            this._especialidad = Especialidad_CT;
        }
        #endregion
        #region Constructores
        public Cuerpo_Tecnico(string dni, string nombre, string apellido, string domicilio, string telefono, string nacionalidad, DateTime fechaNac, string sexo, string Cargo_CT, string Especialidad_CT) : base(dni, nombre, apellido, domicilio, telefono, nacionalidad, fechaNac, sexo)
        {
            this._cargo = Cargo_CT;
            this._especialidad = Especialidad_CT;

        }

        #endregion
    }
}
