using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MetroRail_Ticketing
{
    class Database
    {
        public static SqlConnection ConnectDb()
        {
            string connString = @"Server=DESKTOP-HTEH6GT\SQLEXPRESS;Database=MetroRail;Integrated Security=true;";
            return new SqlConnection(connString);
        }

    }
}
