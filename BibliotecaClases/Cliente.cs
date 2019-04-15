using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente
    {
        private String Rut;

        public String _Rut
        {
            get
            {
                return Rut;
            }

            set
            {
                Rut = value;
                /*
                if (value.Length <= 10)
                {
                    Rut = value;
                }
                else
                {
                    throw new ArgumentException("Rut invalido");
                }
                */
            }
        }

        private String NombreContacto;

        public String _NombreContacto
        {
            get { return NombreContacto; }
            set { NombreContacto = value; }
        }

        private String RazonSocial;

        public String _RazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }

        private String MailContacto;

        public String _MailContacto
        {
            get { return MailContacto; }
            set { MailContacto = value; }
        }

        private String Direccion;

        public String _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        private int Telefono;

        public int _Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        private Actividad _actividad;

        public Actividad _Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }

        private Empresa _tipo;

        public Empresa _Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}