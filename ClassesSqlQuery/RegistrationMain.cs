using MilitarySupportDispatch.ClassesData;
using System.Data.SqlClient;

namespace MilitarySupportDispatch.ClassesSqlQuery
{
    public class RegistrationMain
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        private string _nameOfOrganization { get; set; }
        private string _password { get; set; }
        private string _table { get; set; }
        private string _tableNameOfOrgan { get; set; }
        private string _tablePassword { get; set; }



        public RegistrationMain(string _nameOfOrganization, string _password, string _table, string _tableNameOfOrgan, string _tablePassword)
        {
            this._nameOfOrganization = _nameOfOrganization;
            this._password = _password;
            this._table = _table;
            this._tableNameOfOrgan = _tableNameOfOrgan;
            this._tablePassword = _tablePassword;
        }

        public bool CheckNameOfOrgan()
        {
            string query = $"SELECT COUNT(1) FROM {_table} WHERE {_tableNameOfOrgan} COLLATE SQL_Latin1_General_CP1_CS_AS = @Username";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            command.Parameters.AddWithValue("@Username", _nameOfOrganization);

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

        public void RegistrationTry()
        {
            string query = $"INSERT INTO {_table} ({_tableNameOfOrgan},{_tablePassword}) VALUES (@NameOfOrgan, @Password)";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            command.Parameters.AddWithValue("@NameOfOrgan", _nameOfOrganization);
            command.Parameters.AddWithValue("@Password", _password);

            dataBase.openDatabase();

            command.ExecuteNonQuery();

            dataBase.closeDatabase();
        }
    }
}
