using System.Data.SqlClient;

namespace MilitarySupportDispatch.ClassesData
{
    public class DataBaseConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DIMA; Initial Catalog = MilitaryDatabase; Integrated Security = True");

        public void openDatabase()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeDatabase()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}