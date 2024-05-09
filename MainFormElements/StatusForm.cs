using MilitarySupportDispatch.ClassesData;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MilitarySupportDispatch.MainForms.ElementsMainForms;
using System.IO;
using MilitarySupportDispatch.MainFormElements.HelpForm;


namespace MilitarySupportDispatch.MainFormElements
{

    public partial class StatusForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        private SqlDataReader sqlDataReader;

        string Id;

        private string nameOfOrgan;

        private int selectedRowIndex = -1;
        private int verticalScrollPosition;
        private int horizontalScrollPosition;

        private GoogleMap googleMapForm;

        bool IsMaximized = false;

        public StatusForm()
        {
            InitializeComponent();

            dataGridViewSucceedSupplyHistory.Columns["goods_image"].DefaultCellStyle.NullValue = null;
            dataGridViewSucceedSupplyHistory.Columns["id_supply"].Visible = false;
            dataGridViewSucceedSupplyHistory.Columns["is_success"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridViewSucceedSupplyHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridViewSucceedSupplyHistory.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewSucceedSupplyHistory.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewSucceedSupplyHistory.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewSucceedSupplyHistory.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridViewSucceedSupplyHistory.GridColor = Color.FromArgb(29, 29, 37);
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            FillStatusElements(DataStorage.TypeOfAccount, DataStorage.nameOfOrgan);
            LoadDataGridSuccessHistorySupply();
        }

        private void FillStatusElements(string typeOfAccount, string NameOfOrgan)
        {
            dataBaseConnection.openDatabase();
            SqlCommand command;

            if (typeOfAccount == "Military")
            {
                dataGridViewSucceedSupplyHistory.Columns["mil_nameOfOrgan"].Visible = false;

                nameOfOrgan = "mil_nameOfOrgan";

                command = new SqlCommand("SELECT COUNT(*) FROM SuccessHistorySupply WHERE mil_nameOfOrgan = @NameOfOrgan", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                labelMilitarySuccesDelivered.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE mil_nameOfOrgan = @NameOfOrgan AND is_success = @Shipped", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                command.Parameters.AddWithValue("@Shipped", "Відправлено");
                labelMilitaryShipped.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE mil_nameOfOrgan = @NameOfOrgan AND is_success = @Shipped", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                command.Parameters.AddWithValue("@Shipped", "Збирається");
                labelMilitaryGoing.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE mil_nameOfOrgan = @NameOfOrgan AND is_success IS NULL", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                //command.Parameters.AddWithValue("@Null", DBNull.Value);
                labelMilitaryUnhandleQuery.Text = command.ExecuteScalar().ToString();
            }
            else if(typeOfAccount == "Volunteers")
            {
                dataGridViewSucceedSupplyHistory.Columns["vol_nameOfOrgan"].Visible = false;

                nameOfOrgan = "vol_nameOfOrgan";

                label2.Text = "Успішні";
                label8.Text = "Загальна кількість запитів,\r\nщо ніким не обробляються";

                command = new SqlCommand("SELECT COUNT(*) FROM SuccessHistorySupply WHERE vol_nameOfOrgan = @NameOfOrgan", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                labelMilitarySuccesDelivered.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE vol_nameOfOrgan = @NameOfOrgan AND is_success = @Shipped", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                command.Parameters.AddWithValue("@Shipped", "Відправлено");
                labelMilitaryShipped.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE vol_nameOfOrgan = @NameOfOrgan AND is_success = @Shipped", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                command.Parameters.AddWithValue("@Shipped", "Збирається");
                labelMilitaryGoing.Text = command.ExecuteScalar().ToString();

                command = new SqlCommand("SELECT COUNT(*) FROM Supply WHERE vol_nameOfOrgan IS NULL AND is_success IS NULL", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@NameOfOrgan", NameOfOrgan);
                //command.Parameters.AddWithValue("@Null", DBNull.Value);
                labelMilitaryUnhandleQuery.Text = command.ExecuteScalar().ToString();
            }

            dataBaseConnection.closeDatabase();
        }

        private void LoadDataGridSuccessHistorySupply()
        {
            SaveSelectedRowIndexAndScrollBarLocation();

            dataGridViewSucceedSupplyHistory.Rows.Clear();

            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand($"SELECT * FROM SuccessHistorySupply WHERE {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());

            command.Parameters.AddWithValue("@NameOfOrgan", DataStorage.nameOfOrgan);
            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                dataGridViewSucceedSupplyHistory.Rows.Add(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(),
                    sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString(), sqlDataReader[7].ToString(),
                    sqlDataReader[8].ToString(), sqlDataReader[9].ToString(), sqlDataReader[10].ToString());
            }
            sqlDataReader.Close();

            LoadSuccessHistorySupplyImage();

            dataBaseConnection.closeDatabase();

            RestoreSelectedRowAndScrollBarLocation();
        }

        private void LoadSuccessHistorySupplyImage()
        {
            SqlCommand command = new SqlCommand($"SELECT goods_image FROM SuccessHistorySupply WHERE {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());

            command.Parameters.AddWithValue("@NameOfOrgan", DataStorage.nameOfOrgan);

            SqlDataReader reader = command.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
                // Отримуємо посилання на зображення з результату запиту
                object imageObj = reader["goods_image"];


                if (imageObj != DBNull.Value)
                {
                    string imageURL = imageObj.ToString();
                    // Завантажуємо зображення з URL (або файлу) 
                    // і додаємо його до DataGridView

                    if (File.Exists(imageURL))
                    {
                        Image image = Image.FromFile(imageURL); // Якщо зображення зберігається локально
                        dataGridViewSucceedSupplyHistory.Rows[i].Cells["goods_image"].Value = image;
                    }
                }

                i++;
            }
            reader.Close();
        }

        private void dataGridViewSucceedSupplyHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idValue = dataGridViewSucceedSupplyHistory.Rows[e.RowIndex].Cells["id_supply"].Value.ToString();
                Id = idValue;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewSucceedSupplyHistory.Columns[e.ColumnIndex].Name == "goods_image") // Перевіряємо, чи це колонка з фото
                {
                    string id = dataGridViewSucceedSupplyHistory.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowLargeImage(id);
                }
            }
        }

        private void dataGridViewSucceedSupplyHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewSucceedSupplyHistory.Columns[e.ColumnIndex].Name == "delivery_location") // Перевіряємо, чи це колонка з фото
                {
                    string idDeliveryLocation = dataGridViewSucceedSupplyHistory.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowMap(idDeliveryLocation);
                }

