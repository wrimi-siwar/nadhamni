using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Nadhemni
{
    class Connection
    {

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            
            string connString = @"Data Source=DESKTOP-VDK5C8G;Initial Catalog=Nadhemni;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
             return conn;


           

        }


    }
}