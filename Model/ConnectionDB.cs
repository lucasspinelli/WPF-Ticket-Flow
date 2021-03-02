using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace Boletas.Model
{
    public static class ConnectionDB
    {
        private static string DBname = "MITRA.DB";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DBpath = System.IO.Path.Combine(folderPath, DBname);

        private static SQLiteConnection connectionDB = new SQLiteConnection(DBpath);

        public static void createDB()
        {
            connectionDB.CreateTable<PreBoleta>();
            connectionDB.CreateTable<Boleta>();
            connectionDB.CreateTable<User>();
        }

        public static bool add(object obj)
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

        public static bool delete(object obj)
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

        public static bool update(object obj)
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

        public static List<PreBoleta> getListPB()
        {
            return connectionDB.Table<PreBoleta>().ToList();
        }

        public static List<PreBoleta> getStatusPB(Status status)
        {
            return connectionDB.Table<PreBoleta>().Where(pb => pb.status == status).ToList();
        }

        public static List<Boleta> getListBol()
        {
            return connectionDB.Table<Boleta>().ToList();
        }

        public static List<User> getListUser()
        {
            return connectionDB.Table<User>().ToList();
        }

        public static List<User> getPerfil(Perfil perfil)
        {
            return connectionDB.Table<User>().Where(user => user.perfil == perfil).ToList();
        }

        public static Perfil findUserProfile(string login)
        {
            return connectionDB.Table<User>().Where(user => user.login == login).ToList().First().perfil;
        }

        public static bool validateUser(string login, string senha)
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
