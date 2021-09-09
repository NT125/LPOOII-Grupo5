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
    /// Interaction logic for winArticulos.xaml
    /// </summary>
    public partial class winArticulos : Window
    {
        public winArticulos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea guardar los datos cargados?", "Guardar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes){
                Articulos oArticulo = new Articulos();

                MessageBox.Show("Familia: " + cboFlia.SelectedValue + "\nUnidad de medida: " + cboMedida.SelectedValue + "\nPrecio: " + txtPrecio.Text + "\nStock: " + chkStock.IsChecked + "\nDescripcion: " + oArticulo.Art_Descrip);
            }
            
        }
    }
}
