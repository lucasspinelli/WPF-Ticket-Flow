using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace Boletas.Model
{
    public static class DBconecctionBole
    {
        private static string DBname = "Boletas.DB";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DBpath = System.IO.Path.Combine(folderPath, DBname);

        private static SQLiteConnection connectionBoleta = new SQLiteConnection(DBpath);

        public static void createDB()
        {
            connectionBoleta.CreateTable<Boleta>();
        }

        public static bool addPB(Boleta b)
        {
            try
            {
                connectionBoleta.Insert(b);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra add, perdão");
                return false;
            }
        }

        public static bool deletePB(Boleta b)
        {
            try
            {
                connectionBoleta.Delete(b);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra deletar, perdão");
                return false;
            }
        }

        public static bool updatePB(Boleta b)
        {
            try
            {
                connectionBoleta.Update(b);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra editar, perdão");
                return false;
            }
        }

        public static List<Boleta> getListPB()
        {
            return connectionBoleta.Table<Boleta>().ToList();
        }
    }
}

