using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.Model;

namespace Boletas.ViewModel
{
    public class BoletaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.Boleta> Boletas { get; private set; }
        public ObservableCollection<Model.PreBoleta> PreBoletasAprovadas { get; private set; }
        public RelayCommand CommandAdicionar { get; set; }

        private GetConnection _getConnection = new GetConnection();
        private DBInterface _con { get; set; }
        public RelayCommand CommandDeletar { get; set; }
        public RelayCommand CommandEditar { get; set; }

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
            }
        }
        public BoletaViewModel()
        {
            _con = _getConnection.GetDBConnection();
            _con.createDB();
            Boletas = new ObservableCollection<Model.Boleta>(_con.getListBol());
            PreBoletasAprovadas = new ObservableCollection<Model.PreBoleta>(_con.getStatusPB(Status.APROVADA));
            CommandAdicionar = new RelayCommand(AdicionarB);
            CommandDeletar = new RelayCommand(DeletarB);
            CommandEditar = new RelayCommand(EditarB);
        }
        private void AdicionarB()
        {
            var boleta = new Model.Boleta();
            var bw = new BoletaTW();
            bw.DataContext = boleta;
            bw.ShowDialog();

            if (bw.DialogResult.HasValue && bw.DialogResult.Value)
            {
                Boletas.Add(boleta);
                _con.add(boleta);
                SelectedBoleta = boleta;
            }
        }

        private void DeletarB()
        {
            _con.delete(SelectedBoleta);
            Boletas.Remove(SelectedBoleta);
            SelectedBoleta = Boletas.FirstOrDefault();
        }

        private void EditarB()
        {
            var boletaClone = (Model.Boleta)SelectedBoleta.Clone();
            var pbw = new BoletaTW();
            pbw.DataContext = boletaClone;
            pbw.ShowDialog();

            if (pbw.DialogResult.HasValue && pbw.DialogResult.Value)
            {
                SelectedBoleta.grupoCarteira = boletaClone.grupoCarteira;
                SelectedBoleta.carteira = boletaClone.carteira;
                SelectedBoleta.acao = boletaClone.acao;
                SelectedBoleta.classeOp = boletaClone.classeOp;
                SelectedBoleta.pu = boletaClone.pu;
                SelectedBoleta.quantidade = boletaClone.quantidade;
                SelectedBoleta.contaAssociada = boletaClone.contaAssociada;
                SelectedBoleta.corretora = boletaClone.corretora;
                _con.update(boletaClone);
            }
        }
    }
}

