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
    public class PreBoletaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.PreBoleta> PreBoletas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasAprovadas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasReprovadas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasPendentes { get; private set; }
        public AdicionarCommand Adicionar { get; private set; } = new AdicionarCommand();
        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();
        public EditarCommand Editar { get; private set; } = new EditarCommand();
        public AnalisarCommand Analisar { get; private set; } = new AnalisarCommand();

        private Model.PreBoleta _selectedPreBoleta;
        public Model.PreBoleta SelectedPreBoleta
        {
            get
            {
                _selectedPreBoleta = (_selectedPreBoleta == null) ? PreBoletas.FirstOrDefault() : _selectedPreBoleta;
                return _selectedPreBoleta;
            }
            set
            {
                SetField(ref _selectedPreBoleta, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }

        private Model.PreBoleta _selectedPreBoletaPendente;
        public Model.PreBoleta SelectedPreBoletasPendentes
        {
            get
            {
                _selectedPreBoletaPendente = (_selectedPreBoletaPendente == null) ? PreBoletasPendentes.FirstOrDefault() : _selectedPreBoletaPendente;
                return _selectedPreBoletaPendente;
            }
            set
            {
                SetField(ref _selectedPreBoletaPendente, value);
                Analisar.RaiseCanExecuteChanged();
            }
        }

        public PreBoletaViewModel()
        {
            DBConnection.createDB();
            PreBoletas = new ObservableCollection<Model.PreBoleta>(DBConnection.getListPB());
            PreBoletasAprovadas = new ObservableCollection<Model.PreBoleta>(DBConnection.getStatus(Status.APROVADA));
            PreBoletasReprovadas = new ObservableCollection<Model.PreBoleta>(DBConnection.getStatus(Status.REPROVADA));
            PreBoletasPendentes = new ObservableCollection<Model.PreBoleta>(DBConnection.getStatus(Status.PENDENTE));

        }
    }
}