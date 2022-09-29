using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    public static class ConnectionString
    {
        private static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=COVID-19; Integrated Security=true;";

        public static SqlConnection Connect()
        {
            var cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
    }
}
