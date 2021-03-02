
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Boletas.Model
{
    public class User : BaseNotifyPropertyChanged, ICloneable
    {
        private string _login;

        [Unique]
        public string login 
        { 
            get { return _login; }
            set { SetField(ref _login, value); } 
        }

        private string _senha;

        public string senha
        {
            get { return _senha; }
            set { SetField(ref _senha, value); }
        }

        private Perfil _perfil; 

        public Perfil perfil {
            get { return _perfil; } 
            set { SetField(ref _perfil, value); } 
        }

        public object Clone()
        {
           return MemberwiseClone();
        }
    }
}
