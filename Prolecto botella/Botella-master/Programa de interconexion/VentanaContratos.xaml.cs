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

namespace Programa_de_interconexion
{
    /// <summary>
    /// Lógica de interacción para VentanaContratos.xaml
    /// </summary>
    public partial class VentanaContratos : Window
    {
        public VentanaContratos()
        {
            InitializeComponent();
        }

        private void Boton_Regresar_Click(object sender, RoutedEventArgs e)
        {
            Programa_de_interconexion.MainWindow win2 = new Programa_de_interconexion.MainWindow();
            win2.Show();
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
