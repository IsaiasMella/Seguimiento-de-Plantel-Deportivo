using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Persona
    {
        #region atributos
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _telefono;
        private string _nacionalidad;
        private DateTime _fechaNac;        
        private double _sueldo;
        private DateTime _plazoContrato;
        private DateTime _fechaContratacion;
        #endregion
        #region propiedades
        #endregion
        #region consultas
        public int getDni()
        { return _dni; }
        public string getNombre()
        { return _nombre; }
        public string getApellido()
        { return _apellido; }
        public string getDomicilio()
        { return _domicilio; }
        public string getTelefono()
        { return _telefono; }
        public string getNacionalidad()
        { return _nacionalidad; }
        public DateTime getFechaNac()
        { return _fechaNac; }      
        public double getSueldo()
        { return _sueldo; }
        public DateTime getPlazoContrato()
        { return _plazoContrato; }
        public DateTime getFechaContratacion()
        { return _fechaContratacion; }
        public int Edad()
        {
            int FechaNac;
            FechaNac = Convert.ToInt32(DateTime.Today - this._fechaNac);
            return FechaNac;
        }
        #endregion
        #region comandos
        public void setDni(int valor)
        {           
             this._dni = valor; 
        }
        public void setNombre(string valor)
        { this._nombre = valor; }
        public void setApellido(string valor)
        { this._apellido = valor; }
        public void setDomicilio(string valor)
        { this._domicilio = valor; }
        public void setTelefono(string valor)
        { this._telefono = valor; }
        public void setNacionalidad(string valor)
        { this._nacionalidad = valor; }
        public void setFechaNac(DateTime valor)//La fecha de Nacimiento tiene que ser menor a la fecha del dia en curso
        {
            if (valor < DateTime.Today)
            { this._fechaNac = valor; }
        }
        public void setSueldo(double valor)//El sueldo debe ser mayor a 0
        {
            if (valor > 0)
            { this._sueldo = valor; }
        }
        public void setPlazoContrato(DateTime valor)//El plazo de contrato tiene que minimo de 6 meses o 180 dias
        {
            if (valor >= DateTime.Today)
            {
                this._plazoContrato = valor;
            }             
        }
        public void setFechaContratacion(DateTime valor)//La fecha de contratacion tiene que ser anterior o igual al dia en curso
        {
            if (valor <= DateTime.Today)
            { this._fechaContratacion = valor; }
        }       
        #endregion
        #region contructores

        #endregion
    }
}
