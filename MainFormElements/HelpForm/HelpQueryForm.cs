using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    public partial class HelpQueryForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private bool isDragging = false;
        private int offsetX, offsetY;

        string choose;

        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        private SqlDataReader sqlDataReader;

        private GoogleMap googleMapForm;

        public HelpQueryForm(string choose, string id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this.choose = choose;

            textBoxId.Text = id;

            dataGridViewIdData.Columns["goods_image"].DefaultCellStyle.NullValue = null;
            dataGridViewIdData.Columns["id_supply"].Visible = false;

            // Вимкнення рисок між комірками
            dataGridViewIdData.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Встановлення стилю рисок для рядків
            dataGridViewIdData.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewIdData.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewIdData.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewIdData.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            //Колір ліній дата грід
            dataGridViewIdData.GridColor = Color.FromArgb(29, 29, 37);

            if (choose == "Add")
            {
                this.Size = new Size(707, 476);

                iconButtonAdd.Visible = true;
                iconButtonCorrect.Visible = false;
                iconButtonDelete.Visible = false;
                iconButtonHandle.Visible = false;
                iconButtonCancelHandle.Visible = false;

                panelDataGrid.Visible = false;
                panelDataGridUpdate.Visible = false;
            }
            else if(choose == "Correct")
            {
                this.Size = new Size(707, 600);

                dataGridViewIdData.Columns["vol_nameOfOrgan"].Visible = false;
                dataGridViewIdData.Columns["datetime_accept"].Visible = false;
                dataGridViewIdData.Columns["is_success"].Visible = false;

                iconButtonAdd.Visible = false;
                iconButtonCorrect.Visible = true;
                iconButtonDelete.Visible = false;
                iconButtonHandle.Visible = false;
                iconButtonCancelHandle.Visible = false;
            }
            else if (choose == "Delete")
            {
                this.Size = new Size(707, 222);

                dataGridViewIdData.Columns["vol_nameOfOrgan"].Visible = false;
                dataGridViewIdData.Columns["datetime_accept"].Visible = false;
                dataGridViewIdData.Columns["is_success"].Visible = false;

                iconButtonAdd.Visible = false;
                iconButtonCorrect.Visible = false;
                iconButtonDelete.Visible = true;
                iconButtonHandle.Visible = false;
                iconButtonCancelHandle.Visible = false;

                panelAddEdit.Visible = false;

            }
            else if (choose == "Handle")
            {
                this.Size = new Size(707, 222);

                dataGridViewIdData.Columns["datetime_accept"].Visible = false;
                dataGridViewIdData.Columns["is_success"].Visible = false;

                iconButtonHandle.Visible = true;
                iconButtonDelete.Visible = true;
                iconButtonAdd.Visible = false;
                iconButtonCorrect.Visible = false;
                iconButtonCancelHandle.Visible = false;

                panelAddEdit.Visible = false;
            }
            else if (choose == "CancelHandle")
            {
                this.Size = new Size(707, 222);

                dataGridViewIdData.Columns["datetime_accept"].Visible = false;
                dataGridViewIdData.Columns["is_success"].Visible = false;

                iconButtonCancelHandle.Visible = true;
                iconButtonDelete.Visible = false;
                iconButtonHandle.Visible = false;
                iconButtonAdd.Visible = false;
                iconButtonCorrect.Visible = false;

                panelAddEdit.Visible = false;
            }
        }

        private void HelpQueryForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);

            if (choose != "Add")
            {
                if (!string.IsNullOrEmpty(textBoxId.Text))
                {
                    LoadIdData(int.Parse(textBoxId.Text));
                    //iconButtonResreshIdData.PerformClick();
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Оберіть рядок над яким потрібно виконати дію!", "Рядок не обрано", "Warning");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
            }

            if (choose == "Correct")
            {
                bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "mil_nameOfOrgan");
                bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));

                if (!equal)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ви не можете редагувати запити, які створили інші учасники!", "Оберіть інший Id товару", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
                else if (!empty)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Запит вже обробляється, його неможливо редагувати!", "Запит вже обробляється", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return ;
                }
            }
            else if (choose == "Delete")
            {
                bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "mil_nameOfOrgan");
                bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));
                
                if (!equal)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ви не можете видалити запити, які створили інші учасники!", "Оберіть інший Id товару", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
                else if (!empty)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Запит вже обробляється, його неможливо видалити!", "Запит вже обробляється", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
            }
            else if (choose == "Handle")
            {
                bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));

                if (!empty)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ця обробка запиту вже зайнятий!", "Зайнято!", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
            }
            else if (choose == "CancelHandle")
            {
                bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "vol_nameOfOrgan");
                bool isShipped = IsShipped(int.Parse(textBoxId.Text));

                if (!equal)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Не можна відмінити чужий або не обраний запит на обробку!", "Не свій запит на обробку", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }

                if(isShipped)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Не можна відмінити запит, який вже відправлений!", "Вже відправлений", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                    return;
                }
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonClose.PerformClick();
            }
        }

        private void buttonMinimize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                buttonMinimize.PerformClick();
            }
        }


        private void panelUpper_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void panelUpper_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panelUpper_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Ви справді хочете скасувати дію?", "Закрити вкладку?", "QuestionClosePage");
            customMessageBox.ShowDialog();

            if (customMessageBox.CheckReturn())
            {
                buttonClose.PerformClick();
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "mil_nameOfOrgan");
            bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));

            if (equal && empty)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Увага, ці дані будуть видалені назавжди. Видалити?", "Видалити дані?", "QuestionDelete");
                customMessageBox.ShowDialog();

                if (customMessageBox.CheckReturn())
                {
                    dataBaseConnection.openDatabase();

                    string deleteQuery = $"DELETE FROM Supply WHERE id_supply = {textBoxId.Text}";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, dataBaseConnection.getConnection());
                    deleteCommand.ExecuteNonQuery();

                    UpdateId_supplyAfterDelete();

                    dataBaseConnection.closeDatabase();

                    customMessageBox = new CustomMessageBox("Запит був успішно видалений!", "Успішно", "Success");
                    customMessageBox.ShowDialog();

                    this.Close();
                }
            }
            else if (!equal)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Ви не можете видалити запити, які створили інші учасники!", "Оберіть інший Id товару", "Error");
                customMessageBox.ShowDialog();
            }
            else if (!empty)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Запит вже обробляється, його неможливо видалити!", "Запит вже обробляється", "Error");
                customMessageBox.ShowDialog();
            }
        }

        private void iconButtonCorrect_Click(object sender, EventArgs e)
        {
            if(!IsCorrectFillCorrect())
            {
                return;
            }
            else
            {
                bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "mil_nameOfOrgan");
                bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));

                if (equal && empty)
                {
                    CorrectFunction();
                }
                else if (!equal)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ви не можете редагувати запити, які створили інші учасники!", "Оберіть інший Id товару", "Error");
                    customMessageBox.ShowDialog();
                }
                else if (!empty)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Запит вже обробляється, його неможливо редагувати!", "Запит вже обробляється", "Error");
                    customMessageBox.ShowDialog();
                }
            }
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {

            if(!IsAddFillCorrect())
            {
                return;
            }
            else
            {
                int id = NextIdNumber();

                string query = $"INSERT INTO Supply (id_supply, name_of_goods, name_of_company, number_of_goods, delivery_location, mil_nameOfOrgan, datetime_add, category, goods_image) VALUES (@Id, @NameOfGoods, @Firm, @Number, @Location, @MilNameOfOrgan, @DataTime, @Category, @PathImage)";

                SqlCommand command = new SqlCommand(query, dataBaseConnection.getConnection());

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NameOfGoods", textBoxNameOfGoods.Text);
                command.Parameters.AddWithValue("@Firm", textBoxFirm.Text);
                command.Parameters.AddWithValue("@Number", textBoxNumber.Text);
                command.Parameters.AddWithValue("@Location", textBoxLocation.Text);
                command.Parameters.AddWithValue("@MilNameOfOrgan", DataStorage.nameOfOrgan);
                command.Parameters.AddWithValue("@DataTime", DateTime.Now);
                command.Parameters.AddWithValue("@Category", ComboBoxCategory.Text);

                if (pictureBoxGoodImage.Image == null)
                {
                    command.Parameters.AddWithValue("@PathImage", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PathImage", openFileDialog1.FileName);
                }

                dataBaseConnection.openDatabase();

                command.ExecuteNonQuery();

                dataBaseConnection.closeDatabase();

                textBoxNameOfGoods.Clear();
                textBoxFirm.Clear();
                textBoxNumber.Clear();
                textBoxLocation.Clear();

                CustomMessageBox customMessageBox = new CustomMessageBox("Запит був успішно дабавлений!", "Успішно", "Success");
                customMessageBox.ShowDialog();

                this.Close();
            }
        }

        private void iconButtonHandle_Click(object sender, EventArgs e)
        {
            bool empty = IsSupplyEmpty(int.Parse(textBoxId.Text));

            if(empty)
            {
                string query = $"UPDATE Supply SET vol_nameOfOrgan = @Volunteer, datetime_accept = @DataAccept, is_success = @Status WHERE id_supply = @Id";
                SqlCommand command = new SqlCommand(query, dataBaseConnection.getConnection());

                command.Parameters.AddWithValue("@Volunteer", DataStorage.nameOfOrgan);
                command.Parameters.AddWithValue("@DataAccept", DateTime.Now);
                command.Parameters.AddWithValue("@Status", "Збирається");
                command.Parameters.AddWithValue("@Id", textBoxId.Text);

                dataBaseConnection.openDatabase();

                command.ExecuteNonQuery();

                dataBaseConnection.closeDatabase();

                CustomMessageBox customMessageBox = new CustomMessageBox("Запит був успішно зайнятий!", "Успішно", "Success");
                customMessageBox.ShowDialog();

                this.Close();
            }
            else
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Ця обробка запиту вже зайнятий!", "Зайнято!", "Error");
                customMessageBox.ShowDialog();
            }
        }

        private void iconButtonCancelHandle_Click(object sender, EventArgs e)
        {
            bool equal = IsOrganEqualDataGridOrgan(int.Parse(textBoxId.Text), "vol_nameOfOrgan");
            bool isShipped = IsShipped(int.Parse(textBoxId.Text));

            if (equal)
            {
                if(!isShipped)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ви справді хочете відмінити обробку запиту?", "Відмінити обробку запиту?", "QuestionHandleCancel");
                    customMessageBox.ShowDialog();
                    if (customMessageBox.CheckReturn())
                    {
                        string query = $"UPDATE Supply SET vol_nameOfOrgan = @Volunteer, datetime_accept = @DataAccept, is_success = @Status WHERE id_supply = @Id";

                        SqlCommand command = new SqlCommand(query, dataBaseConnection.getConnection());

                        command.Parameters.AddWithValue("@Volunteer", DBNull.Value);
                        command.Parameters.AddWithValue("@DataAccept", DBNull.Value);
                        command.Parameters.AddWithValue("@Status", DBNull.Value);
                        command.Parameters.AddWithValue("@Id", textBoxId.Text);

                        dataBaseConnection.openDatabase();

                        command.ExecuteNonQuery();

                        dataBaseConnection.closeDatabase();

                        customMessageBox = new CustomMessageBox("Запит був успішно відміненено!", "Успішно", "Success");
                        customMessageBox.ShowDialog();

                        this.Close();
                    }
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Не можна відмінити запит, який вже відправлений!", "Вже відправлений", "Error");
                    customMessageBox.ShowDialog();
                }
            }
            else
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Не можна відмінити чужий або не обраний запит на обробку!", "Не свій запит на обробку", "Error");
                customMessageBox.ShowDialog();
            }
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

        private void iconButtonLoadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select Image(*.Jpg; *.png; *Gif) |*.Jpg; *.png; *Gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGoodImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private int NextIdNumber()
        {
            int newId;

            dataBaseConnection.openDatabase();

            string getMaxIdQuery = "SELECT MAX(id_supply) FROM Supply";
            using (SqlCommand command = new SqlCommand(getMaxIdQuery, dataBaseConnection.getConnection()))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    int lastId = Convert.ToInt32(result);
                    newId = lastId + 1;
                }
                else
                {
                    // Якщо таблиця порожня, початкове значення ідентифікатора може бути 1
                    newId = 1;
                }
            }

            dataBaseConnection.closeDatabase();

            return newId;
        }

        private void LoadIdData(int id)
        {
            dataGridViewIdData.Rows.Clear();

            dataBaseConnection.openDatabase();

            // Вибірка даних з таблиці Supply
            SqlCommand command = new SqlCommand($"SELECT * FROM Supply WHERE id_supply = {id}", dataBaseConnection.getConnection());

            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridViewIdData.Rows.Add(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(),
                    sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString(), sqlDataReader[7].ToString(),
                    sqlDataReader[8].ToString(), sqlDataReader[9].ToString(), sqlDataReader[10].ToString());
            }
            sqlDataReader.Close();

            LoadImageData(id);

            dataBaseConnection.closeDatabase();

            dataGridViewIdData.ClearSelection();
        }

        private void iconButtonResreshIdData_Click(object sender, EventArgs e)
        {
            LoadIdData(int.Parse(textBoxId.Text));
        }

        private void LoadImageData(int id)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Supply WHERE id_supply = {id}", dataBaseConnection.getConnection());

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
                        dataGridViewIdData.Rows[i].Cells["goods_image"].Value = image;
                    }
                    
                }

                i++;
            }
            reader.Close();
        }

        private void CorrectFunction()
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Ви справді хочете відредагувати дані?", "Редагувати?", "QuestionEdit");
            customMessageBox.ShowDialog();
            if (customMessageBox.CheckReturn())
            {
                dataBaseConnection.openDatabase();

                string updateQuery = @"UPDATE Supply 
                                   SET ";

                // Додаємо поля, які не є пустими до SQL-запиту
                if (ComboBoxCategory.Text != "")
                    updateQuery += "category = @Category, ";

                if (textBoxNameOfGoods.Text != "")
                    updateQuery += "name_of_goods = @NameOfGoods, ";

                if (textBoxFirm.Text != "")
                    updateQuery += "name_of_company = @NameOfCompany, ";

                if (textBoxNumber.Text != "")
                    updateQuery += "number_of_goods = @NumberOfGoods, ";

                if (textBoxLocation.Text != "")
                    updateQuery += "delivery_location = @DeliveryLocation, ";

                updateQuery += "datetime_add = @DatetimeAdd, "; // Дату завжди оновлюємо

                if (pictureBoxGoodImage.Image != null)
                    updateQuery += "goods_image = @GoodsImage, ";

                updateQuery = updateQuery.TrimEnd(',', ' ');

                // Додаємо умову WHERE
                updateQuery += " WHERE id_supply = @SupplyID";

                SqlCommand command = new SqlCommand(updateQuery, dataBaseConnection.getConnection());


                if (ComboBoxCategory.Text != "")
                    command.Parameters.AddWithValue("@Category", ComboBoxCategory.Text);


                if (textBoxNameOfGoods.Text != "")
                    command.Parameters.AddWithValue("@NameOfGoods", textBoxNameOfGoods.Text);


                if (textBoxFirm.Text != "")
                    command.Parameters.AddWithValue("@NameOfCompany", textBoxFirm.Text);


                if (textBoxNumber.Text != "")
                    command.Parameters.AddWithValue("@NumberOfGoods", textBoxNumber.Text);


                if (textBoxLocation.Text != "")
                    command.Parameters.AddWithValue("@DeliveryLocation", textBoxLocation.Text);


                command.Parameters.AddWithValue("@DatetimeAdd", DateTime.Now);


                if (pictureBoxGoodImage.Image != null)
                    command.Parameters.AddWithValue("@GoodsImage", openFileDialog1.FileName);

                command.Parameters.AddWithValue("@SupplyID", textBoxId.Text);

                command.ExecuteNonQuery();

                dataBaseConnection.closeDatabase();

                customMessageBox = new CustomMessageBox("Запит було успішно відредаговано!", "Успішно", "Success");
                customMessageBox.ShowDialog();

                this.Close();
            }
        }

        private bool IsOrganEqualDataGridOrgan(int Id, string column)
        {
            string selectQuery = null;

            if (column == "mil_nameOfOrgan")
            {
                selectQuery = $"SELECT mil_nameOfOrgan FROM Supply WHERE id_supply = @SupplyID";
            }
            else if (column == "vol_nameOfOrgan")
            {
                selectQuery = $"SELECT vol_nameOfOrgan FROM Supply WHERE id_supply = @SupplyID";
            }

            SqlCommand command = new SqlCommand(selectQuery, dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@SupplyID", Id);

            dataBaseConnection.openDatabase();
            object result = command.ExecuteScalar();
            dataBaseConnection.closeDatabase();

            if(DataStorage.nameOfOrgan == result.ToString())
            {
                return true;
            }
            return false;
        }

        private bool IsShipped(int Id)
        {
            string selectQuery = $"SELECT CASE WHEN is_success = 'Відправлено' THEN 1 ELSE 0 END FROM Supply WHERE id_supply = @SupplyID";
            SqlCommand command = new SqlCommand(selectQuery, dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@SupplyID", Id);

            dataBaseConnection.openDatabase();
            int result = (int)command.ExecuteScalar(); // Використовуйте int замість object
            dataBaseConnection.closeDatabase();
            return result == 1;
        }

        private bool IsSupplyEmpty(int Id)
        {
            string selectQuery = $"SELECT vol_nameOfOrgan FROM Supply WHERE id_supply = @SupplyID";
            SqlCommand command = new SqlCommand(selectQuery, dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@SupplyID", Id);

            dataBaseConnection.openDatabase();
            object result = command.ExecuteScalar();
            dataBaseConnection.closeDatabase();

            if (result.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool IsAddFillCorrect()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
                string.IsNullOrWhiteSpace(ComboBoxCategory.Text) ||
                string.IsNullOrWhiteSpace(textBoxNameOfGoods.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirm.Text) ||
                string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Будь ласка, заповність усі рядки! (Фото за бажанням)", "Не всі дані заповнено", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (!Regex.IsMatch(textBoxNumber.Text, @"^\d+$"))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("У полі \"Кількість товару\" мають бути тільки цифри!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxNumber.Text) || !int.TryParse(textBoxNumber.Text, out int number) || number < 0 || number > 2147483647)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("\"Кількість товару\" містить занадто велике значення!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if ((!Regex.IsMatch(textBoxNameOfGoods.Text, @"^.{3,50}$") && !string.IsNullOrWhiteSpace(textBoxNameOfGoods.Text)) ||
                    (!Regex.IsMatch(textBoxFirm.Text, @"^.{3,50}$") && !string.IsNullOrWhiteSpace(textBoxFirm.Text)))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Рядки \"Назва товару\" і \"Виробник\" мають складатись не менше ніж із 3 символів і не більше ніж із 50 символів!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (!Regex.IsMatch(textBoxLocation.Text, @"^[\s\S]{10,100}$") && !string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Рядок \"Місце доставки\" має складатись не менше ніж із 10 і не більше ніж із 100 символів!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }

            return true;
        }

        private void textBoxLocation_Click(object sender, EventArgs e)
        {
            if(textBoxLocation.Text != "")
            {
                return;
            }

            CustomMessageBox customMessageBox = new CustomMessageBox("Чи бажаєте відкрити карту?", "Карта", "Question");
            customMessageBox.ShowDialog();

            if (customMessageBox.CheckReturn())
            {
                googleMapForm = new GoogleMap("None", true);
                googleMapForm.ShowDialog(); 

                if (googleMapForm.ReturnLocation() != "Натисність, щоб відобразити скопійовану локацію")
                {
                    textBoxLocation.Text = googleMapForm.ReturnLocation();
                }
            }
        }

        private void dataGridViewIdData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(DataStorage.TypeOfAccount == "Volunteers")
            {
                string value = dataGridViewIdData.Rows[e.RowIndex].Cells["is_success"].Value.ToString();

                if(value != "")
                {
                    dataGridViewIdData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(43, 42, 33);

                }
            }
        }

        private bool IsCorrectFillCorrect()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text) &&
               string.IsNullOrWhiteSpace(ComboBoxCategory.Text) &&
               string.IsNullOrWhiteSpace(textBoxNameOfGoods.Text) &&
               string.IsNullOrWhiteSpace(textBoxFirm.Text) &&
               string.IsNullOrWhiteSpace(textBoxLocation.Text)&&
               pictureBoxGoodImage.Image == null)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Ви ніяк не змінили дані запиту!", "Всі поля пусті", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(textBoxNumber.Text) && !Regex.IsMatch(textBoxNumber.Text, @"^\d+$"))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("У полі \"Кількість товару\" мають бути тільки цифри!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if(!string.IsNullOrWhiteSpace(textBoxNumber.Text) && (!int.TryParse(textBoxNumber.Text, out int number) || number < 0 || number > 2147483647))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("\"Кількість товару\" містить занадто велике значення!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if ((!Regex.IsMatch(textBoxNameOfGoods.Text, @"^.{3,50}$") && !string.IsNullOrWhiteSpace(textBoxNameOfGoods.Text)) ||
                    (!Regex.IsMatch(textBoxFirm.Text, @"^.{3,50}$") && !string.IsNullOrWhiteSpace(textBoxFirm.Text)))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Рядки \"Назва товару\" і \"Виробник\" мають складатись не менше ніж із 3 символів і не більше ніж із 50 символів!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            else if (!Regex.IsMatch(textBoxLocation.Text, @"^[\s\S]{10,100}$") && !string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Рядок \"Місце доставки\" має складатись не менше ніж із 10 і не більше ніж із 100 символів!", "Некоректний ввід", "Warning");
                customMessageBox.ShowDialog();
                return false;
            }
            return true;
        }
    }
}
