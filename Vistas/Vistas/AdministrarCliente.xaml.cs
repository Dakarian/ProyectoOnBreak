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
using BibliotecaClases;
using Controlador;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AdministrarCliente.xaml
    /// </summary>
    public partial class AdministrarCliente : MetroWindow
    {
        ColeccionCliente cole;
        Cliente clien = new Cliente();
        public AdministrarCliente()
        {
            InitializeComponent();
            cbo_actividad.ItemsSource = Enum.GetValues(typeof(Actividad));
            cbo_actividad.SelectedIndex = 0;
            cbo_empresa.ItemsSource = Enum.GetValues(typeof(Empresa));
            cbo_empresa.SelectedIndex = 0;
            cole = new ColeccionCliente();
        }

        private ColeccionCliente coleccion = new ColeccionCliente();

        private ListarCliente listar = new ListarCliente();

        //Botón Guardar Cliente
        private async void btn_grabarcli_Click(object sender, RoutedEventArgs e)
        {
            if (casillasLlenas() == true && largoRut() == true)
            {
                try
                {
                    string rut = txt_rut.Text;
                    string nombre = txt_nom.Text;
                    string razon = txt_razon.Text;
                    string mail = txt_email.Text;
                    string direccion = txt_direccion.Text;
                    int telefono = int.Parse(txt_telefono.Text);
                    clien._Actividad = (Actividad)cbo_actividad.SelectedIndex;
                    clien._Tipo = (Empresa)cbo_empresa.SelectedIndex;

                    Cliente cli = new Cliente()
                    {
                        _Rut = rut,
                        _NombreContacto = nombre,
                        _RazonSocial = razon,
                        _MailContacto = mail,
                        _Direccion = direccion,
                        _Telefono = telefono,
                        _Actividad = clien._Actividad,
                        _Tipo = clien._Tipo
                    };

                    bool resp = cole.agregarCliente(cli);
                    /*
                    cli._Rut = txt_rut.Text;
                    cli._NombreContacto = txt_nom.Text;
                    cli._RazonSocial = txt_razon.Text;
                    cli._MailContacto = txt_email.Text;
                    cli._Direccion = txt_direccion.Text;
                    cli._Telefono = int.Parse(txt_telefono.Text);
                    cli._Actividad = (Actividad)cbo_actividad.SelectedIndex;
                    cli._Tipo = (Empresa)cbo_empresa.SelectedIndex;
                    */
                    if (resp == true)
                    {
                        await this.ShowMessageAsync("Correcto", "Cliente Agregado");

                    }
                    else
                    {
                        await this.ShowMessageAsync("Error", "Cliente No Agregado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex);
                }
            }
        }

        //Método para verificar si las casillas están llenas
        private bool casillasLlenas()
        {
            if (txt_rut.Text == string.Empty || txt_rut.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Rut");
                txt_rut.Focus();
            }

            if (txt_nom.Text == string.Empty || txt_nom.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Nombre");
                txt_nom.Focus();
            }

            if (txt_razon.Text == string.Empty || txt_razon.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Razon Social");
                txt_razon.Focus();
            }

            if (txt_email.Text == string.Empty || txt_email.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Email");
                txt_email.Focus();
            }

            if (txt_direccion.Text == string.Empty || txt_direccion.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Direccion");
                txt_direccion.Focus();
            }

            if (txt_telefono.Text == string.Empty || txt_telefono.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Telefono");
                txt_telefono.Focus();
            }

            if (txt_rut.Text != string.Empty &&
               txt_nom.Text != string.Empty &&
               txt_razon.Text != string.Empty &&
               txt_email.Text != string.Empty &&
               txt_direccion.Text != string.Empty &&
               txt_telefono.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        //Evento de cambio en el textbox Rut
        private void Txt_rut_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            String rut;
            rut = formatoRut(txt_rut.Text);
            txt_rut.Text = rut;
            */
        }

        //Método formato Rut con guion y puntos
        public string formatoRut(string rut)
        {
            /*
            int cont = 0;
            string formato;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                formato = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    formato = rut.Substring(i, 1) + formato;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        formato = "." + formato;
                        cont = 0;
                    }
                }
                return formato;
                */
            return null;
        }

        //Evento para limitar ingreso sólo numérico
        private void Txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;

        }

        //Boton Limpiar
        private void Btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        //Metodo Limpiar
        private void limpiar()
        {
            txt_rut.Text = string.Empty;
            txt_nom.Text = string.Empty;
            txt_razon.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            cbo_actividad.SelectedIndex = 0;
            cbo_empresa.SelectedIndex = 0;
        }
        //Botón Buscar
        private void btn_buscar_click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Se manda el Listado a la otra ventana
                ListarCliente listar = new ListarCliente(this);
                listar.Coleccion = this.coleccion;
                listar.btnEliminar.IsEnabled = true;
                listar.btnTraspasar.IsEnabled = true;
                listar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Validación largo rut
        private bool largoRut()
        {
            if (txt_rut.Text.Length <= 12 && txt_rut.Text.Length >= 11)
            {
                try
                {
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cliente aún no registrado");
                }
                return false;
            }
            else
            {
                MessageBox.Show("Rellene la casilla rut porfavor");
                txt_rut.Focus();
                return false;
            }
        }

        //Método buscar
        public void Buscar()
        {
            try
            {
                Cliente cli = new Cliente();
                coleccion.buscarRut(txt_rut.Text);

                if (cli != null)
                {
                    //txt_rut.Text = cli._Rut;
                    txt_nom.Text = cli._NombreContacto;
                    txt_razon.Text = cli._RazonSocial;
                    txt_email.Text = cli._MailContacto;
                    txt_direccion.Text = cli._Direccion;
                    txt_telefono.Text = cli._Telefono.ToString();
                    cbo_actividad.SelectedIndex = (int)cli._Actividad;
                    cbo_empresa.SelectedIndex = (int)cli._Actividad;
                }
                else
                {
                    MessageBox.Show("No se encuentra el Cliente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Buscar: ");
            }

        }

        //Boton Modificar
        private async void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string rut = txt_rut.Text;
                Cliente cli = coleccion.buscarRut(rut);
                MessageBoxResult respuesta =
                MessageBox.Show(
                   "¿Desea Modificar Cliente: " + cli._Rut + " ?",
                   "Modificar",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Warning);
                if (respuesta == MessageBoxResult.Yes)
                {
                    Modificar();
                    await this.ShowMessageAsync("Correcto", "Cliente Modificado");
                }
                else
                {
                    await this.ShowMessageAsync("Cancelado", "No se han realizado cambios");
                }
                /*if (this.coleccion.agregarCliente(cli))
                {
                    MessageBox.Show("Cliente Modificado", "Actualizo");
                }*/
            }
            catch (Exception)
            {

                await this.ShowMessageAsync("Error al Modificar", "Revise Rut");
                txt_rut.Focus();
            }


        }

        //método modificar
        public void Modificar()
        {
            string rut = txt_rut.Text;
            Cliente cli = coleccion.buscarRut(rut);

            //cli._Rut = txt_rut.Text;
            cli._NombreContacto = txt_nom.Text;
            cli._RazonSocial = txt_razon.Text;
            cli._MailContacto = txt_email.Text;
            cli._Direccion = txt_direccion.Text;
            cli._Telefono = int.Parse(txt_telefono.Text);
            cli._Actividad = (Actividad)cbo_actividad.SelectedIndex;
            cli._Tipo = (Empresa)cbo_empresa.SelectedIndex;
            //await this.ShowMessageAsync("Correcto", "Contrato inhabilitado");
        }

        //Botón Volver
        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }


    }
}

