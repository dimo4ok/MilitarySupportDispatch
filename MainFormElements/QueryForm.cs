using FontAwesome.Sharp;
using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.MainFormElements.HelpForm;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    public partial class QueryForm : Form
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

        bool IsMaximized = false;

        public QueryForm()
        {
            InitializeComponent();

            columnName = "Оберіть назву колонки";
            searchText = textBoxSearchText.Text;

            // Підпишіться на події Click та Leave текстового поля
            textBoxSearchText.Click += textBoxSearchText_Click;
            textBoxSearchText.Leave += textBoxSearchText_Leave;

            dataGridViewSupplyTable.Columns["goods_image"].DefaultCellStyle.NullValue = null;
            dataGridViewSupplyTable.Columns["id_supply"].Visible = false;
            dataGridViewSupplyTable.Columns["is_success"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridViewSupplyTable.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridViewSupplyTable.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewSupplyTable.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewSupplyTable.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewSupplyTable.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridViewSupplyTable.GridColor = Color.FromArgb(29, 29, 37);

            if (DataStorage.TypeOfAccount == "Military")
            {
                panelChooseForVolunteers.Visible = false;
                panelChooseForMilitary.Visible = true;

                leftBorderButton = new Panel();
                leftBorderButton.Size = new Size(5, 50);
                panelChooseForMilitary.Controls.Add(leftBorderButton);

                LoadDataGridSupplyTable();
            }
            else if(DataStorage.TypeOfAccount == "Volunteers")
            {
                panelChooseForVolunteers.Visible = true;
                panelChooseForMilitary.Visible = false;

                leftBorderButton = new Panel();
                leftBorderButton.Size = new Size(5, 50);
                panelChooseForVolunteers.Controls.Add(leftBorderButton);

                LoadDataGridSupplyTable();
            }
        }

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

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            HelpQueryForm addForm = new HelpQueryForm("Add", Id);
            addForm.ShowDialog();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonCorrect_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            HelpQueryForm addForm = new HelpQueryForm("Correct", Id);
            addForm.ShowDialog();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            HelpQueryForm addForm = new HelpQueryForm("Delete", Id);
            addForm.ShowDialog();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonHandle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            HelpQueryForm addForm = new HelpQueryForm("Handle", Id);
            addForm.ShowDialog();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonCancelHandle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            HelpQueryForm addForm = new HelpQueryForm("CancelHandle", Id);
            addForm.ShowDialog();
            DisableButton();

            LoadDataGridSupplyTable();
        }

        private void iconButtonMap_Click(object sender, EventArgs e)
        {
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
            LoadDataGridSupplyTable();
        }

        private void LoadDataGridSupplyTable()
        {
            SaveSelectedRowIndexAndScrollBarLocation();

            dataGridViewSupplyTable.Rows.Clear();

            dataBaseConnection.openDatabase();

            if(isSearch)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Supply WHERE {columnName} LIKE '%{searchText}%' ORDER BY id_supply DESC", dataBaseConnection.getConnection());
                sqlDataReader = command.ExecuteReader();
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Supply ORDER BY id_supply DESC", dataBaseConnection.getConnection());
                sqlDataReader = command.ExecuteReader();
            }

            while (sqlDataReader.Read())
            {
                dataGridViewSupplyTable.Rows.Add(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(),
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
                command = new SqlCommand($"SELECT * FROM Supply WHERE {columnName} LIKE '%{searchText}%' ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }
            else
            {
                command = new SqlCommand("SELECT goods_image FROM Supply ORDER BY id_supply DESC", dataBaseConnection.getConnection());
            }

            SqlDataReader reader = command.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
                // Отримуємо посилання на зображення з результату запиту
                object imageObj = reader["goods_image"];


                if (imageObj != DBNull.Value)
                {
                    string imageURL = imageObj.ToString();

                    if (File.Exists(imageURL))
                    {
                        Image image = Image.FromFile(imageURL); // Якщо зображення зберігається локально
                        dataGridViewSupplyTable.Rows[i].Cells["goods_image"].Value = image;
                    }
                }

                i++;
            }
            reader.Close();
        }

        private void dataGridViewSupplyTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (DataStorage.TypeOfAccount == "Volunteers")
            {
                string value = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["vol_nameOfOrgan"].Value.ToString();
                string value2 = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["is_success"].Value.ToString();

                if (!string.IsNullOrEmpty(value))
                {
                    if (value == DataStorage.nameOfOrgan && value2 == "Збирається")
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 33);
                    }
                    else if (value == DataStorage.nameOfOrgan && value2 == "Відправлено")
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(8, 39, 42);
                    }
                    else if (value2 != "")
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 33, 33);
                    }
                }
            }
            else if (DataStorage.TypeOfAccount == "Military")
            {
                string value = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["mil_nameOfOrgan"].Value.ToString();
                string value2 = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["is_success"].Value.ToString();

                if (!string.IsNullOrEmpty(value))
                {
                    if (value != DataStorage.nameOfOrgan)
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 33, 33);
                    }
                    else if (value == DataStorage.nameOfOrgan &&  value2 == "Збирається")
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 33);
                    }
                    else if (value == DataStorage.nameOfOrgan &&  value2 == "Відправлено")
                    {
                        dataGridViewSupplyTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(8, 39, 42);
                    }
                }
            }
        }

        private void dataGridViewSupplyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idValue = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString();
                Id = idValue;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewSupplyTable.Columns[e.ColumnIndex].Name == "goods_image") // Перевіряємо, чи це колонка з фото
                {
                    string id = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowLargeImage(id);
                }
            }
        }

        private void SaveSelectedRowIndexAndScrollBarLocation()
        {
            if (dataGridViewSupplyTable.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridViewSupplyTable.SelectedRows[0].Index;
            }

            verticalScrollPosition = dataGridViewSupplyTable.FirstDisplayedScrollingRowIndex;
            horizontalScrollPosition = dataGridViewSupplyTable.FirstDisplayedScrollingColumnIndex;
        }

        // Встановити збережений індекс як обраний рядок після оновлення
        private void RestoreSelectedRowAndScrollBarLocation()
        {
            dataGridViewSupplyTable.ClearSelection();

            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewSupplyTable.Rows.Count)
            {
                dataGridViewSupplyTable.Rows[selectedRowIndex].Selected = true;
                Id = dataGridViewSupplyTable.Rows[selectedRowIndex].Cells["id_supply"].Value.ToString();
            }
            else
            {
                Id = null;
            }

            if (verticalScrollPosition >= 0 && verticalScrollPosition < dataGridViewSupplyTable.RowCount)
            {
                dataGridViewSupplyTable.FirstDisplayedScrollingRowIndex = verticalScrollPosition;
            }

            if (horizontalScrollPosition >= 0 && horizontalScrollPosition < dataGridViewSupplyTable.ColumnCount) 
            {
                dataGridViewSupplyTable.FirstDisplayedScrollingColumnIndex = horizontalScrollPosition;
            }
        }

        private void dataGridViewSupplyTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewSupplyTable.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            dataGridViewSupplyTable.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(37, 36, 53);

            columnName = dataGridViewSupplyTable.Columns[e.ColumnIndex].Name;
            TextBoxColumnHeaderText.Text = dataGridViewSupplyTable.Columns[e.ColumnIndex].HeaderText;
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

            foreach (DataGridViewColumn column in dataGridViewSupplyTable.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(29, 29, 37);
            }

            isSearch = false;
            LoadDataGridSupplyTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(searchText == "Пошук по ключових словах")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Для пошуку потрібно ввести ключове слово!", "Ключове слово не введено", "Warning");
                customMessageBox.ShowDialog();
            }
            else if(columnName == "Оберіть назву колонки")
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

        private void ShowMap(string idDelivaryLocation)
        {
            GoogleMap googleMap = new GoogleMap(idDelivaryLocation);
            googleMap.ShowDialog();
        }

        private void QueryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (googleMapForm == null || googleMapForm.IsDisposed)
            {
            }
            else
            {
                googleMapForm.Close();
            }
        }

        private void dataGridViewSupplyTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewSupplyTable.Columns[e.ColumnIndex].Name == "delivery_location") // Перевіряємо, чи це колонка з фото
                {
                    string idDeliveryLocation = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["id_supply"].Value.ToString(); // Отримуємо шлях до файлу фото

                    // Відобразіть фото у більшому форматі, наприклад, у новому вікні
                    ShowMap(idDeliveryLocation);
                }

                if(dataGridViewSupplyTable.Columns[e.ColumnIndex].Name == "mil_nameOfOrgan")
                {
                    string OrganName = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["mil_nameOfOrgan"].Value.ToString(); 
                   
                    ShowAccountInform("Military", OrganName);
                }
                else if (dataGridViewSupplyTable.Columns[e.ColumnIndex].Name == "vol_nameOfOrgan")
                {
                    string OrganName = dataGridViewSupplyTable.Rows[e.RowIndex].Cells["vol_nameOfOrgan"].Value.ToString(); 

                    ShowAccountInform("Volunteers", OrganName);
                }
            }
        }

        private void ShowAccountInform(string table, string nameOrgan)
        {
            AccountInform accountInform = new AccountInform(table, nameOrgan);
            accountInform.ShowDialog();
        }

        private void QueryForm_SizeChanged(object sender, EventArgs e)
        {
            if (IsMaximized == false)
            {
                IsMaximized = true;
                dataGridViewSupplyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                IsMaximized = false;
                dataGridViewSupplyTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
