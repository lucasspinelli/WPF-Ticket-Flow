using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Boletas.Model
{
    public class Boleta : BaseNotifyPropertyChanged, ICloneable
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }
        private GrupoCarteiras _grupoCarteiras;
        public GrupoCarteiras grupoCarteira
        {
            get { return _grupoCarteiras; }
            set { SetField(ref _grupoCarteiras, value); }
        }

        private string _carteira;
        public string carteira
        {
            get { return _carteira; }
            set { SetField(ref _carteira, value); }
        }

        private Acoes _acao;
        public Acoes acao
        {
            get { return _acao; }
            set { SetField(ref _acao, value); }
        }

        private string _classeOp;
        public string classeOp
        {
            get { return _classeOp; }
            set { SetField(ref _classeOp, value); }
        }

        private double _pu;
        public double pu
        {
            get { return _pu; }
            set { SetField(ref _pu, value); }
        }
        private int _quantidade;
        public int quantidade
        {
            get { return _quantidade; }
            set { SetField(ref _quantidade, value); }
        }

        private double _valor;
        public double valor
        {
            get
            {
                _valor = _pu * _quantidade;
                return _valor;
            }
        }

        private string _contaAssociada;
        public string contaAssociada
        {
            get { return _contaAssociada; }
            set { SetField(ref _contaAssociada, value); }
        }

        private string _corretora;
        public string corretora
        {
            get { return _corretora; }
            set { SetField(ref _corretora, value); }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}

