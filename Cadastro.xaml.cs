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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
            Perfil.ItemsSource = Enum.GetValues(typeof(Model.Perfil)).Cast<Model.Perfil>();
        }

        public void OKbtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; 
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
