using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.Model
{
    public interface DBInterface
    {
        bool add(object obj);

        void createDB();

        bool delete(object obj);

        bool update(object obj);

        List<PreBoleta> getListPB();

        List<PreBoleta> getStatusPB(Status status);

        List<Boleta> getListBol();

        List<User> getListUser();

        List<User> getPerfil(Perfil perfil);

        Perfil findUserProfile(string login);

        bool validateUser(string login, string senha);
    }    
}

