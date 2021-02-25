using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace Boletas.Model
{
    public abstract class DBUser
    {
        private static string DBname = "Users.DB";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DBpath = System.IO.Path.Combine(folderPath, DBname);

        private static SQLiteConnection connectionUser = new SQLiteConnection(DBpath);

        public static void createDB()
        {
            connectionUser.CreateTable<User>();
        }

        public static void addPB(User user)
        {
            try
            {
                if (connectionUser.Table<User>().Where(u => u.login == user.login).ToList().Count() == 0)
                {
                    connectionUser.Insert(user);
                } else
                {
                    MessageBox.Show("LOGIN JA EXISTE");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Koe mano, não consegui adicionar");
            }
        }

        public static void deletePB(User user)
        {
            try
            {
                connectionUser.Delete(user);

            }
            catch (Exception)
            {
                MessageBox.Show("Koe mano, não consegui deletar");
            }
        }

        public static void updatePB(User user)
        {
            try
            {
                connectionUser.Update(user);
            }
            catch (Exception)
            {
                MessageBox.Show("Koe mano, não consegui editar");
            }
        }

        public static List<User> getListPB()
        {
            return connectionUser.Table<User>().ToList();
        }

        public static List<User> getPerfil(Perfil perfil)
        {
            return connectionUser.Table<User>().Where(user => user.perfil == perfil).ToList();
        }

        public static Perfil findUserProfile(string login)
        {
            return connectionUser.Table<User>().Where(user => user.login == login).ToList().First().perfil;
        }

       public static bool validateUser(string login, string senha)
        {
            if (connectionUser.Table<User>().Where(u => u.login == login && u.senha == senha).ToList().Count != 0)
            {
                return true;
            } else
            {
                MessageBox.Show("Existe n tiozão ");
                return false;
            }
        }
    }
}

