using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Controlador
{
    public class ColeccionTipo
    {
        public static List<Tipo> Tipos = new List<Tipo>();

        public Tipo buscarContrato(float ncontrato)
        {

            foreach (var item in Tipos)
            {
                if (item._NumeroContrato == ncontrato)
                {
                    return item;
                }
            }

            return null;

        }

        public bool existeContrato(double numcontrato)
        {
            foreach (Tipo item in Tipos)
            {
                if (item._NumeroContrato.Equals(numcontrato))
                {
                    return true;
                }

            }
            return false;
        }


        public bool agregarTipo(Tipo tip)
        {


            if (existeContrato(tip._NumeroContrato) == false)
            {
                Tipos.Add(tip);
                return true;
            }

            return false;

        }
        //Listar
        public List<Tipo> Listar()
        {
            return Tipos;
        }

    }
}
