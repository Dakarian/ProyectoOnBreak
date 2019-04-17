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

        private List<Contrato> contrato = new List<Contrato>();

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

            Contrato nvContrato = buscarContrato(con._NumeroContrato);

            if (nvContrato == null)
            {
                this.contrato.Add(nvContrato);
                return true;
            }
            else
            {
                return false;
            }



        }

    }
}
