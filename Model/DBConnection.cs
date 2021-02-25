using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace Boletas.Model
{
    public static class DBConnection
    {
        private static string DBname = "PreBoletas.DB";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DBpath = System.IO.Path.Combine(folderPath, DBname);

        private static SQLiteConnection connectionPreBoleta = new SQLiteConnection(DBpath);

        public static void createDB()
        {
            connectionPreBoleta.CreateTable<PreBoleta>();
        }

        public static bool addPB(PreBoleta pb)
        {
            try  
            {

                connectionPreBoleta.Insert(pb);
                return true;

            } catch  (Exception)
            {
                MessageBox.Show("Deu ruim pra add, perdão");
                return false;
            }
        }

        public static bool deletePB(PreBoleta pb)
        {
            try
            {
                connectionPreBoleta.Delete(pb);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim pra deletar, perdão");
                return false;
            }
        }

        public static bool updatePB(PreBoleta pb)
        {
            try
            {
                connectionPreBoleta.Update(pb);
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
            return connectionPreBoleta.Table<PreBoleta>().ToList();
        }

        public static List<PreBoleta> getStatus(Status status)
        {
            return connectionPreBoleta.Table<PreBoleta>().Where(pb => pb.status == status).ToList();
        }
    }
}
