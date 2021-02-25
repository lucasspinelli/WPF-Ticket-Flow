using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.Commands
{
    public class Cadastrar : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is UserViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (UserViewModel)parameter;
            User user = (User)viewModel.usuario.Clone();


            var pw = new Cadastro();
            pw.DataContext = user;
            pw.ShowDialog();

            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                viewModel.Users.Add(user);
                DBUser.addPB(user);

            }
        }
    }
}
