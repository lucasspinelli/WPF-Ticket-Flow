using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.CommandsBoleta
{
    public class DeletarBoleta : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as BoletaViewModel;
            return viewModel != null && viewModel.SelectedBoleta != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (BoletaViewModel)parameter;
            DBconecctionBole.deletePB(viewModel.SelectedBoleta);
            viewModel.Boletas.Remove(viewModel.SelectedBoleta);
            viewModel.SelectedBoleta = viewModel.Boletas.FirstOrDefault();
        }
    }
}
