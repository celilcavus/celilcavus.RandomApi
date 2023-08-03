using Dapper;
using MySql.Data.MySqlClient;

namespace _02_DataAccess.Dapper
{
    public static class DapperContext
    {
        public static string Server { get; set; } = "localhost";
        public static string DatabaseName { get; set; } = "randomdb";
        public static string UserName { get; set; } = "root";
        public static string Password { get; set; } = "celil123";
        public static int Port { get; set; } = 3306;

        private static string MYSQLCONNECTION = $@"
        Server={Server};
        Port={Port};
        Database={DatabaseName};
        Uid={UserName};
        Pwd={Password};";
        
        public static MySqlConnection connection = new MySqlConnection(MYSQLCONNECTION);
        
    }
}
