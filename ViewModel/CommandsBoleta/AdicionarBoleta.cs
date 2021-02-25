using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel.CommandsBoleta
{
    public class AdicionarBoleta : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is BoletaViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (BoletaViewModel)parameter;
            var boleta = new Model.Boleta();


            var bw = new BoletaTW();
            bw.DataContext = boleta;
            bw.ShowDialog();

            if (bw.DialogResult.HasValue && bw.DialogResult.Value)
            {
                viewModel.Boletas.Add(boleta);
                DBconecctionBole.addPB(boleta);
                viewModel.SelectedBoleta = boleta;
            }
        }
    }
}
