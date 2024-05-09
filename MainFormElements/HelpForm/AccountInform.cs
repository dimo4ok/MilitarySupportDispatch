using MilitarySupportDispatch.ClassesData;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch.MainFormElements.HelpForm
{
    public partial class AccountInform : Form
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

        public AccountInform(string table, string nameOrgan)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (table == "Military")
            {
                TableName = "Military";
                TableNameId = "mil_id";
                TableNameOrgan = "mil_nameOfOrgan";
                TableNameShowInform = "mil_showInform";

                infromTableName = "InformMil";
                infromTableNameId = "id_military";
                informTableNameFirstName = "mil_firstName";
                infromTableNameLastName = "mil_lastName";
                infromTableNameNumber = "mil_number";
                infromTableNamePost = "mil_post";
            }
            else if (table == "Volunteers")
            {
                TableName = "Volunteers";
                TableNameId = "vol_id";
                TableNameOrgan = "vol_nameOfOrgan";
                TableNameShowInform = "vol_showInform";


                infromTableName = "InformVol";
                infromTableNameId = "id_volunter";
                informTableNameFirstName = "vol_firstName";
                infromTableNameLastName = "vol_lastName";
                infromTableNameNumber = "vol_number";
                infromTableNamePost = "vol_post";
            }

            textBoxNameOrgan.Text = nameOrgan;
            int id = GetId(nameOrgan);

            if (id != 0)
            {
                FillInfrom(nameOrgan, id);
            }
        }

        private void AccountInform_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);
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

        private void buttonClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonClose.PerformClick();
            }
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

        private int GetId(string nameOrgan)
        {
            SqlCommand command = new SqlCommand($"SELECT ({TableNameId}) FROM {TableName} WHERE {TableNameOrgan} = @NameOrgan AND {TableNameShowInform} = 1", dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@NameOrgan", nameOrgan);

            dataBaseConnection.openDatabase();
            object id = command.ExecuteScalar();
            dataBaseConnection.closeDatabase();

            return Convert.ToInt32(id);
        }

        private void FillInfrom(string nameOrganm, int Id)
        {
            dataBaseConnection.openDatabase();

            SqlCommand command = new SqlCommand($"SELECT * FROM {infromTableName} WHERE {infromTableNameId} = @Id", dataBaseConnection.getConnection());
            command.Parameters.AddWithValue("@Id", Id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBoxPersonName.Text = reader[informTableNameFirstName].ToString();
                textBoxPersonLastName.Text = reader[infromTableNameLastName].ToString();
                textBoxNumberTel.Text = reader[infromTableNameNumber].ToString();
                textBoxPost.Text = reader[infromTableNamePost].ToString();
            }
        }
    }
}
