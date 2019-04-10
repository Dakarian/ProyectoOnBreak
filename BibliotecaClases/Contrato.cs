using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Contrato
    {
        private int NumeroContrato;

        public int _NumeroContrato
        {
            get { return NumeroContrato; }
            set { NumeroContrato = value; }
        }

        private DateTime Creacion;

        public DateTime _Creacion
        {
            get { return Creacion; }
            set { Creacion = value; }
        }

        private DateTime Termino;

        public DateTime _Termino
        {
            get { return Termino; }
            set { Termino = value; }
        }

        private DateTime FechaHoraInicio;

        public DateTime _FechaHoraInicio
        {
            get { return FechaHoraInicio; }
            set { FechaHoraInicio = value; }
        }

        private DateTime FechaHoraTermino;

        public DateTime _FechaHoraTermino
        {
            get { return FechaHoraTermino; }
            set { FechaHoraTermino = value; }
        }

        private String Direccion;

        public String _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        private bool EstaVigente;

        public bool _EstaVigente
        {
            get { return EstaVigente; }
            set { EstaVigente = value; }
        }

        private String Tipo;

        public String _Tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        private String Observaciones;

        public String _Observaciones
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }



    }
}
