using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Controlador
{
    public class ColeccionCliente
    {




        private List<Cliente> clientes = new List<Cliente>();

        public ColeccionCliente()
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }
        }

        //Coleccion de clientes
        public List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        //Listar
        public List<Cliente> Listar()
        {
            return clientes;
        }

        //Método buscar cliente
        public Cliente buscarRut(string rut)
        {
            foreach (Cliente buscar in clientes)
            {
                if (buscar._Rut.Equals(rut))
                {
                    return buscar;
                }
            }
            return null;
        }

        //Método agregar cliente
        public bool agregarCliente(Cliente cli)
        {
            if (existeRut(cli._Rut) == false)
            {
                this.clientes.Add(cli);
                return true;
            }
            return false;
        }

        //Verificar si el rut existe
        public bool existeRut(string rut)
        {
            foreach (Cliente item in clientes)
            {
                if (item._Rut.Equals(rut))
                {
                    return true;
                }
            }

            return false;
        }

        // Metodo para eliminar un cliente de la lista.
        public bool eliminarCliente(string rut)
        {
            Cliente cliente = buscarRut(rut);
            if (cliente != null)
            {
                this.clientes.Remove(cliente);
                return true;
            }
            return false;
        }
    }
}
