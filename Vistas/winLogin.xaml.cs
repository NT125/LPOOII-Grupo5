using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for winLogin.xaml
    /// </summary>
    public partial class winLogin : Window
    {
        public winLogin()
        {
            InitializeComponent();

            string user1 = "Admin";
            string pass1 = "123";

            string user2 = "Mozo";
            string pass2 = "123";

            txtUserLogin.Text = "Usuario";
            txtUserLogin.Foreground = Brushes.Gray;

            pwdPassLogin.Password = "PWD";
            pwdPassLogin.Foreground = Brushes.Gray;
        }

        private void moveWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimizeWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        private void closeWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        private void UsrGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserLogin.Text == "Usuario")
            {
                txtUserLogin.Text = "";
                txtUserLogin.Foreground = Brushes.White;
            }
            else
            {
                txtUserLogin.Foreground = Brushes.White;
            }

        }

        private void PwdGotFocus(object sender, RoutedEventArgs e)
        {
            if (pwdPassLogin.Password == "PWD")
            {
                pwdPassLogin.Password = "";
                pwdPassLogin.Foreground = Brushes.White;
            }
            else
            {
                pwdPassLogin.Foreground = Brushes.White;
            }

        }


        private void UsrLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserLogin.Text != "")
            {
                txtUserLogin.Foreground = Brushes.LightGray;
            }
            else
            {
                txtUserLogin.Text = "Usuario";
                txtUserLogin.Foreground = Brushes.Gray;
            }
        }

        private void PwdLostFocus(object sender, RoutedEventArgs e)
        {
            if (pwdPassLogin.Password != "")
            {
                pwdPassLogin.Foreground = Brushes.LightGray;
            }
            else
            {
                pwdPassLogin.Password = "PWD";
                pwdPassLogin.Foreground = Brushes.Gray;
            }
        }

        private void login(object sender, RoutedEventArgs e)
        {
            if (txtUserLogin.Text == "Admin" && pwdPassLogin.Password == "123")
            {
                MessageBox.Show("Sesión iniciada como Administrador", "Bienvenido", MessageBoxButton.OK, MessageBoxImage.Information);
                winAdminMenu winAdminMenu = new winAdminMenu();
                winAdminMenu.Show();
                this.Close();
            }
            else
            {
                if (txtUserLogin.Text == "Mozo" && pwdPassLogin.Password == "123")
                {
                    MessageBox.Show("Sesión iniciada como Mozo", "Bienvenido", MessageBoxButton.OK, MessageBoxImage.Information);
                    winWaiterMenu winMozoVendedorMenu = new winWaiterMenu();
                    winMozoVendedorMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña y/o Usuario inválidos", "vos sos inválido", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
