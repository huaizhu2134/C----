using System.Data.Common;
using MySql.Data.MySqlClient;

namespace C_大作业.DAL
{
    public class MysqlHelper
    {
        private static readonly string connStr =
            "Server=localhost;Database=dfhz;Uid=root;Pwd=qq2134769644;Charset=utf8mb4;";

        // Return a DbConnection (MySqlConnection)
        public static DbConnection GetConn()
        {
            return new MySqlConnection(connStr);
        }
    }
}