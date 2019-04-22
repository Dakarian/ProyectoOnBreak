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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ListarContrato.xaml
    /// </summary>
    public partial class ListarContrato : MetroWindow
    {
        private ColeccionCliente ccli = new ColeccionCliente();
        private ColeccionContrato ccontrato = new ColeccionContrato();
        private ColeccionTipo ctipo = new ColeccionTipo();
        Contrato con = new Contrato();
        Tipo tip = new Tipo();

        public ListarContrato()
        {
            InitializeComponent();
            dg_contrato.ItemsSource = ccontrato.Listar();
        }
        //filtro por contrato
        private void txt_filtrocon_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (txt_filtrocon.Text.Length > 0)
            {
                string numcontrato = txt_filtrocon.Text.ToLower();
                string contratobuscado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(numcontrato);
                var posicion = this.ccontrato.Contrato.Where(r => r._NumeroContrato.ToString().Contains(contratobuscado)).ToList();
                dg_contrato.ItemsSource = posicion;
            }
            else
            {
                dg_contrato.ItemsSource = this.ccontrato.Contrato;
            }


        
        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
            
        }

        private void txt_filtroev_TextChanged(object sender, TextChangedEventArgs e)
        {

 
            if (txt_filtroev.Text.Length > 0)
            {
                string nombre = txt_filtroev.Text.ToLower();
                string eventobuscado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
                var Posicion = this.ctipo.Tips.Where(r => r._Nombre.ToString().Contains(eventobuscado)).ToList();
                dg_contrato.ItemsSource = Posicion;
            }
            else
            {
                dg_contrato.ItemsSource = this.ctipo.Tips;
            }
        }

        private void btn_actualizargrid_Click(object sender, RoutedEventArgs e)
        {
            dg_contrato.ItemsSource = this.ccontrato.Contrato;
            dg_contrato.Items.Refresh();
        }

        private async void btn_vigencia_Click(object sender, RoutedEventArgs e)
        {
          
                    await this.ShowMessageAsync("Advertencia", "¿Realmente desea quitar la vigencia del contrato?", MessageDialogStyle.AffirmativeAndNegative);
                    MessageDialogResult dr = new MessageDialogResult();
                    if (dr == MessageDialogResult.Affirmative)
                    {
                            if (this.con._EstaVigente == true)
                            {
                                this.con._EstaVigente = false;
                            }
                        dg_contrato.ItemsSource = this.ccontrato.Contrato;
                        dg_contrato.Items.Refresh();

                        await this.ShowMessageAsync("Correcto", "Contrato inhabilitado");


                    }
                    else if (dr == MessageDialogResult.Negative)
                    {
                        await this.ShowMessageAsync("Fallo", "Cambios anulados");
                    }
                }

               
            }
            
            
                
        }
    

