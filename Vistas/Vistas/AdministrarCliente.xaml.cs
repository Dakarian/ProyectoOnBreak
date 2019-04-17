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
        public AdministrarCliente()
        {
            InitializeComponent();
            cbo_actividad.ItemsSource = Enum.GetValues(typeof(Actividad));
            cbo_actividad.SelectedIndex = 0;
            cbo_empresa.ItemsSource = Enum.GetValues(typeof(Empresa));
            cbo_empresa.SelectedIndex = 0;
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
                    Cliente cli = new Cliente();

                    cli._Rut = txt_rut.Text;
                    cli._NombreContacto = txt_nom.Text;
                    cli._RazonSocial = txt_razon.Text;
                    cli._MailContacto = txt_email.Text;
                    cli._Direccion = txt_direccion.Text;
                    cli._Telefono = int.Parse(txt_telefono.Text);
                    cli._Actividad = (Actividad)cbo_actividad.SelectedIndex;
                    cli._Tipo = (Empresa)cbo_empresa.SelectedIndex;

                    if (this.coleccion.agregarCliente(cli))
                    {
                        await this.ShowMessageAsync("Confirmar", "Cliente Agregado Correctamente");
                    }
                    else
                    {
                        await this.ShowMessageAsync("Error", "Cliente ya existe");
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
            }

            if (txt_nom.Text == string.Empty || txt_nom.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Nombre");
            }

            if (txt_razon.Text == string.Empty || txt_razon.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Razon Social");
            }

            if (txt_email.Text == string.Empty || txt_email.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Email");
            }

            if (txt_direccion.Text == string.Empty || txt_direccion.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Direccion");
            }

            if (txt_telefono.Text == string.Empty || txt_telefono.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Telefono");
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
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
            */
            return rut;
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
                listar.Coleccion = this.coleccion;
                listar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

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
                return false;
            }
        }

        public void Buscar()
        {
            try
            {
                Cliente cli = new Cliente();
                coleccion.buscarRut(txt_rut.Text);

                if (cli != null)
                {
                    txt_rut.Text = cli._Rut;
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

        //Botón Volver
        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();

            this.Close();
            mw.Show();
        }

        private void Btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string rut = txt_rut.Text;
                Cliente cli = coleccion.buscarRut(rut);

                cli._Rut = txt_rut.Text;
                cli._NombreContacto = txt_nom.Text;
                cli._RazonSocial = txt_razon.Text;
                cli._MailContacto = txt_email.Text;
                cli._Direccion = txt_direccion.Text;
                cli._Telefono = int.Parse(txt_telefono.Text);
                cli._Actividad = (Actividad)cbo_actividad.SelectedIndex;
                cli._Tipo = (Empresa)cbo_empresa.SelectedIndex;
                if (this.coleccion.agregarCliente(cli))
                {
                    MessageBox.Show("Cliente Modificado", "Actualizo");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Modificar", "Revise Rut");
                limpiar();
            }


        }
    }
}

