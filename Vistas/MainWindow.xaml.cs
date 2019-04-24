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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Behaviours;
using MahApps.Metro.Actions;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, RoutedEventArgs e)
        {
            AdministrarCliente ac = new AdministrarCliente();
            this.Hide();
            ac.Show();
        }

        private void btn_contratos_Click(object sender, RoutedEventArgs e)
        {
            AdministrarContrato ac = new AdministrarContrato();
            this.Hide();
            ac.Show();
        }

        private void btn_listarcli_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente lc = new ListarCliente();
            lc.btnEliminar.IsEnabled = false;
            lc.btnTraspasar.IsEnabled = false;
            lc.Show();
        }

        private void btn_listarcon_Click(object sender, RoutedEventArgs e)
        {
            ListarContrato lc = new ListarContrato();
            lc.Show();
        }
    }
}
