using MilitarySupportDispatch.ClassesData;
using MilitarySupportDispatch.ClassesSqlQuery;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MilitarySupportDispatch.Forms
{
    public partial class RegistrationForm : Form
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

        public RegistrationForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //comboBoxTypeOfAccount.Select();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            SoldierPictureBox.Hide();
            VolunteersPictureBox.Hide();

            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonCreate_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonClear_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonBack_KeyDown);
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Перевірка вводу обов'язкових полів
        private void comboBoxTypeOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            NonePictureBox.Hide();

            if (comboBoxTypeOfAccount.SelectedItem == "Військовий")
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
        private void comboBoxTypeOfAccount_Leave(object sender, EventArgs e)
        {
            if (comboBoxTypeOfAccount.Text != "Військовий" && comboBoxTypeOfAccount.Text != "Волонтер" && comboBoxTypeOfAccount.Text != "Вид організації")
            {
                comboBoxTypeOfAccount.Text = "Вид організації";
                VolunteersPictureBox.Hide();
                SoldierPictureBox.Hide();
                NonePictureBox.Show();
            }
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxName.Text == "Назва організації")
            {
                textBoxName.Clear();
            }
        }
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Назва організації";
            }
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Clear();
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Пароль";
            }
        }

        private void textBoxPasswordAgain_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPasswordAgain.Text == "Повторний пароль")
            {
                textBoxPasswordAgain.Clear();
            }
        }
        private void textBoxPasswordAgain_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordAgain.Text == "")
            {
                textBoxPasswordAgain.Text = "Повторний пароль";
            }
        }

        //Перевірка вводу НЕ обов'язкових полів
        private void textBoxPersonName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPersonName.Text == "Ім'я")
            {
                textBoxPersonName.Clear();
            }
        }
        private void textBoxPersonName_Leave(object sender, EventArgs e)
        {
            if (textBoxPersonName.Text == "")
            {
                textBoxPersonName.Text = "Ім'я";
            }
        }

        private void textBoxPersonLastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPersonLastName.Text == "Прізвище")
            {
                textBoxPersonLastName.Clear();
            }
        }
        private void textBoxPersonLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxPersonLastName.Text == "")
            {
                textBoxPersonLastName.Text = "Прізвище";
            }
        }

        private void textBoxNumberTel_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNumberTel.Text == "Номер телефону")
            {
                textBoxNumberTel.Clear();
            }
        }
        private void textBoxNumberTel_Leave(object sender, EventArgs e)
        {
            if (textBoxNumberTel.Text == "")
            {
                textBoxNumberTel.Text = "Номер телефону";
            }
        }

        private void textBoxPost_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPost.Text == "Пошта")
            {
                textBoxPost.Clear();
            }
        }
        private void textBoxPost_Leave(object sender, EventArgs e)
        {
            if (textBoxPost.Text == "")
            {
                textBoxPost.Text = "Пошта";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxTypeOfAccount.Text = "Вид організації";
            SoldierPictureBox.Hide();
            VolunteersPictureBox.Hide();
            NonePictureBox.Show();

            textBoxName.Text = "Назва організації";
            textBoxPassword.Text = "Пароль";
            textBoxPasswordAgain.Text = "Повторний пароль";

            textBoxPersonName.Text = "Ім'я";
            textBoxPersonLastName.Text = "Прізвище";
            textBoxNumberTel.Text = "Номер телефону";
            textBoxPost.Text = "Пошта";
            
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPasswordAgain.UseSystemPasswordChar = true;
            }
        }

        private void buttonBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonBack.PerformClick();
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

        private void buttonCreate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCreate.PerformClick();
            }
        }

        //Create account
        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if (comboBoxTypeOfAccount.SelectedItem == null || textBoxName.Text == "Назва організації" || textBoxPassword.Text == "Пароль" || textBoxPasswordAgain.Text == "Повторний пароль")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Будь ласка, заповність усі обов'язкові поля!", "Дані", "Warning");
                customMessageBox.ShowDialog();
                return;
            }

            if (!Regex.IsMatch(textBoxName.Text, @"^.{6,25}$"))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Назва організації має містити від 6 до 25 символів", "Некоректний ввід даних", "Warning");
                customMessageBox.ShowDialog();

                textBoxName.Text = "Назва організації";
                return;
            }

            if (!Regex.IsMatch(textBoxPassword.Text, @"^(?=.*[a-zа-я])(?=.*[A-ZА-Я])(?=.*\d|\W).{6,25}$"))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Пароль має містити: великі букви, символи, й складатися від 6 до 25 символів", "Некоректний ввід даних", "Warning");
                customMessageBox.ShowDialog();

                textBoxPassword.Text = "Пароль";
                textBoxPasswordAgain.Text = "Повторний пароль";
                return;
            }
            else if (textBoxPassword.Text == textBoxName.Text)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Пароль має відрізнятись від назви Вашої організації!", "Поганий пароль!", "Warning");
                customMessageBox.ShowDialog();

                textBoxName.Text = "Назва організації";
                textBoxPassword.Text = "Пароль";
                textBoxPasswordAgain.Text = "Повторний пароль";
                return;
            }
            else if (textBoxPassword.Text != textBoxPasswordAgain.Text)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Паролі не співпадають!", "Паролі не співпадають", "Warning");
                customMessageBox.ShowDialog();

                textBoxPasswordAgain.Text = "Повторний пароль";
                return;
            }

            if (!CheckCorrection()) // корректність вводу побічних даних
            {
                return;
            }

            string PersonName = textBoxPersonName.Text;
            string PersonLastName = textBoxPersonLastName.Text;
            string TelNumb = textBoxNumberTel.Text;
            string Post = textBoxPost.Text;

            if (PersonName == "Ім'я")
            {
                PersonName = "Дані відсутні";
            }
            if (PersonLastName == "Прізвище")
            {
                PersonLastName = "Дані відсутні";
            }
            if (TelNumb == "Номер телефону")
            {
                TelNumb = "Дані відсутні";
            }
            if (Post == "Пошта")
            {
                Post = "Дані відсутні";
            }


            if (comboBoxTypeOfAccount.SelectedItem.ToString() == "Військовий")
            {
                RegistrationMain registration = new RegistrationMain(textBoxName.Text, textBoxPassword.Text, "Military", "mil_nameOfOrgan", "mil_password");

                if (registration.CheckNameOfOrgan())
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Організація з таким іменем вже існує!", "Такий акаунт вже є", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxName.Text = "Назва організації";
                    return;
                }
                else
                {
                    RegistrationOtherInform registrationOtherInform = new RegistrationOtherInform("InformMil", "mil_firstName", "mil_lastName", "mil_number", "mil_post",
                        PersonName, PersonLastName, TelNumb, Post);

                    //Тут записуємо новий аккаунт
                    registration.RegistrationTry();
                    registrationOtherInform.FillOtherInform();

                    CustomMessageBox customMessageBox = new CustomMessageBox("Вітаю, ви створили аккаунт військової бригади!", "Аккаунт створено", "Success");
                    customMessageBox.ShowDialog();

                    dataStorage = new DataStorage("Military", textBoxName.Text);

                    MainForm militaryForm = new MainForm();

                    this.Hide();
                    militaryForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                RegistrationMain registration = new RegistrationMain(textBoxName.Text, textBoxPassword.Text, "Volunteers", "vol_nameOfOrgan", "vol_password");

                if (registration.CheckNameOfOrgan())
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Організація з таким іменем вже існує!", "Такий акаунт вже є", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxName.Text = "Назва організації";
                    return;
                }
                else
                {
                    RegistrationOtherInform registrationOtherInform = new RegistrationOtherInform("InformVol", "vol_firstName", "vol_lastName", "vol_number", "vol_post",
                        PersonName, PersonLastName, TelNumb, Post);

                    //Тут записуємо новий аккаунт
                    registration.RegistrationTry();
                    registrationOtherInform.FillOtherInform();

                    CustomMessageBox customMessageBox = new CustomMessageBox("Вітаю, ви створили аккаунт волонтерської організації!", "Аккаунт створено", "Success");
                    customMessageBox.ShowDialog();

                    dataStorage = new DataStorage("Volunteers", textBoxName.Text);

                    MainForm volunteerForm = new MainForm();

                    this.Hide();
                    volunteerForm.ShowDialog();
                    this.Close();
                }
            }

        }


        //Функція коректного вводу побічних даних
        public bool CheckCorrection()
        {
            if (!(textBoxPersonName.Text == "Ім'я"))
            {
                if (!Regex.IsMatch(textBoxPersonName.Text, @"^[A-ZА-ЯЄІЇҐ][a-zа-яєіїґ]{2,24}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Ім'я має починатись з великої літери і склададтись вд 3 до 25 букв!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxPersonName.Text = "Ім'я";
                    return false;
                }
            }

            if (!(textBoxPersonLastName.Text == "Прізвище"))
            {
                if (!Regex.IsMatch(textBoxPersonLastName.Text, @"^[A-ZА-ЯЄІЇҐ][a-zа-яєіїґ]{2,34}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Прізвище має починатись з великої літери і склададтись вд 3 до 35 букв!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxPersonLastName.Text = "Прізвище";
                    return false;

                }
            }

            if (!(textBoxNumberTel.Text == "Номер телефону"))
            {
                if (!Regex.IsMatch(textBoxNumberTel.Text, @"^\+380\d{9}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Телефон має починатись з +380 і містити рівно 9 додаткових цифр!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxNumberTel.Text = "Номер телефону";
                    return false;
                }
            }

            if (!(textBoxPost.Text == "Пошта"))
            {
                if (!Regex.IsMatch(textBoxPost.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,39}$"))
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Некоректна пошта!", "Некоректний ввід даних", "Warning");
                    customMessageBox.ShowDialog();

                    textBoxPost.Text = "Пошта";
                    return false;
                }
            }

            return true;
        }
    }
}
