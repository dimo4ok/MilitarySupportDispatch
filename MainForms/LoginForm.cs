using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.ClassesSqlQuery;
using MilitarySupportDispatch.Forms;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch
{
    public partial class LoginForm : Form
    {
        DataStorage dataStorage;

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

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SoldierPictureBox.Hide();
            VolunteersPictureBox.Hide();

            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(SigninButton_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonClear_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (PasswordTextBox.Text == "Пароль")
            {
                PasswordTextBox.Clear();
            }
        }
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Пароль";
            }
        }

        private void NameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (NameTextBox.Text == "Назва організації")
            {
                NameTextBox.Clear();
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Назва організації";
            }
        }

        private void TypeOfAccountComboBox_Leave(object sender, EventArgs e)
        {
            if(TypeOfAccountComboBox.Text != "Військовий" && TypeOfAccountComboBox.Text != "Волонтер" && TypeOfAccountComboBox.Text !=  "Вид організації")
            {
                TypeOfAccountComboBox.Text = "Вид організації";
                VolunteersPictureBox.Hide();
                SoldierPictureBox.Hide();
                NonePictureBox.Show();
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void TypeOfAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NonePictureBox.Hide();

            if (TypeOfAccountComboBox.SelectedItem == "Військовий")
            {
                VolunteersPictureBox.Hide();
                SoldierPictureBox.Show();
            }
            else
            {
                SoldierPictureBox.Hide();
                VolunteersPictureBox.Show();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            CommentForm comment1Form = new CommentForm();
            comment1Form.ShowDialog();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            if (TypeOfAccountComboBox.Text == "Вид організації")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Будь ласка, оберіть вид організації!", "Користувача не обрано", "Warning");
                customMessageBox.ShowDialog();
                return;
            }

            if(NameTextBox.Text == "Назва організації" || PasswordTextBox.Text == "Пароль")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Будь ласка, вкажіть назву організації і пароль!", "Дані не введено", "Warning");
                customMessageBox.ShowDialog();
                return;
            }

            string selectedValue = TypeOfAccountComboBox.SelectedItem.ToString();

            if (selectedValue == "Військовий")
            {
                CheckAutorization check = new CheckAutorization(NameTextBox.Text, PasswordTextBox.Text, "Military", "mil_nameOfOrgan", "mil_password");
                if (check.CheckAutorizationFunc())
                {
                    dataStorage = new DataStorage("Military", NameTextBox.Text);

                    MainForm militaryForm = new MainForm();

                    PasswordTextBox.Clear();

                    this.Hide();
                    militaryForm.ShowDialog();
                    this.Show();
                }
                else
                {

                    CustomMessageBox customMessageBox = new CustomMessageBox("Неправильний логін або пароль!", "Такого акаунту не існує!", "Warning");
                    customMessageBox.ShowDialog();
                    PasswordTextBox.Clear();
                }
            }
            else if (selectedValue == "Волонтер")
            {
                CheckAutorization check = new CheckAutorization(NameTextBox.Text, PasswordTextBox.Text, "Volunteers", "vol_nameOfOrgan", "vol_password");
                if (check.CheckAutorizationFunc())
                {
                    dataStorage = new DataStorage("Volunteers", NameTextBox.Text);

                    MainForm volunteerForm = new MainForm();

                    PasswordTextBox.Clear();

                    this.Hide();
                    volunteerForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Неправильний логін або пароль!", "Такого акаунту не існує!", "Warning");
                    customMessageBox.ShowDialog();
                    PasswordTextBox.Clear();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TypeOfAccountComboBox.Text = "Вид організації";
            NameTextBox.Text = "Назва організації";
            PasswordTextBox.Text = "Пароль";

            NonePictureBox.Show();
            VolunteersPictureBox.Hide();
            SoldierPictureBox.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonClear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonClear.PerformClick();
            }
        }

        private void SigninButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SigninButton.PerformClick();
            }
        }

        private void RegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();

            TypeOfAccountComboBox.Text = "Вид організації";
            NameTextBox.Text = "Назва організації";
            PasswordTextBox.Text = "Пароль";

            NonePictureBox.Show();
            VolunteersPictureBox.Hide();
            SoldierPictureBox.Hide();


            this.Hide();
            registrationForm.ShowDialog();
            this.Show();
        }
    }
}
