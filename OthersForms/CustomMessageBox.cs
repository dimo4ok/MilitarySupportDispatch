using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch.OthersForms
{
    public partial class CustomMessageBox : Form
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
        
        private bool check; // // Перевірка, чи потрібно виконувати дію

        public CustomMessageBox(string mainText, string title, string aim)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            labelTitle.Text = title;
            labelMainText.Text = mainText;

            if(aim == "Warning")
            {
                pictureWarning.Visible = true;

                buttonOk.Visible = true;
            }
            else if(aim == "Success")
            {
                pictureBoxSuccess.Visible = true;

                buttonOk.Visible = true;
            }
            else if(aim == "WarningAnswer")
            {
                pictureBoxWarningAnswer.Visible = true;

                buttonYes.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "WarningAnswer2")
            {
                pictureBoxWarningAnswer.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "QuestionClosePage")
            {
                pictureBoxHelpQueryClose.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "QuestionDelete")
            {
                pictureBoxHelpQueryDelete.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "QuestionEdit")
            {
                pictureBoxHelpQueryEdit.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "QuestionHandleCancel")
            {
                pictureBoxHelpQueyHandleCancel.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if(aim =="Error")
            {
                pictureBoxError.Visible = true;

                buttonOk.Visible = true;
            }
            else if(aim =="Question")
            {
                pictureBoxQuestion.Visible = true;
                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }
            else if (aim == "QuestionConfirmRecieve")
            {
                pictureBoxDelivered.Visible = true;

                buttonYes2.Visible = true;
                buttonNo.Visible = true;
            }

            SystemSounds.Asterisk.Play();
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonClose.PerformClick();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYes2_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }

        private void buttonClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonClose.PerformClick();
            }
        }

        public bool CheckReturn() // Перевірка, чи потрібно виконувати дію
        {
            return check;
        }
    }
}
