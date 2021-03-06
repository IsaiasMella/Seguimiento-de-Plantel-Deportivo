﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguimiento_de_Plantel_Deportivo
{
    class Jugador : Persona
    {
        #region Atributos
        private decimal _dorsal;
        private string _posicion;
        private string _piernaHabil;
        private Lesion _lesion;
        #endregion
        #region Propiedades
        #endregion
        #region Consultas
        public decimal getDorsal()
        {
            return _dorsal;
        }
        public string getPosicion()
        {
            return _posicion;
        }
        public string getPierna_Habil()
        {
            return _piernaHabil;
        }
        public Lesion getLesion()
        {
            return _lesion;
        }
        public override int Edad()
        {
            int Edad_Persona;
            Edad_Persona = Convert.ToInt32(DateTime.Today - _fechaNac);
            return Edad_Persona;
        }
        #endregion
        #region Comandos
        public void setDorsal(decimal Dorsal_Jugador)
        {
            if (Dorsal_Jugador >= 1)
            {
                this._dorsal = Dorsal_Jugador;
            }
        }
        public void setPocion(string Posicion_Jugador)
        {
            this._posicion = Posicion_Jugador;
        }
        public void setPierna_Habil(string PH_Jugador)
        {
            this._piernaHabil = PH_Jugador;
        }
        public void setLesion(Lesion unLesion)
        {
            this._lesion = unLesion;

        }
        #endregion
        #region Constructores
        public Jugador(string dni, string nombre, string apellido, string domicilio, string telefono, string nacionalidad, DateTime fechaNac, string sexo, decimal dorsal, string posicion, string piernaHabil) : base(dni, nombre, apellido, domicilio, telefono, nacionalidad, fechaNac, sexo)
        {
            this._dorsal = dorsal;
            this._posicion = posicion;
            this._piernaHabil = piernaHabil;
        }
        public Jugador()
        {
            //int dni, string nombre, string apellido, string domicilio, string telefono, string nacionalidad, DateTime fechaNac, string sexo, decimal dorsal, string posicion, string piernaHabil) : base(dni, nombre, apellido, domicilio, telefono, nacionalidad, fechaNac, sexo
            this._dorsal = 1;
            this._posicion = "";
            this._piernaHabil = "";
        }

        #endregion
    }
}
