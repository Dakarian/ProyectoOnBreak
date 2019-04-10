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

            set {

                if (value.Length<= 9 & value.Length>=10)
                {
                    Rut = value;
                }
                    else
                    {
                    throw new ArgumentException("Rut invalido");
                    }

                }
        }

        private String RazonSocial;

        public String _RazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }

        private String NombreContacto;

        public String _NombreContacto
        {
            get { return NombreContacto; }
            set { NombreContacto = value; }
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

        private String Actividad;

        public String _Actividad
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        private String Tipo;

        public String _Tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }



    }
}
