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

namespace Boletas
{
    /// <summary>
    /// Lógica interna para BoletaTW.xaml
    /// </summary>
    public partial class BoletaTW : Window
    {
        public BoletaTW()
        {
            InitializeComponent();
            GrupoCarteiras.ItemsSource = Enum.GetValues(typeof(Model.GrupoCarteiras)).Cast<Model.GrupoCarteiras>();
            Acoes.ItemsSource = Enum.GetValues(typeof(Model.Acoes)).Cast<Model.Acoes>();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
