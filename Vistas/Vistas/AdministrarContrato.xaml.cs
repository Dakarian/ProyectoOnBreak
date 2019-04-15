using BibliotecaClases;
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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AdministrarContrato.xaml
    /// </summary>
    public partial class AdministrarContrato : MetroWindow
    {
        public AdministrarContrato()
        {
            InitializeComponent();
            String numcontrato = DateTime.Now.ToString("yyyyMMddHHmm");
            txt_numcontrato.Text = numcontrato;

            dp_creacion.SelectedDate = DateTime.Today;

            DateTime horaini = DateTime.Now;
            string fhoraini = horaini.ToString("HH:mm");
            txt_hrini.Text = fhoraini;

            
           

        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void btn_grabar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Contrato con = new Contrato();
                con._NumeroContrato = int.Parse(txt_numcontrato.Text);
                con._Creacion = (DateTime)dp_creacion.SelectedDate;
                DateTime termino = con._Creacion.AddMonths(1);
                con._Termino = termino;
                DateTime horaini = DateTime.Now;
                string fhoraini = horaini.ToString("HH:mm");
                con._FechaHoraInicio = fhoraini;
                DateTime horafin = horaini.AddMonths(1);
                con._FechaHoraTermino = horafin;
                con._Direccion = txt_direccion.Text;



            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
