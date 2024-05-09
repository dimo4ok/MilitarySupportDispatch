using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainFormElements
{
    public partial class VolunteersListForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        private SqlDataReader sqlDataReader;

        private string searchText;
        private bool isSearch = false;

        public VolunteersListForm()
        {
            InitializeComponent();

            textBoxSearchText.Click += textBoxSearchText_Click;
            textBoxSearchText.Leave += textBoxSearchText_Leave;

            searchText = textBoxSearchText.Text;

            dataGridVolunteersList.Columns["id_volunter"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridVolunteersList.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridVolunteersList.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridVolunteersList.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridVolunteersList.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridVolunteersList.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridVolunteersList.GridColor = Color.FromArgb(29, 29, 37);
        }

        private void VolunteersListForm_Load(object sender, EventArgs e)
        {
            LoadDataGridVolunteersInfoTable();
        }

        private void LoadDataGridVolunteersInfoTable()
        {
            dataGridVolunteersList.Rows.Clear();

            dataBaseConnection.openDatabase();

            if (!isSearch)
            {
                SqlCommand command = new SqlCommand(@"SELECT InformVol.*, Volunteers.vol_nameOfOrgan 
                                    FROM InformVol 
                                    LEFT JOIN Volunteers ON InformVol.id_volunter = Volunteers.vol_id 
                                    WHERE Volunteers.vol_showInform = 1
                                    ORDER BY InformVol.id_volunter", dataBaseConnection.getConnection());

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridVolunteersList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[5].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    sqlDataReader[2].ToString(),
                                                    sqlDataReader[3].ToString(),
                                                    sqlDataReader[4].ToString());
                }

                sqlDataReader.Close();

                command = new SqlCommand(@"SELECT InformVol.id_volunter, Volunteers.vol_nameOfOrgan 
                    FROM InformVol 
                    LEFT JOIN Volunteers ON InformVol.id_volunter = Volunteers.vol_id 
                    WHERE Volunteers.vol_showInform = 0
                    ORDER BY InformVol.id_volunter", dataBaseConnection.getConnection());

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridVolunteersList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    "Не надано дозволу",
                                                    "Не надано дозволу",
                                                    "Не надано дозволу",
                                                    "Не надано дозволу");
                }

                sqlDataReader.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand(@"SELECT InformVol.*, Volunteers.vol_nameOfOrgan 
                                    FROM InformVol 
                                    LEFT JOIN Volunteers ON InformVol.id_volunter = Volunteers.vol_id 
                                    WHERE Volunteers.vol_showInform = 1 AND Volunteers.vol_nameOfOrgan LIKE @SearchText 
                                    ORDER BY InformVol.id_volunter", dataBaseConnection.getConnection());

                // Додамо параметр для пошуку
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridVolunteersList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[5].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    sqlDataReader[2].ToString(),
                                                    sqlDataReader[3].ToString(),
                                                    sqlDataReader[4].ToString());
                }

                sqlDataReader.Close();

                command = new SqlCommand(@"SELECT InformVol.id_volunter, Volunteers.vol_nameOfOrgan 
                                    FROM InformVol 
                                    LEFT JOIN Volunteers ON InformVol.id_volunter = Volunteers.vol_id 
                                    WHERE Volunteers.vol_showInform = 0 AND Volunteers.vol_nameOfOrgan LIKE @SearchText 
                                    ORDER BY InformVol.id_volunter", dataBaseConnection.getConnection());

                // Додамо параметр для пошуку
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridVolunteersList.Rows.Add(sqlDataReader[0].ToString(),
                                                   sqlDataReader[1].ToString(),
                                                   "Не надано дозволу",
                                                   "Не надано дозволу",
                                                   "Не надано дозволу",
                                                   "Не надано дозволу");
                }

                sqlDataReader.Close();
            }


            dataBaseConnection.closeDatabase();

            dataGridVolunteersList.ClearSelection();
        }

        private void dataGridMilitaryList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((dataGridVolunteersList.Rows[e.RowIndex].Cells["vol_nameOfOrgan"].Value.ToString() == DataStorage.nameOfOrgan) && (DataStorage.TypeOfAccount == "Volunteers"))
            {
                dataGridVolunteersList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 88, 58);
            }
        }

        private void textBoxSearchText_Click(object sender, EventArgs e)
        {
            if (textBoxSearchText.Text == "Пошук по назві організації")
            {
                textBoxSearchText.Text = "";
            }
        }

        private void textBoxSearchText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearchText.Text))
            {
                textBoxSearchText.Text = "Пошук по назві організації";
            }
            searchText = textBoxSearchText.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearchText.Text = "Пошук по назві організації";
            searchText = textBoxSearchText.Text;

            foreach (DataGridViewColumn column in dataGridVolunteersList.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            isSearch = false;
            LoadDataGridVolunteersInfoTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchText == "Пошук по назві організації")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Для пошуку потрібно ввести назву організації!", "Ключове слово не введено", "Warning");
                customMessageBox.ShowDialog();
            }
            else
            {
                isSearch = true;
                LoadDataGridVolunteersInfoTable();
            }
        }
    }
}
