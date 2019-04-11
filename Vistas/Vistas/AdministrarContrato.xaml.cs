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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AdministrarContrato.xaml
    /// </summary>
    public partial class AdministrarContrato : Window
    {
        public AdministrarContrato()
        {
            InitializeComponent();
            String numcontrato = DateTime.Now.ToString("yyyyMMddHHmm");
            txt_numcontrato.Text = numcontrato;

            dp_creacion.SelectedDate = DateTime.Today;

            
            DateTime termino = DateTime.Today.AddMonths(1);
            string formato = termino.ToString("dd/MM/yyyy");
            txt_termino.Text = formato;

            DateTime horaini = DateTime.Now;
            string fhoraini = horaini.ToString("HH:mm");
            txt_hrini.Text = fhoraini;

            DateTime horafin = DateTime.Now.AddMonths(1);
            string fhorafin = horafin.ToString("HH:mm");
            txt_hrfin.Text = fhorafin;

        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
