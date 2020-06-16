using System.Data;
using Npgsql;
namespace ProyectoPoo
{
    public static class DBConnection
    {
        private static string host = "ec2-52-44-55-63.compute-1.amazonaws.com";
        private static int port = 5432;
        private static string user = "qnoejccxklwpjh";
        private static string password = "e371383926ac58c0b0a6d2ced5d2adafd79523be4340ea28f00f45af1f1a5010";
        private static string database = "dankgm1b8mvqap";
        
        private static string sConnection = $"Host={host}; Port={port}; User Id={user}; Password={password}; Database={database};";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        public static void ExecuteAction(string action)
        {
            NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(action, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}