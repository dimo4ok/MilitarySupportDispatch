using System.Data.SqlClient;
using MilitarySupportDispatch.ClassesData;

namespace MilitarySupportDispatch.ClassesSqlQuery
{
    public class CheckAutorization
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        private string _username { get; set; }
        private string _password { get; set; }
        private string _table { get; set; }
        private string _nameofOrgan { get; set; }
        private string _passwordOrgan { get; set; }

        public CheckAutorization(string NameTextBox, string PasswordTextBox, string table, string nameofOrgan, string passwordOrgan)
        {
            _username = NameTextBox;
            _password = PasswordTextBox;
            _table = table;
            _nameofOrgan = nameofOrgan;
            _passwordOrgan = passwordOrgan;
        }

        public bool CheckAutorizationFunc()
        {
            string query = $"SELECT COUNT(1) FROM {_table} WHERE {_nameofOrgan} COLLATE SQL_Latin1_General_CP1_CS_AS = @Username AND {_passwordOrgan} COLLATE SQL_Latin1_General_CP1_CS_AS = @Password"
;
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@Username", _username);
            command.Parameters.AddWithValue("@Password", _password);

            dataBase.openDatabase();
            int count = (int)command.ExecuteScalar();
            dataBase.closeDatabase();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}