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
using BibliotecaClases;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AdministrarCliente.xaml
    /// </summary>
    public partial class AdministrarCliente : Window
    {
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

        private void btn_grabarcli_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
