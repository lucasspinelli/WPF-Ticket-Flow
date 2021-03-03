using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Boletas.Model
{
    public class ConnectionMySQL : DBInterface
    {
        private static string connString = "Server=localhost;Database=MITRA;Uid=admin;Pwd=admin";
        private static MySqlConnection connection = new MySqlConnection(connString);
        private static MySqlCommand command = connection.CreateCommand();

        void DBInterface.createDB()
        {
            try
            {
                connection.Open();
                command.CommandText = "CREATE TABLE USUARIOS";
                command.CommandText = "CREATE TABLE PREBOLETAS";
                command.CommandText = "CREATE TABLE BOLETAS";
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        bool DBInterface.add(object obj)
        {
            throw new NotImplementedException();
        }


        bool DBInterface.delete(object obj)
        {
            throw new NotImplementedException();
        }

        bool DBInterface.update(object obj)
        {
            throw new NotImplementedException();
        }

        List<PreBoleta> DBInterface.getListPB()
        {
            throw new NotImplementedException();
        }

        List<PreBoleta> DBInterface.getStatusPB(Status status)
        {
            throw new NotImplementedException();
        }

        List<Boleta> DBInterface.getListBol()
        {
            throw new NotImplementedException();
        }

        List<User> DBInterface.getListUser()
        {
            throw new NotImplementedException();
        }

        List<User> DBInterface.getPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        Perfil DBInterface.findUserProfile(string login)
        {
            throw new NotImplementedException();
        }

        bool DBInterface.validateUser(string login, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
