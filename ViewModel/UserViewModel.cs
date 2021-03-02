﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;
namespace Boletas.ViewModel
{
    public class UserViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.User> Users { get; private set; }

        public User usuario { get; set; }

        public RelayCommand CommandCadastrar { get; set; }



        public UserViewModel()
        {
            ConnectionDB.createDB();
            usuario = new User();
            Users = new ObservableCollection<Model.User>(ConnectionDB.getListUser());
            CommandCadastrar = new RelayCommand(Cadastrar);
        }

        private void Cadastrar()
        {
            var user = new Model.User();


            var uw = new Cadastro();
            uw.DataContext = user;
            uw.ShowDialog();

            if (uw.DialogResult.HasValue && uw.DialogResult.Value)
            {
                Users.Add(user);
                ConnectionDB.add(user);
            }
        }
    }

}
