using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.Commands
{
    public class EditarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PreBoletaViewModel;
            return viewModel != null && viewModel.SelectedPreBoleta != null;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (PreBoletaViewModel)parameter;
            var preBoletaClone = (Model.PreBoleta)viewModel.SelectedPreBoleta.Clone();
            var pbw = new PreBoleta();
            pbw.DataContext = preBoletaClone;
            pbw.ShowDialog();

            if(pbw.DialogResult.HasValue && pbw.DialogResult.Value)
            {
                viewModel.SelectedPreBoleta.grupoCarteira = preBoletaClone.grupoCarteira;
                viewModel.SelectedPreBoleta.carteira = preBoletaClone.carteira;
                viewModel.SelectedPreBoleta.acao = preBoletaClone.acao;
                viewModel.SelectedPreBoleta.classeOp = preBoletaClone.classeOp;
                viewModel.SelectedPreBoleta.pu = preBoletaClone.pu;
                viewModel.SelectedPreBoleta.quantidade = preBoletaClone.quantidade;
                viewModel.SelectedPreBoleta.contaAssociada = preBoletaClone.contaAssociada;
                viewModel.SelectedPreBoleta.corretora = preBoletaClone.corretora;
                DBConnection.updatePB(preBoletaClone);
            }
        }
    }
}
