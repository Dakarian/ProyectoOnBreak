using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class ColeccionCliente
    {
        private List<Cliente> clientes = new List<Cliente>();

        //Coleccion de clientes
        public List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        //Método buscar cliente
        public Cliente buscarRut(string rut)
        {

            foreach (var buscar in clientes)
            {
                if (buscar._Rut==rut)
                {
                    return buscar;
                }
            }

            return null;
        }

        //Método agregar cliente
        public bool agregarCliente(Cliente cli)
        {
            Cliente nuevoCliente = buscarRut(cli._Rut);

            if (nuevoCliente == null)
            {
                this.clientes.Add(nuevoCliente);
                return true;
            }

            return false;
        }
    }
}
