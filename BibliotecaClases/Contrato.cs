using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Contrato
    {
        private double NumeroContrato;

        public double _NumeroContrato
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

        private String FechaHoraInicio;

        public String _FechaHoraInicio
        {
            get { return FechaHoraInicio; }
            set { FechaHoraInicio = value; }
        }

        private String FechaHoraTermino;

        public String _FechaHoraTermino
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

        private String Observaciones;

        public String _Observaciones
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }
        public Contrato()
        {

        }



    }

    public class Tipo {

        private int Id;

        public int _Id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Nombre;

        public String _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private int ValorBase;

        public int _ValorBase
        {
            get { return ValorBase; }
            set { ValorBase = value; }
        }

        private double Personas;

        public double _Personas
        {
            get { return Personas; }
            set { Personas = value; }
        }

        private double PersonalAdicional;

        public double _PersonalAdicional
        {
            get { return PersonalAdicional; }
            set { PersonalAdicional = value; }
        }

        private double Total;

        public double _Total
        {
            get { return Total; }
            set { Total = value; }
        }

        private double NumeroContrato;

        public double _NumeroContrato
        {
            get { return NumeroContrato; }
            set { NumeroContrato = value; }
        }

        public Tipo()
        {

        }


    }
}
