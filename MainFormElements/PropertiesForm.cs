using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainFormElements
{
    public partial class PropertiesForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        private string TableName;
        private string TableNameId;
        private string TableNameOrgan;
        private string TableNamePassword;
        private string TableNameShowInform;

        private string infromTableName;
        private string infromTableNameId;
        private string informTableNameFirstName;
        private string infromTableNameLastName;
        private string infromTableNameNumber;
        private string infromTableNamePost;

        private string FirstNameValue;
        private string LastNameValue;
        private string NumberValue;
        private string PostValue;

        public PropertiesForm()
        {
            InitializeComponent();

            if (DataStorage.TypeOfAccount == "Military")
            {
                TableName = "Military";
                TableNameId = "mil_id";
                TableNameOrgan = "mil_nameOfOrgan";
                TableNamePassword = "mil_password";
                TableNameShowInform = "mil_showInform";

                infromTableName = "InformMil";
                infromTableNameId = "id_military";
                informTableNameFirstName = "mil_firstName";
                infromTableNameLastName = "mil_lastName";
                infromTableNameNumber = "mil_number";
                infromTableNamePost = "mil_post";
            }
            else if (DataStorage.TypeOfAccount == "Volunteers")
            {
                TableName = "Volunteers";
                TableNameId = "vol_id";
                TableNameOrgan = "vol_nameOfOrgan";
                TableNamePassword = "vol_password";
                TableNameShowInform = "vol_showInform";


                infromTableName = "InformVol";
                infromTableNameId = "id_volunter";
                informTableNameFirstName = "vol_firstName";
                infromTableNameLastName = "vol_lastName";
                infromTableNameNumber = "vol_number";
                infromTableNamePost = "vol_post";
            }

            FillInformation(DataStorage.id);
        }

        private void CheckBoxAllowShowInfo_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox;

            if(CheckBoxAllowShowInfo.Checked == true)
            {
                customMessageBox = new CustomMessageBox("Показувати додаткову інформацію іншим учасникам? (рекомендується)", "Показати дані", "Question");
            }
            else
            {
                customMessageBox = new CustomMessageBox("НЕ показувати додаткову інформацію іншим учасникам? (не рекомендується)", "Показати дані", "Question");

            }
            customMessageBox.ShowDialog();

            if (!customMessageBox.CheckReturn())
            {
                if (CheckBoxAllowShowInfo.Checked == false)
                    CheckBoxAllowShowInfo.Checked = true;
                else
                    CheckBoxAllowShowInfo.Checked = false;

                return;
            }

            ChangeAllowShowInfo(DataStorage.id);
        }

        private void FillInformation(int Id)
        {
            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand($"SELECT * FROM {infromTableName} WHERE {infromTableNameId} = @Id",dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@Id", Id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (reader[informTableNameFirstName].ToString() != "Дані відсутні")
                    textBoxPersonName.Text = reader[informTableNameFirstName].ToString();
                else
                    textBoxPersonName.Text = "Введіть ім'я";

                if (reader[infromTableNameLastName].ToString() != "Дані відсутні")
                    textBoxPersonLastName.Text = reader[infromTableNameLastName].ToString();
                else
                    textBoxPersonLastName.Text = "Введіть прізвище";


                if (reader[infromTableNameNumber].ToString() != "Дані відсутні")
                    textBoxNumberTel.Text = reader[infromTableNameNumber].ToString();
                else
                    textBoxNumberTel.Text = "Введіть номер телефону";


                if (reader[infromTableNamePost].ToString() != "Дані відсутні")
                    textBoxPost.Text = reader[infromTableNamePost].ToString();
                else
                    textBoxPost.Text = "Введіть пошту";

                RefreshValuesInformTable();
            }
            reader.Close();

            command = new SqlCommand($"SELECT {TableNameShowInform} FROM {TableName} WHERE {TableNameId} = @Id", dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@Id", Id);

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                CheckBoxAllowShowInfo.Checked = reader.GetBoolean(0);
            }

            reader.Close();

            dataBaseConnection.closeDatabase();
        }

        private void ChangeAllowShowInfo(int Id)
        {
            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand($"UPDATE {TableName} SET {TableNameShowInform} = @CheckBox WHERE {TableNameId} = @Id", dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@CheckBox", CheckBoxAllowShowInfo.Checked);

            command.ExecuteNonQuery();

            dataBaseConnection.closeDatabase();
        }

        private void textBoxPersonLastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPersonLastName.Text == "Введіть прізвище")
            {
                textBoxPersonLastName.Clear();
            }
        }

        private void textBoxPersonLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxPersonLastName.Text == "")
            {
                textBoxPersonLastName.Text = "Введіть прізвище";
            }
        }

        private void textBoxPersonName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPersonName.Text == "Введіть ім'я")
            {
                textBoxPersonName.Clear();
            }
        }

        private void textBoxPersonName_Leave(object sender, EventArgs e)
        {
            if (textBoxPersonName.Text == "")
            {
                textBoxPersonName.Text = "Введіть ім'я";
            }
        }

        private void textBoxNumberTel_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNumberTel.Text == "Введіть номер телефону")
            {
                textBoxNumberTel.Clear();
            }
        }

        private void textBoxNumberTel_Leave(object sender, EventArgs e)
        {
            if (textBoxNumberTel.Text == "")
            {
                textBoxNumberTel.Text = "Введіть номер телефону";
            }
        }

        private void textBoxPost_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPost.Text == "Введіть пошту")
            {
                textBoxPost.Clear();
            }
        }

        private void textBoxPost_Leave(object sender, EventArgs e)
        {
            if (textBoxPost.Text == "")
            {
                textBoxPost.Text = "Введіть пошту";
            }
        }

        private void textBoxOldPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxOldPassword.Text == "Пароль")
            {
                textBoxOldPassword.Clear();
            }
        }

        private void textBoxOldPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text == "")
            {
                textBoxOldPassword.Text = "Пароль";
            }
        }

        private void textBoxNewPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNewPassword.Text == "Новий пароль")
            {
                textBoxNewPassword.Clear();
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                textBoxNewPassword.Text = "Новий пароль";
            }
        }

        private void textBoxNewPasswordAgain_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNewPasswordAgain.Text == "Підтвердити пароль")
            {
                textBoxNewPasswordAgain.Clear();
            }
        }

        private void textBoxNewPasswordAgain_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPasswordAgain.Text == "")
            {
                textBoxNewPasswordAgain.Text = "Підтвердити пароль";
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked == true)
            {
                textBoxOldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonRenewInform_Click(object sender, EventArgs e)
        {
            if(!CorrectCheck())
            {
                return;
            }

            CustomMessageBox customMessageBox = new CustomMessageBox("Ви справді бажаєте оновити дані?", "Оновити дані?", "Question");
            customMessageBox.ShowDialog();

            if(!customMessageBox.CheckReturn())
            {
                FillInformation(DataStorage.id);
                return;
            }

            string PersonName = textBoxPersonName.Text;
            string PersonLastName = textBoxPersonLastName.Text;
            string TelNumb = textBoxNumberTel.Text;
            string Post = textBoxPost.Text;

            if (PersonName == "Введіть ім'я")
            {
                PersonName = "Дані відсутні";
            }
            if (PersonLastName == "Введіть прізвище")
            {
                PersonLastName = "Дані відсутні";
            }
            if (TelNumb == "Введіть номер телефону")
            {
                TelNumb = "Дані відсутні";
            }
            if (Post == "Введіть пошту")
            {
                Post = "Дані відсутні";
            }

            SqlCommand command = new SqlCommand($"UPDATE {infromTableName} SET {informTableNameFirstName} = @_firstName, {infromTableNameLastName} = @_lastName, {infromTableNameNumber} = @_number, " +
                $"{infromTableNamePost} = @_post WHERE {infromTableNameId} = @_id", dataBaseConnection.getConnection());

            command.Parameters.AddWithValue("@_firstName", PersonName);
            command.Parameters.AddWithValue("@_lastName", PersonLastName);
            command.Parameters.AddWithValue("@_number", TelNumb);
            command.Parameters.AddWithValue("@_post", Post);
            command.Parameters.AddWithValue("@_id", DataStorage.id);


            dataBaseConnection.openDatabase();
            command.ExecuteNonQuery();

            dataBaseConnection.closeDatabase();

            customMessageBox = new CustomMessageBox("Ви оновили дані!", "Дані оновлено", "Success");
            customMessageBox.ShowDialog();

            RefreshValuesInformTable();
        }

        public bool CorrectCheck()
        {
            if (FirstNameValue == textBoxPersonName.Text && LastNameValue == textBoxPersonLastName.Text &&
                NumberValue == textBoxNumberTel.Text && PostValue == textBoxPost.Text)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Ви ніяк не змінили дані!", "Введіть якісь зміни", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (!(textBoxPersonName.Text == "Введіть ім'я"))
            {
                if (!Regex.IsMatch(textBoxPersonName.Text, @"^[A-ZА-ЯЄІЇҐ][a-zа-яєіїґ]{2,24}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ім'я має починатись з великої літери і склададтись вд 3 до 25 букв!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    return false;
                }
            }

            if (!(textBoxPersonLastName.Text == "Введіть прізвище"))
            {
                if (!Regex.IsMatch(textBoxPersonLastName.Text, @"^[A-ZА-ЯЄІЇҐ][a-zа-яєіїґ]{2,34}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Прізвище має починатись з великої літери і склададтись вд 3 до 35 букв!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    return false;

                }
            }

            if (!(textBoxNumberTel.Text == "Введіть номер телефону"))
            {
                if (!Regex.IsMatch(textBoxNumberTel.Text, @"^\+380\d{9}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Телефон має починатись з +380 і містити рівно 9 додаткових цифр!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    return false;
                }
            }

            if (!(textBoxPost.Text == "Введіть пошту"))
            {
                if (!Regex.IsMatch(textBoxPost.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,39}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Некоректна пошта!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    return false;
                }
            }

            return true;
        }
        private void buttonRenewPassword_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox;

            if (textBoxOldPassword.Text == "Пароль")
            {
                customMessageBox = new CustomMessageBox("Введіть Ваший поточний пароль!", "Пароль не введено", "Warning");
                customMessageBox.ShowDialog();
                return;
            }

            if(!PasswordCorrectChecked())
            {
                customMessageBox = new CustomMessageBox("Введіть вірний пароль!", "Пароль не вірний", "Error");
                customMessageBox.ShowDialog();
                textBoxOldPassword.Text = "Пароль";
                return;
            }

            if(!NewPasswordCorrectChecked())
            {
                return;
            }


            customMessageBox = new CustomMessageBox("Ви справді бажаєте оновити пароль?", "Оновити пароль?", "Question");
            customMessageBox.ShowDialog();

            if (!customMessageBox.CheckReturn())
            {
                textBoxOldPassword.Text = "Пароль";
                textBoxNewPassword.Text = "Новий пароль";
                textBoxNewPasswordAgain.Text = "Підтвердити пароль";
                return;
            }

            ChangePasswordInSqlData();

            textBoxOldPassword.Text = "Пароль";
            textBoxNewPassword.Text = "Новий пароль";
            textBoxNewPasswordAgain.Text = "Підтвердити пароль";
        }

        public bool PasswordCorrectChecked()
        {
            string query = $"SELECT COUNT(1) FROM {TableName} WHERE {TableNameId} = @Id AND {TableNamePassword} COLLATE SQL_Latin1_General_CP1_CS_AS = @Password"
;
            SqlCommand command = new SqlCommand(query, dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@Id", DataStorage.id);
            command.Parameters.AddWithValue("@Password", textBoxOldPassword.Text);

            dataBaseConnection.openDatabase();
            int count = (int)command.ExecuteScalar();
            dataBaseConnection.closeDatabase();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NewPasswordCorrectChecked()
        {
            if(textBoxNewPassword.Text == "Новий пароль" || textBoxNewPasswordAgain.Text == "Підтвердити пароль")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Введіть новий пароль і підтвердіть його", "Не введено новий пароль або не підверджено", "Warning");
                customMessageBox.ShowDialog();

                return false;
            }
            else if(textBoxNewPassword.Text == textBoxOldPassword.Text)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Цей пароль нічим не відрізняєтся від старого!", "Старий і новий паролі однакові", "Warning");
                customMessageBox.ShowDialog();
                textBoxNewPassword.Text = "Новий пароль";
                textBoxNewPasswordAgain.Text = "Підтвердити пароль";

                return false;
            }
            else if (!Regex.IsMatch(textBoxNewPassword.Text, @"^(?=.*[a-zа-я])(?=.*[A-ZА-Я])(?=.*\d|\W).{6,25}$"))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Пароль має містити: великі букви, символи, й складатися від 6 до 25 символів", "Некоректний пароль", "Warning");
                customMessageBox.ShowDialog();

                textBoxNewPassword.Text = "Новий пароль";
                textBoxNewPasswordAgain.Text = "Підтвердити пароль";
                return false;
            }
            else if (textBoxNewPassword.Text == DataStorage.nameOfOrgan)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Пароль має відрізнятись від назви Вашої організації!", "Поганий пароль!", "Warning");
                customMessageBox.ShowDialog();

                textBoxNewPassword.Text = "Новий пароль";
                textBoxNewPasswordAgain.Text = "Підтвердити пароль";
                return false;
            }
            else if (textBoxNewPassword.Text != textBoxNewPasswordAgain.Text)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Паролі не співпадають!", "Паролі не співпадають", "Error");
                customMessageBox.ShowDialog();

                textBoxNewPasswordAgain.Text = "Підтвердити пароль";
                return false;
            }

            return true;
        }

        private void ChangePasswordInSqlData()
        {
            SqlCommand command = new SqlCommand($"UPDATE {TableName} SET {TableNamePassword} = @Password WHERE {TableNameId} = @_id", dataBaseConnection.getConnection());

            command.Parameters.AddWithValue("@Password", textBoxNewPassword.Text);
            command.Parameters.AddWithValue("@_id", DataStorage.id);


            dataBaseConnection.openDatabase();
            command.ExecuteNonQuery();

            dataBaseConnection.closeDatabase();

            CustomMessageBox customMessageBox = new CustomMessageBox("Пароль оновлено!", "Успішно", "Success");
            customMessageBox.ShowDialog();
        }

        private void RefreshValuesInformTable()
        {
            FirstNameValue = textBoxPersonName.Text;
            LastNameValue = textBoxPersonLastName.Text;
            NumberValue = textBoxNumberTel.Text;
            PostValue= textBoxPost.Text;
        }
    }
}
