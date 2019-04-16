using BibliotecaClases;
using Controlador;
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
        private ColeccionContrato ccontrato = new ColeccionContrato();

        


        public AdministrarContrato()
        {
            InitializeComponent();
            String numcontrato = DateTime.Now.ToString("yyyyMMddHHmm");
            txt_numcontrato.Text = numcontrato;

            dp_creacion.SelectedDate = DateTime.Today;

            DateTime horaini = DateTime.Now;
            string fhoraini = horaini.ToString("HH:mm");
            txt_hrini.Text = fhoraini;

            cbo_evento.ItemsSource = Enum.GetValues(typeof(Evento));
            cbo_evento.SelectedIndex = 0;

        }

        private void actualizarGrid()
        {
            dg_contrato.ItemsSource = ccontrato.Contrato;
            dg_contrato.Items.Refresh();

        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }










        private async void btn_grabar_Click(object sender, RoutedEventArgs e)
        {
            Contrato con = new Contrato();
            Tipo tipo = new Tipo();
            try
            {
                

                //datos que depende del usuario no debe ser nulo
                if (txt_direccion.Text.Equals(""))
                {
                    await this.ShowMessageAsync("¡Error!", "El campo no puede estar nulo");
                }
                else
                {
                    con._Direccion = txt_direccion.Text;
                }
                //otro dato
                if (txt_obs.Text.Equals(""))
                {
                    await this.ShowMessageAsync("¡Error!", "Añada una observación");
                }
                else
                {
                    con._Observaciones = txt_obs.Text;
                    
                }




                //variables
                int Id = 0;
                string Nombre = "";
                int ValorBase = 0;
                int PersonalBase = 0;
                double uf = 27593.58;
                int cant_personas = 0;

                // como agregar valores base?
                /*

                    if?


                 */
                if ((int)cbo_evento.SelectedItem == 0)
                {
                    await this.ShowMessageAsync("Advertencia", "Selecciona un Tipo de Evento");
                    cbo_evento.Focus();
                    return;
                }
                if ((int)cbo_evento.SelectedItem == 1)
                {
                    ValorBase = 15000;

                }
                if ((int)cbo_evento.SelectedItem == 2)
                {
                    ValorBase = 20000;
                }
                if ((int)cbo_evento.SelectedItem == 3)
                {
                    ValorBase = 30000;
                }
                if ((int)cbo_evento.SelectedItem == 4)
                {
                    ValorBase = 40000;
                }













                //datos que no dependen del usuario autofill
                con._NumeroContrato = int.Parse(txt_numcontrato.Text);
                con._Creacion = (DateTime)dp_creacion.SelectedDate;
                DateTime termino = con._Creacion.AddMonths(1);
                con._Termino = termino;
                DateTime horaini = DateTime.Now;
                string fhoraini = horaini.ToString("HH:mm");
                con._FechaHoraInicio = fhoraini;
                DateTime horafin = horaini.AddMonths(1);
                con._FechaHoraTermino = horafin;

                if (ckbox_vigente.IsChecked == true)
                {
                    con._EstaVigente = true;
                }
                else
                {
                    con._EstaVigente = false;
                }

                if (ccontrato.agregarContrato(con))
                {
                    await this.ShowMessageAsync("Confirmar", "Contrato Agregado Correctamente");
                }
                else
                {
                    await this.ShowMessageAsync("Error", "Contrato ya existe");
                }

                actualizarGrid();

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("error","no especificado, no se ha grabado nada");
                actualizarGrid();
            }
        }
    }
}
