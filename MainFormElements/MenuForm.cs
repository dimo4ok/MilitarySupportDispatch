using FontAwesome.Sharp;
using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.MainFormElements.HelpForm;
using MilitarySupportDispatch.MainForms.ElementsMainForms;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainForms.VolunteerFormsElements
{
    public partial class MenuForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        private SqlDataAdapter adapter;
        private DataTable table;
        private SqlDataReader sqlDataReader;

        private IconButton currentButton;
        private Panel leftBorderButton;

        string Id;

        private int selectedRowIndex = -1;
        private int verticalScrollPosition;
        private int horizontalScrollPosition;

        private string columnName;
        private string searchText;
        private bool isSearch = false;

        private GoogleMap googleMapForm;

        private string nameOfOrgan;

        bool IsMaximized = false;

        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(137, 55, 51);
            public static Color color2 = Color.FromArgb(141, 200, 155);
            public static Color color3 = Color.FromArgb(139, 183, 245);
            public static Color color4 = Color.FromArgb(197, 173, 209);
            public static Color color5 = Color.FromArgb(238, 199, 129);
            public static Color color6 = Color.FromArgb(249, 162, 139);
            public static Color color7 = Color.FromArgb(96, 206, 175);
        }

        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                //for button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 41);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;

                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //for panel
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(38, 39, 42);
                currentButton.ForeColor = Color.FromArgb(220, 220, 219);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;

                currentButton.IconColor = Color.FromArgb(220, 220, 219);
                currentButton.TextImageRelation = TextImageRelation.Overlay;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

                leftBorderButton.Visible = false;
            }
        }

        public MenuForm()
        {
            InitializeComponent();
            
            columnName = "Оберіть назву колонки";
            searchText = textBoxSearchText.Text;

            // Підпишіться на події Click та Leave текстового поля
            textBoxSearchText.Click += textBoxSearchText_Click;
            textBoxSearchText.Leave += textBoxSearchText_Leave;

            dataGridViewGeneralSupplyTable.Columns["goods_image"].DefaultCellStyle.NullValue = null;
            dataGridViewGeneralSupplyTable.Columns["id_supply"].Visible = false;
            dataGridViewGeneralSupplyTable.Columns["datetime_add"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridViewGeneralSupplyTable.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridViewGeneralSupplyTable.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewGeneralSupplyTable.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewGeneralSupplyTable.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewGeneralSupplyTable.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridViewGeneralSupplyTable.GridColor = Color.FromArgb(29, 29, 37);

            if (DataStorage.TypeOfAccount == "Military")
            {
                dataGridViewGeneralSupplyTable.Columns["mil_nameOfOrgan"].Visible = false;

                panelChooseForVolunteers.Visible = false;

                leftBorderButton = new Panel();
                leftBorderButton.Size = new Size(5, 50);

                nameOfOrgan = "mil_nameOfOrgan";

                LoadDataGridSupplyTable();
            }
            else if(DataStorage.TypeOfAccount == "Volunteers")
            {
                dataGridViewGeneralSupplyTable.Columns["vol_nameOfOrgan"].Visible = false;

                panelChooseForMilitary.Visible = false;

                leftBorderButton = new Panel();
                leftBorderButton.Size = new Size(5, 50);

                nameOfOrgan = "vol_nameOfOrgan";

                LoadDataGridSupplyTable();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButtonAcceptCancelShipping_Click(object sender, EventArgs e)
        {
            panelChooseForVolunteers.Controls.Add(leftBorderButton);
            ActivateButton(sender, RGBColors.color7);

            ChangeStatus();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonConfirmReceiving_Click(object sender, EventArgs e)
        {
            panelChooseForMilitary.Controls.Add(leftBorderButton);
            ActivateButton(sender, RGBColors.color7);

            ChangeStatus();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonMap_Click(object sender, EventArgs e)
        {
            panelMap.Controls.Add(leftBorderButton);
            ActivateButton(sender, RGBColors.color6);

            if (googleMapForm == null || googleMapForm.IsDisposed)
            {
                googleMapForm = new GoogleMap("None");
                googleMapForm.FormClosed += GoogleMapForm_FormClosed;
                googleMapForm.Show();
            }
            else
            {
                googleMapForm.Activate();
            }
        }

        private void GoogleMapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisableButton();
            //LoadDataGridSupplyTable();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (googleMapForm == null || googleMapForm.IsDisposed)
            {
            }
            else
            {
                googleMapForm.Close();
            }
        }

        private void LoadDataGridSupplyTable()
        {
            SaveSelectedRowIndexAndScrollBarLocation();

            dataGridViewGeneralSupplyTable.Rows.Clear();

            dataBaseConnection.openDatabase();

            SqlCommand command;

            if (isSearch)
            {
                command = new SqlCommand($"SELECT * FROM Supply WHERE {columnName} LIKE '%{searchText}%' AND {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }
            else
            {
                command = new SqlCommand($"SELECT * FROM Supply WHERE {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }

            command.Parameters.AddWithValue("@NameOfOrgan", DataStorage.nameOfOrgan);
            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                dataGridViewGeneralSupplyTable.Rows.Add(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(),
                    sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString(), sqlDataReader[7].ToString(),
                    sqlDataReader[8].ToString(), sqlDataReader[9].ToString(), sqlDataReader[10].ToString());
            }
            sqlDataReader.Close();

            LoadSupplyImage(isSearch);

            dataBaseConnection.closeDatabase();

            RestoreSelectedRowAndScrollBarLocation();
        }

        private void LoadSupplyImage(bool isSearch = false)
        {
            SqlCommand command;

            if (isSearch)
            {
                command = new SqlCommand($"SELECT * FROM Supply WHERE {columnName} LIKE '%{searchText}%' AND {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }
            else
            {
                command = new SqlCommand($"SELECT goods_image FROM Supply WHERE {nameOfOrgan} = @NameOfOrgan ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }

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
                        dataGridViewGeneralSupplyTable.Rows[i].Cells["goods_image"].Value = image;
                    }
                }

                i++;
            }
            reader.Close();
        }

        private void dataGridViewGeneralSupplyTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string value2 = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["is_success"].Value.ToString();
           
            if (value2 == "Збирається")
            {
                dataGridViewGeneralSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 33);
            }
            else if (value2 == "Відправлено")
            {
                dataGridViewGeneralSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(8, 39, 42);
            }
        }

        private void dataGridViewGeneralSupplyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idValue = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString();
                Id = idValue;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].Name == "goods_image") // Перевіряємо, чи це колонка з фото
                {
                    string id = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowLargeImage(id);
                }
            }
        }

        private void SaveSelectedRowIndexAndScrollBarLocation()
        {
            if (dataGridViewGeneralSupplyTable.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridViewGeneralSupplyTable.SelectedRows[0].Index;
            }

            verticalScrollPosition = dataGridViewGeneralSupplyTable.FirstDisplayedScrollingRowIndex;
            horizontalScrollPosition = dataGridViewGeneralSupplyTable.FirstDisplayedScrollingColumnIndex;
        }

        // Встановити збережений індекс як обраний рядок після оновлення
        private void RestoreSelectedRowAndScrollBarLocation()
        {
            dataGridViewGeneralSupplyTable.ClearSelection();

            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewGeneralSupplyTable.Rows.Count)
            {
                dataGridViewGeneralSupplyTable.Rows[selectedRowIndex].Selected = true;
                Id = dataGridViewGeneralSupplyTable.Rows[selectedRowIndex].Cells["id_supply"].Value.ToString();
            }
            else
            {
                Id = null;
            }

            if (verticalScrollPosition >= 0 && verticalScrollPosition < dataGridViewGeneralSupplyTable.RowCount)
            {
                dataGridViewGeneralSupplyTable.FirstDisplayedScrollingRowIndex = verticalScrollPosition;
            }

            if (horizontalScrollPosition >= 0 && horizontalScrollPosition < dataGridViewGeneralSupplyTable.ColumnCount)
            {
                dataGridViewGeneralSupplyTable.FirstDisplayedScrollingColumnIndex = horizontalScrollPosition;
            }
        }

        private void dataGridViewGeneralSupplyTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewGeneralSupplyTable.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(37, 36, 53);

            columnName = dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].Name;
            TextBoxColumnHeaderText.Text = dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].HeaderText;
        }

        private void textBoxSearchText_Click(object sender, EventArgs e)
        {
            if (textBoxSearchText.Text == "Пошук по ключових словах")
            {
                textBoxSearchText.Text = "";
            }
        }

        private void textBoxSearchText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearchText.Text))
            {
                textBoxSearchText.Text = "Пошук по ключових словах";
            }
            searchText = textBoxSearchText.Text;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearchText.Text = "Пошук по ключових словах";
            TextBoxColumnHeaderText.Text = "Оберіть назву колонки";
            searchText = textBoxSearchText.Text;
            columnName = TextBoxColumnHeaderText.Text;

            foreach (DataGridViewColumn column in dataGridViewGeneralSupplyTable.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            isSearch = false;
            LoadDataGridSupplyTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchText == "Пошук по ключових словах")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Для пошуку потрібно ввести ключове слово!", "Ключове слово не введено", "Warning");
                customMessageBox.ShowDialog();
            }
            else if (columnName == "Оберіть назву колонки")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Для пошуку потрібно обрати назву колонки!", "Колонку не обрано", "Warning");
                customMessageBox.ShowDialog();
            }
            else
            {
                isSearch = true;
                LoadDataGridSupplyTable();
            }
        }

        private void ShowLargeImage(string idImage)
        {
            LargeImageForm largeImageForm = new LargeImageForm(idImage);
            largeImageForm.ShowDialog();
        }

        private void dataGridViewGeneralSupplyTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].Name == "delivery_location") // Перевіряємо, чи це колонка з фото
                {
                    string idDeliveryLocation = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowMap(idDeliveryLocation);
                }

                if (dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].Name == "mil_nameOfOrgan")
                {
                    string OrganName = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["mil_nameOfOrgan"].Value.ToString();

                    ShowAccountInform("Military", OrganName);
                }
                else if (dataGridViewGeneralSupplyTable.Columns[e.ColumnIndex].Name == "vol_nameOfOrgan")
                {
                    string OrganName = dataGridViewGeneralSupplyTable.Rows[e.RowIndex].Cells["vol_nameOfOrgan"].Value.ToString();

                    ShowAccountInform("Volunteers", OrganName);
                }
            }
        }

        private void ShowMap(string idDelivaryLocation)
        {
            GoogleMap googleMap = new GoogleMap(idDelivaryLocation);
            googleMap.ShowDialog();
        }

        private string GetStatusQuery()
        {
            if(Id != null)
            {
                string Status = null;
                dataBaseConnection.openDatabase();

                SqlCommand command = new SqlCommand($"SELECT is_success FROM Supply WHERE id_supply = @SupplyID", dataBaseConnection.getConnection());
                command.Parameters.AddWithValue("@SupplyID", Id);

                sqlDataReader = command.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    Status = sqlDataReader["is_success"].ToString();
                }

                sqlDataReader.Close();

                dataBaseConnection.closeDatabase();

                return Status;
            }
            else
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Оберіть рядок над яким потрібно виконати дію!", "Рядок не обрано", "Warning");
                customMessageBox.ShowDialog();
                return null;
            }
            
        }

        private void ChangeStatus()
        {
            CustomMessageBox customMessageBox;
            string status = GetStatusQuery();

            if (status == null)
                return;

            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand(@"UPDATE Supply SET is_success = @Status WHERE id_supply = @SupplyID", dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@SupplyID", Id);

            if (DataStorage.TypeOfAccount == "Military")
            {
                if (string.IsNullOrEmpty(status))
                {
                    customMessageBox = new CustomMessageBox("Ви не можете змінити дані про статус, адже запит не був прийнятий волонтерами!", "Помилка", "Error");
                    customMessageBox.ShowDialog();
                    return;
                }
                else
                {
                    customMessageBox = new CustomMessageBox("Ви справді бажаєте підтвердити отримання посилки? Запит автоматично зникне (з'явиться в історії)", "Підтвердити", "QuestionConfirmRecieve");
                    customMessageBox.ShowDialog();

                    if (customMessageBox.CheckReturn())
                    {
                        command.Parameters.AddWithValue("@Status", "Отримано");
                        command.ExecuteNonQuery();

                        HistorySupply();

                        customMessageBox = new CustomMessageBox("Дані про посилку змінено!", "Посилку отримано", "Success");
                        customMessageBox.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (DataStorage.TypeOfAccount == "Volunteers")
            {
                if (string.IsNullOrEmpty(status) || status == "Збирається") 
                {
                    command.Parameters.AddWithValue("@Status", "Відправлено");
                    customMessageBox = new CustomMessageBox("Дані про посилку змінено!", "Посилку відправлено", "Success");
                    customMessageBox.ShowDialog();
                }
                else if(status == "Відправлено")
                {
                    command.Parameters.AddWithValue("@Status", "Збирається");
                    customMessageBox = new CustomMessageBox("Дані про посилку змінено!", "Посилка збирається", "Success");
                    customMessageBox.ShowDialog();
                }

                command.ExecuteNonQuery();
            }


            dataBaseConnection.closeDatabase();
        }

        private void HistorySupply()
        {
            SqlCommand getMaxIdCommand = new SqlCommand("SELECT MAX(id_supply) FROM SuccessHistorySupply", dataBaseConnection.getConnection());
            object result = getMaxIdCommand.ExecuteScalar();
            int maxId = result != DBNull.Value ? (int)result : 0; 

            maxId++;

            SqlCommand insertCommand = new SqlCommand(@"INSERT INTO SuccessHistorySupply (id_supply, mil_nameOfOrgan, category, name_of_goods, name_of_company, number_of_goods, delivery_location, datetime_add, vol_nameOfOrgan, datetime_accept, is_success, goods_image)
                                            SELECT @newId, mil_nameOfOrgan, category, name_of_goods, name_of_company, number_of_goods, delivery_location, datetime_add, vol_nameOfOrgan, datetime_accept, is_success, goods_image
                                            FROM Supply
                                            WHERE id_supply = @id;", dataBaseConnection.getConnection());
            insertCommand.Parameters.AddWithValue("@id", Id);
            insertCommand.Parameters.AddWithValue("@newId", maxId);
            insertCommand.ExecuteNonQuery();

            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Supply WHERE id_supply = @id", dataBaseConnection.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", Id);
            deleteCommand.ExecuteNonQuery();

            UpdateId_supplyAfterDelete();
        }

        private void UpdateId_supplyAfterDelete()
        {
            string query = @"
                WITH UpdateCTE AS (
                    SELECT id_supply,
                           ROW_NUMBER() OVER (ORDER BY id_supply) AS NewRowID
                    FROM Supply
                )
                UPDATE UpdateCTE
                SET id_supply = NewRowID";

            // Створення команди SQL
            using (SqlCommand command = new SqlCommand(query, dataBaseConnection.getConnection()))
            {
                // Виконання запиту
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void ShowAccountInform(string table, string nameOrgan)
        {
            AccountInform accountInform = new AccountInform(table, nameOrgan);
            accountInform.ShowDialog();
        }

        private void MenuForm_SizeChanged(object sender, EventArgs e)
        {
            if (IsMaximized == false)
            {
                IsMaximized = true;
                dataGridViewGeneralSupplyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                IsMaximized = false;
                dataGridViewGeneralSupplyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
