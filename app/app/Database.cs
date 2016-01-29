using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace app
{
    class Database
    {
        public static string connectieString = @"Data Source=DATABASEADRESS;Initial Catalog=DATABASENAME;Integrated Security=True";

        public static DataTable sqlQuery(String QueryString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectieString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = QueryString;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Table");
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
