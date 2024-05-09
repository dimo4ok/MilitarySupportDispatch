namespace MilitarySupportDispatch.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonVol = new FontAwesome.Sharp.IconButton();
            this.iconButtonMil = new FontAwesome.Sharp.IconButton();
            this.iconButtonStatus = new FontAwesome.Sharp.IconButton();
            this.iconButtonSupplier = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.panelNone2 = new System.Windows.Forms.Panel();
            this.pictureMainPage = new System.Windows.Forms.PictureBox();
            this.panelNone = new System.Windows.Forms.Panel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.buttonMaximized = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelLowest = new System.Windows.Forms.Panel();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainPage)).BeginInit();
            this.panelUpper.SuspendLayout();
            this.panelLowest.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panelLeft.Controls.Add(this.iconButtonExit);
            this.panelLeft.Controls.Add(this.iconButtonSetting);
            this.panelLeft.Controls.Add(this.iconButtonVol);
            this.panelLeft.Controls.Add(this.iconButtonMil);
            this.panelLeft.Controls.Add(this.iconButtonStatus);
            this.panelLeft.Controls.Add(this.iconButtonSupplier);
            this.panelLeft.Controls.Add(this.iconButtonMenu);
            this.panelLeft.Controls.Add(this.panelNone2);
            this.panelLeft.Controls.Add(this.pictureMainPage);
            this.panelLeft.Controls.Add(this.panelNone);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 840);
            this.panelLeft.TabIndex = 0;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 635);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonExit.Size = new System.Drawing.Size(250, 60);
            this.iconButtonExit.TabIndex = 9;
            this.iconButtonExit.Text = "Вихід";
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButtonSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 575);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonSetting.Size = new System.Drawing.Size(250, 60);
            this.iconButtonSetting.TabIndex = 8;
            this.iconButtonSetting.Text = "Налаштування";
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            this.iconButtonSetting.Click += new System.EventHandler(this.iconButtonSetting_Click);
            // 
            // iconButtonVol
            // 
            this.iconButtonVol.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonVol.FlatAppearance.BorderSize = 0;
            this.iconButtonVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonVol.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonVol.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButtonVol.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonVol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonVol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVol.Location = new System.Drawing.Point(0, 515);
            this.iconButtonVol.Name = "iconButtonVol";
            this.iconButtonVol.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonVol.Size = new System.Drawing.Size(250, 60);
            this.iconButtonVol.TabIndex = 7;
            this.iconButtonVol.Text = "Волонтери";
            this.iconButtonVol.UseVisualStyleBackColor = true;
            this.iconButtonVol.Click += new System.EventHandler(this.iconButtonVol_Click);
            // 
            // iconButtonMil
            // 
            this.iconButtonMil.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonMil.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMil.FlatAppearance.BorderSize = 0;
            this.iconButtonMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMil.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMil.IconChar = FontAwesome.Sharp.IconChar.PersonRifle;
            this.iconButtonMil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMil.Location = new System.Drawing.Point(0, 455);
            this.iconButtonMil.Name = "iconButtonMil";
            this.iconButtonMil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonMil.Size = new System.Drawing.Size(250, 60);
            this.iconButtonMil.TabIndex = 6;
            this.iconButtonMil.Text = "Військові";
            this.iconButtonMil.UseVisualStyleBackColor = true;
            this.iconButtonMil.Click += new System.EventHandler(this.iconButtonMil_Click);
            // 
            // iconButtonStatus
            // 
            this.iconButtonStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonStatus.FlatAppearance.BorderSize = 0;
            this.iconButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStatus.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonStatus.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButtonStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStatus.Location = new System.Drawing.Point(0, 395);
            this.iconButtonStatus.Name = "iconButtonStatus";
            this.iconButtonStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonStatus.Size = new System.Drawing.Size(250, 60);
            this.iconButtonStatus.TabIndex = 5;
            this.iconButtonStatus.Text = "Статус";
            this.iconButtonStatus.UseVisualStyleBackColor = true;
            this.iconButtonStatus.Click += new System.EventHandler(this.iconButtonStatus_Click);
            // 
            // iconButtonSupplier
            // 
            this.iconButtonSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSupplier.FlatAppearance.BorderSize = 0;
            this.iconButtonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSupplier.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonSupplier.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButtonSupplier.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSupplier.Location = new System.Drawing.Point(0, 335);
            this.iconButtonSupplier.Name = "iconButtonSupplier";
            this.iconButtonSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonSupplier.Size = new System.Drawing.Size(250, 60);
            this.iconButtonSupplier.TabIndex = 4;
            this.iconButtonSupplier.Text = "Запити";
            this.iconButtonSupplier.UseVisualStyleBackColor = true;
            this.iconButtonSupplier.Click += new System.EventHandler(this.iconButtonSupplier_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButtonMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 275);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonMenu.Size = new System.Drawing.Size(250, 60);
            this.iconButtonMenu.TabIndex = 3;
            this.iconButtonMenu.Text = "Меню";
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // panelNone2
            // 
            this.panelNone2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNone2.Location = new System.Drawing.Point(0, 237);
            this.panelNone2.Name = "panelNone2";
            this.panelNone2.Size = new System.Drawing.Size(250, 38);
            this.panelNone2.TabIndex = 2;
            // 
            // pictureMainPage
            // 
            this.pictureMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureMainPage.Image = ((System.Drawing.Image)(resources.GetObject("pictureMainPage.Image")));
            this.pictureMainPage.Location = new System.Drawing.Point(0, 19);
            this.pictureMainPage.Name = "pictureMainPage";
            this.pictureMainPage.Size = new System.Drawing.Size(250, 218);
            this.pictureMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMainPage.TabIndex = 1;
            this.pictureMainPage.TabStop = false;
            this.pictureMainPage.Click += new System.EventHandler(this.pictureMainPage_Click);
            // 
            // panelNone
            // 
            this.panelNone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNone.Location = new System.Drawing.Point(0, 0);
            this.panelNone.Name = "panelNone";
            this.panelNone.Size = new System.Drawing.Size(250, 19);
            this.panelNone.TabIndex = 0;
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panelUpper.Controls.Add(this.buttonMaximized);
            this.panelUpper.Controls.Add(this.buttonMinimize);
            this.panelUpper.Controls.Add(this.buttonClose);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(250, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1040, 38);
            this.panelUpper.TabIndex = 1;
            this.panelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseDown);
            this.panelUpper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseMove);
            this.panelUpper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseUp);
            // 
            // buttonMaximized
            // 
            this.buttonMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.buttonMaximized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximized.BackgroundImage")));
            this.buttonMaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximized.FlatAppearance.BorderSize = 0;
            this.buttonMaximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.buttonMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximized.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMaximized.Location = new System.Drawing.Point(962, 10);
            this.buttonMaximized.Name = "buttonMaximized";
            this.buttonMaximized.Size = new System.Drawing.Size(25, 25);
            this.buttonMaximized.TabIndex = 4;
            this.buttonMaximized.UseVisualStyleBackColor = false;
            this.buttonMaximized.Click += new System.EventHandler(this.buttonMaximized_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMinimize.Location = new System.Drawing.Point(921, 10);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonMinimize_KeyDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(1003, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonClose_KeyDown);
            // 
            // panelLowest
            // 
            this.panelLowest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.panelLowest.Controls.Add(this.buttonNotification);
            this.panelLowest.Controls.Add(this.buttonTools);
            this.panelLowest.Controls.Add(this.buttonExit);
            this.panelLowest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLowest.Location = new System.Drawing.Point(250, 802);
            this.panelLowest.Name = "panelLowest";
            this.panelLowest.Size = new System.Drawing.Size(1040, 38);
            this.panelLowest.TabIndex = 2;
            // 
            // buttonNotification
            // 
            this.buttonNotification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.buttonNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNotification.BackgroundImage")));
            this.buttonNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotification.FlatAppearance.BorderSize = 0;
            this.buttonNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotification.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNotification.Location = new System.Drawing.Point(941, 6);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(25, 25);
            this.buttonNotification.TabIndex = 5;
            this.buttonNotification.UseVisualStyleBackColor = false;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // buttonTools
            // 
            this.buttonTools.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.buttonTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTools.BackgroundImage")));
            this.buttonTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTools.FlatAppearance.BorderSize = 0;
            this.buttonTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTools.Location = new System.Drawing.Point(972, 6);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(25, 25);
            this.buttonTools.TabIndex = 4;
            this.buttonTools.UseVisualStyleBackColor = false;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(1003, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1040, 764);
            this.panelMain.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTitle.Controls.Add(this.pictureBoxTitle);
            this.panelTitle.Controls.Add(this.labelTime);
            this.panelTitle.Controls.Add(this.labelDate);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(93, 163);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(873, 265);
            this.panelTitle.TabIndex = 5;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(171, 265);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 5;
            this.pictureBoxTitle.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.labelTime.Location = new System.Drawing.Point(364, 134);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(144, 63);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.labelDate.Location = new System.Drawing.Point(368, 212);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(103, 42);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Squada One", 50.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitle.Location = new System.Drawing.Point(177, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(690, 71);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "MILITARYSUPPORTDISPATCH";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1290, 840);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLowest);
            this.Controls.Add(this.panelUpper);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.VolunteerForm_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainPage)).EndInit();
            this.panelUpper.ResumeLayout(false);
            this.panelLowest.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelLowest;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureMainPage;
        private System.Windows.Forms.Panel panelNone;
        private System.Windows.Forms.Panel panelNone2;
        private FontAwesome.Sharp.IconButton iconButtonStatus;
        private FontAwesome.Sharp.IconButton iconButtonSupplier;
        private FontAwesome.Sharp.IconButton iconButtonMil;
        private FontAwesome.Sharp.IconButton iconButtonVol;
        private System.Windows.Forms.Button buttonNotification;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.Button buttonMaximized;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
    }
}