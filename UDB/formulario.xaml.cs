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

namespace UDB
{
    /// <summary>
    /// Lógica de interacción para formulario.xaml
    /// </summary>
    public partial class formulario : Window
    {
        public formulario()
        {
            InitializeComponent();
            cbo_tipo.Items.Add("Queja");
            cbo_tipo.Items.Add("Opinion");
            cbo_tipo.Items.Add("Felicitaciones");
            cbo_tipo.Items.Add("inscripcion");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
