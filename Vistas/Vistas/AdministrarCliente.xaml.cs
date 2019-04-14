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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AdministrarCliente.xaml
    /// </summary>
    public partial class AdministrarCliente : MetroWindow
    {
        private ColeccionCliente coleccion = new ColeccionCliente();
        public AdministrarCliente()
        {
            InitializeComponent();
            cbo_actividad.ItemsSource = Enum.GetValues(typeof(Actividad));
            cbo_actividad.SelectedIndex = 0;
            cbo_empresa.ItemsSource = Enum.GetValues(typeof(Empresa));
            cbo_empresa.SelectedIndex = 0;
        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();


            this.Close();
            mw.Show();

        }

        private async void btn_grabarcli_Click(object sender, RoutedEventArgs e)
        {
            if (txt_rut.Text == string.Empty || txt_rut.Text == " " )
            {
                MessageBox.Show("Porfavor rellene la casilla Rut");
            }

            if (txt_nom.Text == string.Empty || txt_nom.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Nombre");
            }

            if (txt_email.Text == string.Empty || txt_email.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Email");
            }

            if (txt_telefono.Text == string.Empty || txt_telefono.Text == " ")
            {
                MessageBox.Show("Porfavor rellene la casilla Telefono");
            }


            Cliente cli = new Cliente();

            cli._Rut = txt_rut.Text;
            cli._NombreContacto = txt_nom.Text;
            cli._MailContacto = txt_email.Text;
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




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt_rut.Text = "";
            txt_nom.Text = string.Empty;
        }

        private void Txt_rut_TextChanged(object sender, TextChangedEventArgs e)
        {
            String rut;
            rut = formatoRut(txt_rut.Text);
            txt_rut.Text = rut;
        }

        //formato Rut con guion y puntos
        public string formatoRut(string rut)
        {
            int contador = 0;
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
                    formato = rut.Substring(i, 1)+formato;
                    contador++;
                    if (contador == 3 && i != 0)
                    {
                        formato = "." + formato;
                        contador = 0;
                    }
                }
                return formato;
            }
        }
            //evento para limitar ingreso sólo numérico

            private void Txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true; 
                
        }
    }
}
