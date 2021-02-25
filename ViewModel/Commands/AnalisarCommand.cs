using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.Commands
{
    public class AnalisarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PreBoletaViewModel;
            return viewModel != null && viewModel.SelectedPreBoletasPendentes != null;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (PreBoletaViewModel)parameter;
            var preBoletaClone = (Model.PreBoleta)viewModel.SelectedPreBoletasPendentes.Clone();
            var apbw = new AnalisePB();
            apbw.DataContext = preBoletaClone;
            apbw.ShowDialog();

            if (apbw.DialogResult.HasValue && apbw.DialogResult.Value)
            {
                viewModel.SelectedPreBoletasPendentes.status = preBoletaClone.status;
                DBConnection.updatePB(preBoletaClone);
                if (preBoletaClone.status == Status.APROVADA)
                { 
                    viewModel.PreBoletasAprovadas.Add(preBoletaClone);
                    viewModel.PreBoletasPendentes.Remove(viewModel.SelectedPreBoletasPendentes);

                } else if (preBoletaClone.status == Status.REPROVADA)
                {
                    viewModel.PreBoletasReprovadas.Add(preBoletaClone);
                    viewModel.PreBoletasPendentes.Remove(viewModel.SelectedPreBoletasPendentes);
                }

    
            }
        }
    }
}

