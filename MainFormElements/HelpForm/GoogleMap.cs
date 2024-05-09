using CefSharp;
using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    public partial class GoogleMap : Form
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

        string idDelivaryLocation;

        private string table;

        public GoogleMap(string idDelivaryLocation, bool IsTextBoxVisible = false, string table = "Supply")
        {
            InitializeComponent();

            this.table = table;

            if(IsTextBoxVisible)
            {
                panelTextBoxLocation.Visible = true;
            }

            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height); // view task bar when maximized
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.idDelivaryLocation = idDelivaryLocation;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chromiumWebBrowser1_LoadError(object sender, CefSharp.LoadErrorEventArgs e)
        {
            chromiumWebBrowserMap.Stop();
            CustomMessageBox customMessageBox = new CustomMessageBox("Карта не завантажується! Оновіть браузер, переірте підключення інтернету або ж введіть дані без карти!", "Помилка завантаження!", "Warning");
            customMessageBox.ShowDialog();
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void buttonMinimize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                buttonMinimize.PerformClick();
            }
        }

        private void GoogleMap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);

            string url;

            if (idDelivaryLocation == "None")
            {
                url = "https://www.google.com/maps/";
            }
            else
            {
                string deliveryLocation = LoadSupplyDeliveryLocation(table);
                url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(deliveryLocation);
            }

            chromiumWebBrowserMap.Load(url);

        }

        private void buttonMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Region = null;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

        private void textBoxLocation_Click(object sender, EventArgs e)
        {
            if (textBoxLocation.Text == "Натисність, щоб відобразити скопійовану локацію")
            {
                textBoxLocation.Text = "";
            }

            if(textBoxLocation.Text == "")
            {
                string clipboardText = Clipboard.GetText();
                // Оновлення тексту у текстовому полі
                textBoxLocation.Text = clipboardText;
            }
        }

        private void textBoxLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                textBoxLocation.Text = "Натисність, щоб відобразити скопійовану локацію";
            }
        }

        private string LoadSupplyDeliveryLocation(string table)
        {
            dataBaseConnection.openDatabase();

            string deliveryLocation = "Ukraine";

            SqlCommand command = new SqlCommand($"SELECT delivery_location FROM {table} WHERE id_supply = {idDelivaryLocation}", dataBaseConnection.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            if (!reader.IsDBNull(0))
            {
                deliveryLocation = reader.GetString(0);

                dataBaseConnection.closeDatabase();
            }

            return deliveryLocation;
        }

        public string ReturnLocation()
        {
            return textBoxLocation.Text;
        }
    }
}
