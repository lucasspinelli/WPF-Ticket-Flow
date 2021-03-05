using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace Boletas.Model
{
    public class ConnectionDB : DBInterface
    {
        private static string DBname = "MITRA.DB";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DBpath = System.IO.Path.Combine(folderPath, DBname);

        private static SQLiteConnection connectionDB = new SQLiteConnection(DBpath);

        public ConnectionDB() { }
        void DBInterface.createDB()
        {
            connectionDB.CreateTable<PreBoleta>();
            connectionDB.CreateTable<Boleta>();
            connectionDB.CreateTable<User>();
        }

        bool DBInterface.add(object obj)
        {
            try
            {

                connectionDB.Insert(obj);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra add, perdão");
                return false;
            }
        }

        bool DBInterface.delete(object obj)
        {
            try
            {
                connectionDB.Delete(obj);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra deletar, perdão");
                return false;
            }
        }

        bool DBInterface.update(object obj)
        {
            try
            {
                connectionDB.Update(obj);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra editar, perdão");
                return false;
            }
        }

        List<PreBoleta> DBInterface.getListPB()
        {
            return connectionDB.Table<PreBoleta>().ToList();
        }

        List<PreBoleta> DBInterface.getStatusPB(Status status)
        {
            return connectionDB.Table<PreBoleta>().Where(pb => pb.status == status).ToList();
        }

        List<Boleta> DBInterface.getListBol()
        {
            return connectionDB.Table<Boleta>().ToList();
        }

        List<User> DBInterface.getListUser()
        {
            return connectionDB.Table<User>().ToList();
        }

        List<User> DBInterface.getPerfil(Perfil perfil)
        {
            return connectionDB.Table<User>().Where(user => user.perfil == perfil).ToList();
        }

        Perfil DBInterface.findUserProfile(string login)
        {
            return connectionDB.Table<User>().Where(user => user.login == login).ToList().First().perfil;
        }

        bool DBInterface.validateUser(string login, string senha)
        {
            if (connectionDB.Table<User>().Where(u => u.login == login && u.senha == senha).ToList().Count != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Existe n tiozão ");
                return false;
            }
        }
    }
}
