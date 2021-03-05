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
using Boletas.Model;
using Boletas.ViewModel;

namespace Boletas
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Logar(object sender, RoutedEventArgs e)
        {
            DBInterface connection = new GetConnection().GetDBConnection();
           if (connection.validateUser(TBusuario.Text, TBsenha.Text))
            {
                var perfil = connection.findUserProfile(TBusuario.Text);
                switch (perfil)
                {
                    case Model.Perfil.SUDO:
                        SUDO sudo = new SUDO();
                        sudo.ShowDialog();
                        break;
                    case Model.Perfil.GESTOR:
                        Gestor gestor = new Gestor();
                        gestor.ShowDialog();
                        break;
                    case Model.Perfil.SUPERVISOR:
                        Supervisor supervisor = new Supervisor();
                        supervisor.ShowDialog();
                        break;
                    case Model.Perfil.TRADER:
                        Boleta trader = new Boleta();
                        trader.ShowDialog();
                        break;
                } 
                
           } else
            {
                MessageBox.Show("Deu certo n");
            }
           
        }

    }
}
