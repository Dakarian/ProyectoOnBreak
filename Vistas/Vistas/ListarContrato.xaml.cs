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
using Controlador;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ListarContrato.xaml
    /// </summary>
    public partial class ListarContrato : Window
    {
        ColeccionContrato ccon = new ColeccionContrato();
        public ListarContrato()
        {
            InitializeComponent();
            dg_contrato.ItemsSource = ccon.Listar();
        }
    }
}
