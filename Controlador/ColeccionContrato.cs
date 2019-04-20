using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ColeccionContrato
    {

        public static List<Contrato> contrato = new List<Contrato>();

        //Coleccion de contrato
        public List<Contrato> Contrato
        {
            get { return contrato; }
            set { contrato = value; }
        }


        public Contrato buscarContrato(float ncontrato)
        {

            foreach (var item in contrato)
            {
                if (item._NumeroContrato == ncontrato)
                {
                    return item;
                }
            }

            return null;

        }


        public bool agregarContrato(Contrato con)
        {
            

            if (existeContrato(con._NumeroContrato)==false)
            {
                contrato.Add(con);
                return true;
            }
            
                return false;
            
        }

        public bool existeContrato(double numcontrato)
        {
            foreach (Contrato item in contrato)
            {
                if (item._NumeroContrato.Equals(numcontrato))
                {
                    return true;
                }

            }
            return false;
        }

    }
}
