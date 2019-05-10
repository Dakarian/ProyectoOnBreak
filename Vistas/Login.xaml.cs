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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_inisesion_Click(object sender, RoutedEventArgs e)
        {
            if (txt_user.Text == "admin" && pw_pass.Password == "1234")
            {
                MainWindow mw = new MainWindow();
                await this.ShowMessageAsync("Éxito", "Bienvenido a On Break");
                this.Close();
                mw.Show();
            }
            else
            {
                await this.ShowMessageAsync("Error", "Usuario y/o contraseña incorrectos");
                txt_user.Focus();
                pw_pass.Focus();
            }
        }
    }
}
