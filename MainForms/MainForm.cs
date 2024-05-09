using FontAwesome.Sharp;
using MilitarySupportDispatch.MainFormElements;
using MilitarySupportDispatch.MainForms.ElementsMainForms;
using MilitarySupportDispatch.MainForms.VolunteerFormsElements;
using MilitarySupportDispatch.OthersForms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MilitarySupportDispatch.Forms
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;

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
        public MainForm()
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height); // view task bar when maximized

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelLeft.Controls.Add(leftBorderButton);

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
            if(senderButton != null)
            {
                DisableButon();
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

        private void DisableButon()
        {
            if(currentButton != null) 
            {
                currentButton.BackColor = Color.FromArgb(32, 33, 36);
                currentButton.ForeColor = Color.FromArgb(220, 220, 219);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;

                currentButton.IconColor = Color.FromArgb(220, 220, 219); 
                currentButton.TextImageRelation = TextImageRelation.Overlay;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButon();
            leftBorderButton.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new MenuForm());
        }
        private void iconButtonSupplier_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new QueryForm());
        }

        private void iconButtonStatus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new StatusForm());

        }

        private void iconButtonMil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new MilitaryListForm());
        }

        private void iconButtonVol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new VolunteersListForm());
        }

        private void iconButtonSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new PropertiesForm());
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            CustomMessageBox customMessageBox = new CustomMessageBox("Увага, всі НЕ збережені дані будуть втрачені. Ви справді хочете вийти з акаунту? ", "Вийти з акаунту?", "WarningAnswer2");
            customMessageBox.ShowDialog();

            if (customMessageBox.CheckReturn())
            {
                this.Close();
            }
            Reset();
        }

        private void pictureMainPage_Click(object sender, EventArgs e)
        {
            Reset();
            if(currentChildForm !=null)
            {
                currentChildForm.Close();
            }
        }

        private void VolunteerForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // for keyboard = press button
            this.KeyDown += new KeyEventHandler(buttonClose_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMinimize_KeyDown);

            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
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

        private void panelUpper_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void panelUpper_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            iconButtonExit.PerformClick();
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
            CustomMessageBox customMessageBox = new CustomMessageBox("Увага, всі НЕ збережені дані будуть втрачені. Ви справді хочете закрити додаток? ", "Закрити додаток?", "WarningAnswer");
            customMessageBox.ShowDialog();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonMaximized_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
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

        private void buttonTools_Click(object sender, EventArgs e)
        {
            iconButtonSetting.PerformClick();
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            iconButtonStatus.PerformClick();
        }

        private void buttonMinimize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                buttonMinimize.PerformClick();
            }
        }
    }
}
