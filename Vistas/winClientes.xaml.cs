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
    /// Interaction logic for winClientes.xaml
    /// </summary>
    public partial class winClientes : Window
    {

        public winClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea guardar los datos cargados?", "Guardar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Cliente oCliente = new Cliente();

                oCliente.Cli_Apellido = txtApellidos.Text;
                oCliente.Cli_Nombre = txtNombres.Text;
                oCliente.Cli_Domicilio = txtDomicilio.Text;
                oCliente.Cli_Email = txtMail.Text;
                oCliente.Cli_Telefono = Convert.ToInt32(txtTel.Text.ToString());

                MessageBox.Show("Apellido/s: " + oCliente.Cli_Apellido + "\nNombre/s: " + oCliente.Cli_Nombre + "\nDomicilio: " + oCliente.Cli_Domicilio + "\nTelefono: " + oCliente.Cli_Telefono + "\nE-mail: " + oCliente.Cli_Email);
            }
        }
    }
}
