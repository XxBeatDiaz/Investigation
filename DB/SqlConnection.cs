using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.DB
{
    class SqlConnection
    {
        static private string _ConnStr = "Server=localhost;User=root;Password=;Database=ivestigation";

        static public MySqlConnection Open()
        {
            try
            {
                MySqlConnection openConn = new MySqlConnection(_ConnStr);
                openConn.Open();
                Console.WriteLine("Connection: Successful.");
                return openConn;
            }
            catch (MySqlException)
            {
                Console.WriteLine("Connection: Not successful. ");
                return null!;
                //Console.WriteLine($"ErrorMySQl: {ex.Message}");
            }
        }
    }
}
