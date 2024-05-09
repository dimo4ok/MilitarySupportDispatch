using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilitarySupportDispatch.MainFormElements
{
    public partial class MilitaryListForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        private SqlDataReader sqlDataReader;

        private string searchText;
        private bool isSearch = false;

        public MilitaryListForm()
        {
            InitializeComponent();

            textBoxSearchText.Click += textBoxSearchText_Click;
            textBoxSearchText.Leave += textBoxSearchText_Leave;

            searchText = textBoxSearchText.Text;

            dataGridMilitaryList.Columns["mil_id"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridMilitaryList.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridMilitaryList.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridMilitaryList.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridMilitaryList.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridMilitaryList.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridMilitaryList.GridColor = Color.FromArgb(29, 29, 37);
        }

        private void MilitaryListForm_Load(object sender, EventArgs e)
        {
            LoadDataGridMilitaryInfoTable();
        }

        private void LoadDataGridMilitaryInfoTable()
        {
            dataGridMilitaryList.Rows.Clear();

            dataBaseConnection.openDatabase();

            if (!isSearch)
            {
                SqlCommand command = new SqlCommand(@"SELECT InformMil.*, Military.mil_nameOfOrgan 
                                    FROM InformMil 
                                    LEFT JOIN Military ON InformMil.id_military = Military.mil_id 
                                    WHERE Military.mil_showInform = 1
                                    ORDER BY InformMil.id_military", dataBaseConnection.getConnection());

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridMilitaryList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[5].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    sqlDataReader[2].ToString(),
                                                    sqlDataReader[3].ToString(),
                                                    sqlDataReader[4].ToString());
                }

                sqlDataReader.Close();

                command = new SqlCommand(@"SELECT InformMil.id_military, Military.mil_nameOfOrgan 
                    FROM InformMil 
                    LEFT JOIN Military ON InformMil.id_military = Military.mil_id 
                    WHERE Military.mil_showInform = 0
                    ORDER BY InformMil.id_military", dataBaseConnection.getConnection());

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridMilitaryList.Rows.Add(sqlDataReader[0].ToString(),
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
                SqlCommand command = new SqlCommand(@"SELECT InformMil.id_military, Military.mil_nameOfOrgan 
                                    FROM InformMil 
                                    LEFT JOIN Military ON InformMil.id_military = Military.mil_id 
                                    WHERE Military.mil_showInform = 0 AND Military.mil_nameOfOrgan LIKE @SearchText 
                                    ORDER BY InformMil.id_military", dataBaseConnection.getConnection());

                // Додамо параметр для пошуку
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridMilitaryList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    "Не надано дозволу",
                                                    "Не надано дозволу",
                                                    "Не надано дозволу",
                                                    "Не надано дозволу");
                }

                sqlDataReader.Close();

                command = new SqlCommand(@"SELECT InformMil.*, Military.mil_nameOfOrgan 
                                    FROM InformMil 
                                    LEFT JOIN Military ON InformMil.id_military = Military.mil_id 
                                    WHERE Military.mil_showInform = 1 AND Military.mil_nameOfOrgan LIKE @SearchText 
                                    ORDER BY InformMil.id_military", dataBaseConnection.getConnection());

                // Додамо параметр для пошуку
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dataGridMilitaryList.Rows.Add(sqlDataReader[0].ToString(),
                                                    sqlDataReader[5].ToString(),
                                                    sqlDataReader[1].ToString(),
                                                    sqlDataReader[2].ToString(),
                                                    sqlDataReader[3].ToString(),
                                                    sqlDataReader[4].ToString());
                }

                sqlDataReader.Close();
            }


            dataBaseConnection.closeDatabase();

            dataGridMilitaryList.ClearSelection();
        }

        private void dataGridMilitaryList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((dataGridMilitaryList.Rows[e.RowIndex].Cells["mil_nameOfOrgan"].Value.ToString() == DataStorage.nameOfOrgan) && (DataStorage.TypeOfAccount == "Military"))
            {
                dataGridMilitaryList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(39, 57, 61);
            }
        }

        private void textBoxSearchText_Click(object sender, EventArgs e)
        {
            if (textBoxSearchText.Text == "Пошук по назві бригади")
            {
                textBoxSearchText.Text = "";
            }
        }

        private void textBoxSearchText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearchText.Text))
            {
                textBoxSearchText.Text = "Пошук по назві бригади";
            }
            searchText = textBoxSearchText.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearchText.Text = "Пошук по назві бригади";
            searchText = textBoxSearchText.Text;

            foreach (DataGridViewColumn column in dataGridMilitaryList.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            isSearch = false;
            LoadDataGridMilitaryInfoTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchText == "Пошук по назві бригади")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Для пошуку потрібно ввести назву бригади!", "Ключове слово не введено", "Warning");
                customMessageBox.ShowDialog();
            }
            else
            {
                isSearch = true;
                LoadDataGridMilitaryInfoTable();
            }
        }
    }
}
