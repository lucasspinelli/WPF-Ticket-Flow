using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;
using Boletas.ViewModel.CommandsBoleta;

namespace Boletas.ViewModel
{
    public class BoletaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.Boleta> Boletas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasAprovadas { get; private set; }
        public AdicionarBoleta Adicionar { get; private set; } = new AdicionarBoleta();
        public DeletarBoleta Deletar { get; private set; } = new DeletarBoleta();
        public EditarBoleta Editar { get; private set; } = new EditarBoleta();

        private Model.Boleta _selectedBoleta;
        public Model.Boleta SelectedBoleta
        {
            get
            {
                _selectedBoleta = (_selectedBoleta == null) ? Boletas.FirstOrDefault() : _selectedBoleta;
                return _selectedBoleta;
            }
            set
            {
                SetField(ref _selectedBoleta, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }
        public BoletaViewModel()
        {
            DBconecctionBole.createDB();
            Boletas = new ObservableCollection<Model.Boleta>(DBconecctionBole.getListPB());
            PreBoletasAprovadas = new ObservableCollection<Model.PreBoleta>(DBConnection.getStatus(Status.APROVADA));
        }
    }
}
