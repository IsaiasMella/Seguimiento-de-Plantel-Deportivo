using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    public abstract class Persona
    {
        #region atributos
        protected int _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _domicilio;
        protected string _telefono;
        protected string _nacionalidad;
        protected DateTime _fechaNac;
        protected string _Sexo;
        protected double _sueldo;
        protected int _plazoContrato;
        protected DateTime _fechaContratacion;
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
        public string getSexo()
        { return _Sexo; }
        public double getSueldo()
        { return _sueldo; }
        public int getPlazoContrato()
        { return _plazoContrato; }
        public DateTime getFechaContratacion()
        { return _fechaContratacion; }
        public  abstract int Edad();        
        
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
        public void setSexo(string valor)
        {
            this._Sexo = valor;
        }
        public void setSueldo(double valor)//El sueldo debe ser mayor a 0
        {
            if (valor > 0)
            { this._sueldo = valor; }
        }
        public void setPlazoContrato(int valor)//El plazo de contrato tiene que minimo de 6 meses o 180 dias
        {
            if (valor >= 1)
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
      
        public Persona(int dni, string nombre, string apellido, string domicilio, string telefono,string nacionalidad, DateTime fechaNac, string sexo,double sueldo,int plazoContrato, DateTime fechaContratacion)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._nacionalidad = nacionalidad;
            this._fechaNac = fechaNac;
            this._Sexo = sexo;
            this._sueldo = sueldo;
            this._plazoContrato = plazoContrato;
            this._fechaContratacion = fechaContratacion;
        }
        public Persona()
        { 
            this._dni = 0;
            this._nombre = "";
            this._apellido = "";
            this._domicilio = "";
            this._telefono = "";
            this._nacionalidad = "";
            this._fechaNac = DateTime.Today;
            this._Sexo = "";
            this._sueldo = 0;
            this._plazoContrato = 1;
            this._fechaContratacion = DateTime.Today;
        }
        #endregion
    }
}
