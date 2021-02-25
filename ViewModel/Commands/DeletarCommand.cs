using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.Commands
{
    public class DeletarCommand : BaseCommand
    {

        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PreBoletaViewModel;
            return viewModel != null && viewModel.SelectedPreBoleta != null;
        }

        public override void Execute(object parameter)
        { 
            var viewModel = (PreBoletaViewModel)parameter;
            DBConnection.deletePB(viewModel.SelectedPreBoleta);
            viewModel.PreBoletas.Remove(viewModel.SelectedPreBoleta);
            viewModel.SelectedPreBoleta = viewModel.PreBoletas.FirstOrDefault();
        }
    }
}
