using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class TipoEvento
    {
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

        private int PersonalBase;

        public int _PersonalBase
        {
            get { return PersonalBase; }
            set { PersonalBase = value; }
        }


    }
}
