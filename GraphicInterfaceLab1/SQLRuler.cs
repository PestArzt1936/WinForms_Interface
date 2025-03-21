using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicInterfaceLab1
{
    public class SQLRuler
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=dashboard; User ID=root; Password=NoLoveForChurka");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            else
                throw new Exception("Не удалось подключиться к базе данных");
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            else
                throw new Exception("Не удалось произвести отключение от базы данных");
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
