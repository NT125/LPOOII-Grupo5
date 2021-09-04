﻿using System;
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
            rb1.IsChecked = true;

        }

        private void btnArticulos_Click(object sender, RoutedEventArgs e)
        {
            winArticulos winArticulos = new winArticulos();
            winArticulos.Show();
            this.Close();
        }


        private void informacionClick(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {

            }
            else
            {

            }
           
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




    }
}
