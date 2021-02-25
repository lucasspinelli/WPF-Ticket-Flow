using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.Commands
{
    public class AdicionarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is PreBoletaViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (PreBoletaViewModel)parameter;
            var preBoleta = new Model.PreBoleta();


            var pw = new PreBoleta();
            pw.DataContext = preBoleta;
            pw.ShowDialog();

            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                viewModel.PreBoletas.Add(preBoleta); 
                viewModel.PreBoletasPendentes.Add(preBoleta);
                preBoleta.status = Status.PENDENTE;
                DBConnection.addPB(preBoleta);
                viewModel.SelectedPreBoleta = preBoleta;
            }
        }
    }
}