                if(dataGridViewSucceedSupplyHistory.Columns[e.ColumnIndex].Name == "mil_nameOfOrgan")
                {
                    string OrganName = dataGridViewSucceedSupplyHistory.Rows[e.RowIndex].Cells["mil_nameOfOrgan"].Value.ToString(); 
                   
                    ShowAccountInform("Military", OrganName);
                }
                else if (dataGridViewSucceedSupplyHistory.Columns[e.ColumnIndex].Name == "vol_nameOfOrgan")
                {
                    string OrganName = dataGridViewSucceedSupplyHistory.Rows[e.RowIndex].Cells["vol_nameOfOrgan"].Value.ToString(); 

                    ShowAccountInform("Volunteers", OrganName);
                }
            }
        }

        private void SaveSelectedRowIndexAndScrollBarLocation()
        {
            if (dataGridViewSucceedSupplyHistory.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridViewSucceedSupplyHistory.SelectedRows[0].Index;
            }

            verticalScrollPosition = dataGridViewSucceedSupplyHistory.FirstDisplayedScrollingRowIndex;
            horizontalScrollPosition = dataGridViewSucceedSupplyHistory.FirstDisplayedScrollingColumnIndex;
        }

        // Встановити збережений індекс як обраний рядок після оновлення
        private void RestoreSelectedRowAndScrollBarLocation()
        {
            dataGridViewSucceedSupplyHistory.ClearSelection();

            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewSucceedSupplyHistory.Rows.Count)
            {
                dataGridViewSucceedSupplyHistory.Rows[selectedRowIndex].Selected = true;
                Id = dataGridViewSucceedSupplyHistory.Rows[selectedRowIndex].Cells["id_supply"].Value.ToString();
            }
            else
            {
                Id = null;
            }

            if (verticalScrollPosition >= 0 && verticalScrollPosition < dataGridViewSucceedSupplyHistory.RowCount)
            {
                dataGridViewSucceedSupplyHistory.FirstDisplayedScrollingRowIndex = verticalScrollPosition;
            }

            if (horizontalScrollPosition >= 0 && horizontalScrollPosition < dataGridViewSucceedSupplyHistory.ColumnCount)
            {
                dataGridViewSucceedSupplyHistory.FirstDisplayedScrollingColumnIndex = horizontalScrollPosition;
            }
        }

        private void ShowLargeImage(string idImage)
        {
            LargeImageForm largeImageForm = new LargeImageForm(idImage, "SuccessHistorySupply");
            largeImageForm.ShowDialog();
        }
        private void ShowMap(string idDelivaryLocation)
        {
            GoogleMap googleMap = new GoogleMap(idDelivaryLocation, false, "SuccessHistorySupply");
            googleMap.ShowDialog();
        }
        private void ShowAccountInform(string table, string nameOrgan)
        {
            AccountInform accountInform = new AccountInform(table, nameOrgan);
            accountInform.ShowDialog();
        }

        private void StatusForm_SizeChanged(object sender, EventArgs e)
        {
            if (IsMaximized == false)
            {
                IsMaximized = true;
                dataGridViewSucceedSupplyHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                IsMaximized = false;
                dataGridViewSucceedSupplyHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
