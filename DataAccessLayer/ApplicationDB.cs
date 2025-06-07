using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    class ApplicationDB
    {
        static string connection = "Data Source=.;Initial Catalog=ITICafeteria ;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public static DataTable GetDataTable(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection?.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
                //sqlConnection.Close() => Using make this line at the end.
            }
        }

        public static int ExcuteNonQuery(string commandText)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection?.Open();
                SqlCommand cmd = new SqlCommand(commandText, sqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows;
                //sqlConnection.Close() => Using make this line at the end.
            }
        }

        public static object ExcuteScalar(string commandText)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection?.Open();
                SqlCommand cmd = new SqlCommand(commandText, sqlConnection);
                object affectedFirstCoulmn = cmd.ExecuteScalar();
                return affectedFirstCoulmn;
                //sqlConnection.Close() => Using make this line at the end.
            }
        }
    }
}

