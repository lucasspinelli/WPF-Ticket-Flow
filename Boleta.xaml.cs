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
using Boletas.ViewModel;

namespace Boletas
{
    /// <summary>
    /// Lógica interna para Boleta.xaml
    /// </summary>
    public partial class Boleta : Window
    {
        public Boleta()
        {
            InitializeComponent();
            DataContext = new BoletaViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
