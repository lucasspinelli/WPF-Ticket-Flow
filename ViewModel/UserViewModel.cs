using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;
using Boletas.ViewModel.Commands;

namespace Boletas.ViewModel
{
    public class UserViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.User> Users { get; private set; }

        public User usuario { get; set; }
        public Cadastrar FazerCadastro { get; private set; } = new Cadastrar();

        public UserViewModel()
        {
            DBUser.createDB();
            usuario = new User();
            Users = new ObservableCollection<Model.User>(DBUser.getListPB());
        }
    }
}
