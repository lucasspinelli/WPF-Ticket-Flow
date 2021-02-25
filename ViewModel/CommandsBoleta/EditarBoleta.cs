using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.CommandsBoleta
{
    public class EditarBoleta : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as BoletaViewModel;
            return viewModel != null && viewModel.SelectedBoleta != null;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (BoletaViewModel)parameter;
            var boletaClone = (Model.Boleta)viewModel.SelectedBoleta.Clone();
            var pbw = new BoletaTW();
            pbw.DataContext = boletaClone;
            pbw.ShowDialog();

            if (pbw.DialogResult.HasValue && pbw.DialogResult.Value)
            {
                viewModel.SelectedBoleta.grupoCarteira = boletaClone.grupoCarteira;
                viewModel.SelectedBoleta.carteira = boletaClone.carteira;
                viewModel.SelectedBoleta.acao = boletaClone.acao;
                viewModel.SelectedBoleta.classeOp = boletaClone.classeOp;
                viewModel.SelectedBoleta.pu = boletaClone.pu;
                viewModel.SelectedBoleta.quantidade = boletaClone.quantidade;
                viewModel.SelectedBoleta.contaAssociada = boletaClone.contaAssociada;
                viewModel.SelectedBoleta.corretora = boletaClone.corretora;
                DBconecctionBole.updatePB(boletaClone);
            }
        }
    }
}
