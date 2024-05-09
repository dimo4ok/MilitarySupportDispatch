using System.Data.SqlClient;

namespace MilitarySupportDispatch.ClassesData
{
    public class DataStorage
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public static string TypeOfAccount {  get; set; }
        public static int id { get; set; }
        public static string nameOfOrgan { get; set; }


        public static string password { get; set; } // delete

        public DataStorage(string TypeOfAccount1, string nameOfOrgan1) 
        {
            TypeOfAccount = TypeOfAccount1;
            nameOfOrgan = nameOfOrgan1;

            RecieveId();
        }

        private void RecieveId()
        {
            if (TypeOfAccount == "Volunteers")
            {
                string query = $"SELECT vol_id FROM Volunteers WHERE vol_nameOfOrgan COLLATE SQL_Latin1_General_CP1_CS_AS = @volNameOfOrgan";

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                // Параметризований запит для уникнення SQL-ін'єкцій
                command.Parameters.AddWithValue("@volNameOfOrgan", $"{nameOfOrgan}");

                dataBase.openDatabase();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Отримання значень з результатів та присвоєння їх змінним
                        id = reader.GetInt32(0);
                    }
                }

                dataBase.closeDatabase();
            }
            else if (TypeOfAccount == "Military")
            {
                string query = $"SELECT mil_id FROM Military WHERE mil_nameOfOrgan COLLATE SQL_Latin1_General_CP1_CS_AS = @milNameOfOrgan";

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                // Параметризований запит для уникнення SQL-ін'єкцій
                command.Parameters.AddWithValue("@milNameOfOrgan", $"{nameOfOrgan}");

                dataBase.openDatabase();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Отримання значень з результатів та присвоєння їх змінним
                        id = reader.GetInt32(0);
                    }
                }

                dataBase.closeDatabase();
            }
        }
    }
}
