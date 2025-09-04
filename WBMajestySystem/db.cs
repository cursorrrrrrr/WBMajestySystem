using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WBMajestySystem
{
    public static class Db
    {
        public static MySqlConnection GetConnection()
        {
            // Replace with your real connection string
            return new MySqlConnection("Server=localhost;Database=wbmajesty;Uid=root;Pwd=;");
        }
    }
}