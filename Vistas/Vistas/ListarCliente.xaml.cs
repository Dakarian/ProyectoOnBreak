using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using Controlador;
using BibliotecaClases;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ListarCliente.xaml
    /// </summary>
    public partial class ListarCliente : MetroWindow
    {
        AdministrarCliente adm;
        public ListarCliente()
        {
            InitializeComponent();
            ColeccionCliente coleccion = new ColeccionCliente();
            dgridCliente.ItemsSource = coleccion.Listar();
        }



        public ListarCliente(AdministrarCliente vo)
        {
            InitializeComponent();
            ColeccionCliente coleccion = new ColeccionCliente();
            dgridCliente.ItemsSource = coleccion.Listar();
            adm = vo;
        }


        private ColeccionCliente coleccion = new ColeccionCliente();

        public ColeccionCliente Coleccion
        {
            get { return coleccion; }
            set { coleccion = value; }
        }

        //Boton actualizar la Grilla
        private void btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            actualizarGrilla();
        }

        //Metodo para Buscar/Filtrar automaticamente rut
        private void TxtRut_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtRut.Text.Length > 0)
            {
                string rut = txtRut.Text.ToLower();
                string rutBuscado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rut);
                var posicion = this.Coleccion.Clientes.Where(r => r._Rut.Contains(rutBuscado)).ToList();
                dgridCliente.ItemsSource = posicion;
            }
            else
            {
                dgridCliente.ItemsSource = this.Coleccion.Clientes;
            }


        }

        //Metodo para Buscar/Filtrar automaticamente nombre
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                string nombre = txtNombre.Text.ToLower();
                string nombreBuscado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
                var Posicion = this.Coleccion.Clientes.Where(r => r._NombreContacto.ToString().Contains(nombreBuscado)).ToList();
                dgridCliente.ItemsSource = Posicion;
            }
            else
            {
                dgridCliente.ItemsSource = this.Coleccion.Clientes;
            }
        }

        //Metodo para Buscar/Filtrar automaticamente Empresa
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtEmpresa.Text.Length > 0)
            {
                string nempresa = txtEmpresa.Text.ToLower();
                string Empresabuscada = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nempresa);
                var Posicion = this.Coleccion.Clientes.Where(r => r._Tipo.ToString().Contains(Empresabuscada)).ToList();
                dgridCliente.ItemsSource = Posicion;
            }
            else
            {
                dgridCliente.ItemsSource = this.Coleccion.Clientes;
            }
        }


        //Método para actualizar la Grilla
        private void actualizarGrilla()
        {
            try
            {
                dgridCliente.ItemsSource = this.coleccion.Clientes;
                dgridCliente.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay nada que actualizar");
            }
        }

        //Metodo Volver
        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            AdministrarCliente administrar = new AdministrarCliente();
            this.Close();
        }

        //Metodo Traspasar Datos
        private async void btnTraspasar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dgridCliente.SelectedItem;
                adm.txt_rut.Text = cliente._Rut;
                adm.Buscar();
            }
            catch (Exception ex)
            {

                await this.ShowMessageAsync("Error"," "+ex);
            }

        }

        //Método Eliminar 
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta =
               MessageBox.Show(
                   "Desea eliminar?",
                   "Eliminar",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Warning);
            if (respuesta == MessageBoxResult.Yes)
            {
                try
                {
                    Cliente cli = (Cliente)dgridCliente.SelectedItem;
                    bool resp = this.Coleccion.eliminarCliente(cli._Rut);
                    dgridCliente.Items.Refresh();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error no se ha podido eliminar");
                }
            }
            else
            {
                MessageBox.Show("Operacion Cancelada");
            }

        }
    }
}
