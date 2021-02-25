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
    /// Lógica interna para Gestor.xaml
    /// </summary>
    public partial class Gestor : Window
    {
        public Gestor()
        {
            InitializeComponent();
            DataContext = new PreBoletaViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
