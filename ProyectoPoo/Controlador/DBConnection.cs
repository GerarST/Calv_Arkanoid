using System.Data;
using Npgsql;
namespace ProyectoPoo.Controlador
{
    public static class DBConnection
    {
        /*Connection string for the local database*/
        private static string host = "127.0.0.1";
        private static int port = 5432;
        private static string user = "postgres";
        private static string password = "uca";
        private static string database = "proyecto";
        
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

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(action, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}