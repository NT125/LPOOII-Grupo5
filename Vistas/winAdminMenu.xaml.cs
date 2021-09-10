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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for winAdminMenu.xaml
    /// </summary>
    public partial class winAdminMenu : Window
    {
        public winAdminMenu()
        {
            InitializeComponent();
            ocultarGrid();
            rb1.IsChecked = true;
            logoholdem.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnArticulos_Click(object sender, RoutedEventArgs e)
        {
            winArticulos winArticulos = new winArticulos();
            winArticulos.Show();
            this.Close();
        }


        private void rb1_MouseEnter(object sender, MouseEventArgs e)
        {
            ocultarGrid();
            logoholdem.Visibility = System.Windows.Visibility.Visible;
            rb1.IsChecked = true;
        }

        private void rb2_MouseEnter(object sender, MouseEventArgs e)
        {
            ocultarGrid();
            griditem.Visibility = System.Windows.Visibility.Visible;
            rb2.IsChecked = true;
        }

        private void rb3_MouseEnter(object sender, MouseEventArgs e)
        {
            ocultarGrid();
            grdArticulo.Visibility = System.Windows.Visibility.Visible;
            rb3.IsChecked = true;
        }

        private void rb4_MouseEnter(object sender, MouseEventArgs e)
        {
            ocultarGrid();
            grdFamilia.Visibility = System.Windows.Visibility.Visible;
            rb4.IsChecked = true;
        }

        private void rb5_MouseEnter(object sender, MouseEventArgs e)
        {

            ocultarGrid();
            grdCategoria.Visibility = System.Windows.Visibility.Visible;
            rb5.IsChecked = true;
        }

        private void rb6_MouseEnter(object sender, MouseEventArgs e)
        {
            ocultarGrid();
            grdUnidad.Visibility = System.Windows.Visibility.Visible;
            rb6.IsChecked = true;
        }

        private void ocultarGrid() {
            logoholdem.Visibility = System.Windows.Visibility.Collapsed;
            griditem.Visibility = System.Windows.Visibility.Collapsed;
            grdArticulo.Visibility = System.Windows.Visibility.Collapsed;
            grdFamilia.Visibility = System.Windows.Visibility.Collapsed;
            grdCategoria.Visibility = System.Windows.Visibility.Collapsed;
            grdUnidad.Visibility = System.Windows.Visibility.Collapsed;
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

        private void rb3_Click(object sender, RoutedEventArgs e)
        {
            winArticulos winArticulos = new winArticulos();
            winArticulos.Show();
        }

        private void rb6_Click(object sender, RoutedEventArgs e)
        {
            winMesas winMesas = new winMesas();
            winMesas.Show();
        }

        private void rb5_Click(object sender, RoutedEventArgs e)
        {
            winClientes winClientes = new winClientes();
            winClientes.Show();
        }


    }
}
