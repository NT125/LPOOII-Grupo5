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
        Articulos oArticulos = new Articulos();
        

        public winArticulos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //oArticulos.Fam_ID = cboFlia.SelectedValue;
            //oArticulos.Art_Precio = Convert.ToInt32(txtPrecio.Text);
            //oArticulos.Art_Descrip = txtDescripcion.Text;

            MessageBoxResult result = MessageBox.Show("Desea guardar los datos cargados?", "Guardar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes){
                MessageBox.Show("Familia: " + cboFlia.SelectedValue + "\nUnidad de medida: " + cboMedida.SelectedValue + "\nPrecio: " + txtPrecio.Text + "\nStock: " + chkStock.IsChecked + "\nDescripcion: " + oArticulos.Art_Descrip);
            }
            
        }
    }
}
