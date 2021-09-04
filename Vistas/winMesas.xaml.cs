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
    /// Interaction logic for winMesas.xaml
    /// </summary>
    public partial class winMesas : Window
    {
        public winMesas()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnMesa11.Background = Brushes.Red;
            btnMesa11.Foreground = Brushes.White;
            btnMesa17.Background = Brushes.Red;
            btnMesa17.Foreground = Brushes.White; 
        }

    
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            btnMesa17.Background = Brushes.Green;
            btnMesa11.Background = Brushes.Green;
        }

        private void preguntarMesa(object sender, RoutedEventArgs e)
        {
            Button mesa=sender as Button;
            if (mesa.Background == Brushes.Red)
            {
                MessageBox.Show("Esta mesa esta Ocupada");
            }else{
                MessageBox.Show("Esta mesa esta Desocupada");
            }
        }

        
    }
}
