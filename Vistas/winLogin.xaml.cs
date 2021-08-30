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

        private void UsrGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserLogin.Text == "Usuario")
            {
                txtUserLogin.Text = "";
                txtUserLogin.Foreground = Brushes.Black;
            }
            else
            {
                txtUserLogin.Foreground = Brushes.Black;
            }

        }

        private void PwdGotFocus(object sender, RoutedEventArgs e)
        {
            if (pwdPassLogin.Password == "PWD")
            {
                pwdPassLogin.Password = "";
                pwdPassLogin.Foreground = Brushes.Black;
            }
            else
            {
                pwdPassLogin.Foreground = Brushes.Black;
            }

        }


        private void UsrLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserLogin.Text != "")
            {
                txtUserLogin.Foreground = Brushes.DarkSlateGray;
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
                pwdPassLogin.Foreground = Brushes.DarkSlateGray;
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
                MessageBox.Show("Sesión iniciada como Administrador", "Bienvenuti", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (txtUserLogin.Text == "Mozo" && pwdPassLogin.Password == "123")
                {
                    MessageBox.Show("Sesión iniciada como Mozo", "Bienvenuti", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Contraseña y/o Usuario inválidos", "vos sos inválido", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
