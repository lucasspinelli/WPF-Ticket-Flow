using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel
{
    public class PreBoletaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.PreBoleta> PreBoletas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasAprovadas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasReprovadas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasPendentes { get; private set; }
        public RelayCommand CommandAdicionar { get; set; }
        public RelayCommand CommandDeletar { get; set; }
         public RelayCommand CommandEditar { get; set; }
        public RelayCommand CommandAnalisar { get; set; }
        
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
            }
        }

        public PreBoletaViewModel()
        {
            ConnectionDB.createDB();
            PreBoletas = new ObservableCollection<Model.PreBoleta>(ConnectionDB.getListPB());
            PreBoletasAprovadas = new ObservableCollection<Model.PreBoleta>(ConnectionDB.getStatusPB(Status.APROVADA));
            PreBoletasReprovadas = new ObservableCollection<Model.PreBoleta>(ConnectionDB.getStatusPB(Status.REPROVADA));
            PreBoletasPendentes = new ObservableCollection<Model.PreBoleta>(ConnectionDB.getStatusPB(Status.PENDENTE));
            CommandAdicionar = new RelayCommand(AdicionarPB);
            CommandDeletar = new RelayCommand(DeletarPB);
            CommandEditar = new RelayCommand(EditarPB);
            CommandAnalisar = new RelayCommand(AnalisarPB);
        }

        private void AdicionarPB()
        {
            var preBoleta = new Model.PreBoleta();


            var pw = new PreBoleta();
            pw.DataContext = preBoleta;
            pw.ShowDialog();

            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                PreBoletas.Add(preBoleta);
                PreBoletasPendentes.Add(preBoleta);
                preBoleta.status = Status.PENDENTE;
                ConnectionDB.add(preBoleta);
                SelectedPreBoleta = preBoleta;
            }
        }

        private void DeletarPB()
        {
            ConnectionDB.delete(SelectedPreBoleta);
            PreBoletas.Remove(SelectedPreBoleta);
            SelectedPreBoleta = PreBoletas.FirstOrDefault();
        }

        private void EditarPB()
        {
            var preBoletaClone = (Model.PreBoleta)SelectedPreBoleta.Clone();
            var pbw = new PreBoleta();
            pbw.DataContext = preBoletaClone;
            pbw.ShowDialog();

            if (pbw.DialogResult.HasValue && pbw.DialogResult.Value)
            {
                SelectedPreBoleta.grupoCarteira = preBoletaClone.grupoCarteira;
                SelectedPreBoleta.carteira = preBoletaClone.carteira;
                SelectedPreBoleta.acao = preBoletaClone.acao;
                SelectedPreBoleta.classeOp = preBoletaClone.classeOp;
                SelectedPreBoleta.pu = preBoletaClone.pu;
                SelectedPreBoleta.quantidade = preBoletaClone.quantidade;
                SelectedPreBoleta.contaAssociada = preBoletaClone.contaAssociada;
                SelectedPreBoleta.corretora = preBoletaClone.corretora;
                ConnectionDB.update(preBoletaClone);
            }
        }

        private void AnalisarPB()
        {
            var preBoletaClone = (Model.PreBoleta)SelectedPreBoletasPendentes.Clone();
            var apbw = new AnalisePB();
            apbw.DataContext = preBoletaClone;
            apbw.ShowDialog();

            if (apbw.DialogResult.HasValue && apbw.DialogResult.Value)
            {
                SelectedPreBoletasPendentes.status = preBoletaClone.status;
                ConnectionDB.update(preBoletaClone);
                if (preBoletaClone.status == Status.APROVADA)
                {
                    PreBoletasAprovadas.Add(preBoletaClone);
                    PreBoletasPendentes.Remove(SelectedPreBoletasPendentes);

                }
                else if (preBoletaClone.status == Status.REPROVADA)
                {
                    PreBoletasReprovadas.Add(preBoletaClone);
                    PreBoletasPendentes.Remove(SelectedPreBoletasPendentes);
                }

            }
        }
    }
}