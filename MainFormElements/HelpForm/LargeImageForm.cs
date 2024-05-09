using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    public partial class LargeImageForm : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

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
        string id;
        private string table;
        public LargeImageForm(string Id, string table = "Supply")
        {
            InitializeComponent();
            this.table = table;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.id = Id;
            this.table = table;
        }

        private void panelUpp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void panelUpp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void panelUpp_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttonClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonClose.PerformClick();
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

        private void buttonMinimize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                buttonMinimize.PerformClick();
            }
        }

        private void LargeImageForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);

            LoadSupplyImage(table);
        }

        private void LoadSupplyImage(string table)
        {
            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand($"SELECT goods_image FROM {table} WHERE id_supply = {id}", dataBaseConnection.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            if (!reader.IsDBNull(0))
            {
                string imagePathFromDatabase = reader.GetString(0);

                if (File.Exists(imagePathFromDatabase))
                {
                    pictureBoxImage.Image = Image.FromFile(imagePathFromDatabase);
                    dataBaseConnection.closeDatabase();
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Фото було видалено!", "Фото не існує", "Error");
                    customMessageBox.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                dataBaseConnection.closeDatabase();

                CustomMessageBox customMessageBox = new CustomMessageBox("Колонка з фото пуста!", "Фото не існує", "Warning");
                customMessageBox.ShowDialog();
                this.Close();
            }

        }
    }
}
