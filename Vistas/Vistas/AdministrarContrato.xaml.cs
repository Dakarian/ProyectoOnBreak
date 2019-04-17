﻿using BibliotecaClases;
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


        private async void btn_valorp_Click(object sender, RoutedEventArgs e)
        {
            int valorp = 0;
            double uf = 27593.58;
            if (txt_cantp.Text!="")
            {
                valorp = int.Parse(txt_cantp.Text);
            }
            else
            {
                await this.ShowMessageAsync("Error","Por favor ingrese un valor numérico en el campo");
            }
            
            if (valorp>=1 && valorp<=20)
            {
                txt_valorp.Text = (uf*3).ToString();
            }
            if (valorp >= 21 && valorp <= 50)
            {
                txt_valorp.Text = (uf * 5).ToString();
            }
            if (valorp > 50)
            {
                double valoracum = (uf * 5);
                for (int x = 50; x <= valorp; x+=20)
                {
                    valoracum = valoracum + (uf * 2);
                }
                txt_valorp.Text = valoracum.ToString();
            }
        }


        private async void btn_adicional_Click(object sender, RoutedEventArgs e)
        {
            int canta = 0;
            double uf = 27593.58;
            if (txt_cantp.Text != "")
            {
                canta = int.Parse(txt_canta.Text);
            }
            else
            {
                await this.ShowMessageAsync("Error", "Por favor ingrese un valor numérico en el campo");
            }
            

            if (canta < 2)
            {
                txt_valora.Text = 0.ToString();
            }

            if (canta == 2)
            {
                txt_valora.Text = (uf * 2).ToString();
            }
            if (canta == 3)
            {
                txt_valora.Text = (uf * 3).ToString();
            }
            if (canta == 4)
            {
                txt_valora.Text = (uf * 4).ToString();
            }
            if (canta > 4)
            {
                double valoracumulado = (uf*3.5);
                for (int x = 4; x <= canta; x++)
                {
                    valoracumulado = valoracumulado + (uf * 0.5);
                }
                txt_valora.Text = valoracumulado.ToString();
            }
        }

        private async void btn_valorizar_Click(object sender, RoutedEventArgs e)
        {
            int ValorBase = 0;
            //llenar datos de tipo
            if ((int)cbo_evento.SelectedItem == 0)
            {
                await this.ShowMessageAsync("Advertencia", "Selecciona un Tipo de Evento");
                cbo_evento.Focus();
                return;
            }
            if ((int)cbo_evento.SelectedItem == 1)
            {
                ValorBase = 15000;
                txt_vevento.Text = ValorBase.ToString(); ;

            }
            if ((int)cbo_evento.SelectedItem == 2)
            {
                ValorBase = 20000;
                txt_vevento.Text = ValorBase.ToString();
            }
            if ((int)cbo_evento.SelectedItem == 3)
            {
                ValorBase = 30000;
                txt_vevento.Text = ValorBase.ToString();
            }
            if ((int)cbo_evento.SelectedItem == 4)
            {
                ValorBase = 40000;
                txt_vevento.Text = ValorBase.ToString();
            }
            //llenar datos de tipo
        }

        private async void btn_total_Click(object sender, RoutedEventArgs e)
        {
            double valortotal = 0;
            
            
            
            if (txt_vevento.Text == "")
            {
                await this.ShowMessageAsync("Error", "Valora el tipo de evento seleccionado");
            }
            else
            {
                int vbase = int.Parse(txt_vevento.Text);
                if (txt_valorp.Text == "")
                {
                    await this.ShowMessageAsync("Error", "Valoriza la cantidad de personas que asistirán");
                }
                else
                {
                    double vper = double.Parse(txt_valorp.Text);
                    if (txt_valora.Text == "")
                    {
                        await this.ShowMessageAsync("Error", "Valoriza el personal adicional");
                    }
                    else
                    {
                        double vad = double.Parse(txt_valora.Text);
                        valortotal = vbase + vper + vad;
                        txt_total.Text = valortotal.ToString();
                    }
                }
            }
           

        

            

        }


        private async void btn_grabar_Click(object sender, RoutedEventArgs e)
        {
            Contrato con = new Contrato();
            try
            {
                /*
                //variables
                int Id = 0;
                string Nombre = "";
                int ValorBase = 0;
                int PersonalBase = 0;
                double uf = 27593.58;
                int cant_personas = 0;

                // como agregar valores base?
                

                    if?


                 */

                //datos que no dependen del usuario autofill
                con._NumeroContrato = float.Parse(txt_numcontrato.Text);
                con._Creacion = (DateTime)dp_creacion.SelectedDate;
                DateTime termino = con._Creacion.AddMonths(1);
                con._Termino = termino;
                DateTime horaini = DateTime.Now;
                string fhoraini = horaini.ToString("HH:mm");
                con._FechaHoraInicio = fhoraini;
                DateTime horafin = horaini.AddMonths(1);
                con._FechaHoraTermino = horafin;
                if (txt_direccion.Text.Equals(""))
                {
                    await this.ShowMessageAsync("¡Error!", "El campo no puede estar nulo");
                }
                else
                {
                    con._Direccion = txt_direccion.Text;
                }

                if (ckbox_vigente.IsChecked == true)
                {
                    con._EstaVigente = true;
                }
                else
                {
                    con._EstaVigente = false;
                }
                if (txt_obs.Text.Equals(""))
                {
                    await this.ShowMessageAsync("¡Error!", "Añada una observación");
                }
                else
                {
                    con._Observaciones = txt_obs.Text;

                }

                bool resp = ccontrato.agregarContrato(con);

                if (resp == true)
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
                await this.ShowMessageAsync("error", "" + ex);
                actualizarGrid();
            }
        }

        }


    }

