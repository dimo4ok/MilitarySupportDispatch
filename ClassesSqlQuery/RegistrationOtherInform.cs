using MilitarySupportDispatch.ClassesData;
using System.Data.SqlClient;

namespace MilitarySupportDispatch.ClassesSqlQuery
{
    public class RegistrationOtherInform
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        private string _table { get; set; }

        private string _tableFirstName { get; set; }
        private string _tableLastName { get; set; }
        private string _tableNumber { get; set; }
        private string _tablePost { get; set; }

        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _number { get; set; }
        private string _post { get; set; }

        public RegistrationOtherInform(string _table, string _tableFirstName, string _tableLastName, string _tableNumber, string _tablePost,
            string _firstName = null, string _lastName = null, string _number = null, string _post = null)
        {
            this._table = _table;
            this._tableFirstName = _tableFirstName;
            this._tableLastName = _tableLastName;
            this._tableNumber = _tableNumber;
            this._tablePost = _tablePost;

            this._firstName = _firstName;
            this._lastName = _lastName;
            this._number = _number;
            this._post = _post;

        }

        public void FillOtherInform()
        {
            string query = $"INSERT INTO {_table} ({_tableFirstName},{_tableLastName},{_tableNumber},{_tablePost}) VALUES (@_firstName, @_lastName, @_number, @_post)";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            command.Parameters.AddWithValue("@_firstName", _firstName);
            command.Parameters.AddWithValue("@_lastName", _lastName);
            command.Parameters.AddWithValue("@_number", _number);
            command.Parameters.AddWithValue("@_post", _post);

            dataBase.openDatabase();

            command.ExecuteNonQuery();

            dataBase.closeDatabase();
        }
    }
}
