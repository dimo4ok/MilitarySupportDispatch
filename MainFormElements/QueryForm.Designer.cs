namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelColumnHeaderName = new System.Windows.Forms.Panel();
            this.TextBoxColumnHeaderText = new System.Windows.Forms.TextBox();
            this.panelSearchEnter = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.panelChooseForMilitary = new System.Windows.Forms.Panel();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonCorrect = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.panelChooseForVolunteers = new System.Windows.Forms.Panel();
            this.iconButtonCancelHandle = new FontAwesome.Sharp.IconButton();
            this.iconButtonHandle = new FontAwesome.Sharp.IconButton();
            this.iconButtonMap = new FontAwesome.Sharp.IconButton();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridViewSupplyTable = new System.Windows.Forms.DataGridView();
            this.id_supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mil_nameOfOrgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_nameOfOrgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime_accept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSearch.SuspendLayout();
            this.panelColumnHeaderName.SuspendLayout();
            this.panelSearchEnter.SuspendLayout();
            this.panelChooseForMilitary.SuspendLayout();
            this.panelChooseForVolunteers.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelSearch.Controls.Add(this.panelColumnHeaderName);
            this.panelSearch.Controls.Add(this.panelSearchEnter);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1040, 61);
            this.panelSearch.TabIndex = 1;
            // 
            // panelColumnHeaderName
            // 
            this.panelColumnHeaderName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelColumnHeaderName.BackgroundImage")));
            this.panelColumnHeaderName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelColumnHeaderName.Controls.Add(this.TextBoxColumnHeaderText);
            this.panelColumnHeaderName.Location = new System.Drawing.Point(465, 8);
            this.panelColumnHeaderName.Name = "panelColumnHeaderName";
            this.panelColumnHeaderName.Size = new System.Drawing.Size(307, 45);
            this.panelColumnHeaderName.TabIndex = 11;
            this.panelColumnHeaderName.Visible = false;
            // 
            // TextBoxColumnHeaderText
            // 
            this.TextBoxColumnHeaderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.TextBoxColumnHeaderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxColumnHeaderText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxColumnHeaderText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxColumnHeaderText.Location = new System.Drawing.Point(16, 11);
            this.TextBoxColumnHeaderText.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxColumnHeaderText.Name = "TextBoxColumnHeaderText";
            this.TextBoxColumnHeaderText.ReadOnly = true;
            this.TextBoxColumnHeaderText.Size = new System.Drawing.Size(223, 24);
            this.TextBoxColumnHeaderText.TabIndex = 6;
            this.TextBoxColumnHeaderText.Tag = "";
            this.TextBoxColumnHeaderText.Text = "Оберіть назву колонки";
            // 
            // panelSearchEnter
            // 
            this.panelSearchEnter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSearchEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSearchEnter.BackgroundImage")));
            this.panelSearchEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSearchEnter.Controls.Add(this.buttonClear);
            this.panelSearchEnter.Controls.Add(this.buttonSearch);
            this.panelSearchEnter.Controls.Add(this.textBoxSearchText);
            this.panelSearchEnter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSearchEnter.Location = new System.Drawing.Point(12, 8);
            this.panelSearchEnter.Name = "panelSearchEnter";
            this.panelSearchEnter.Size = new System.Drawing.Size(420, 45);
            this.panelSearchEnter.TabIndex = 10;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.buttonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.BackgroundImage")));
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(346, 8);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(28, 28);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(380, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(28, 28);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.textBoxSearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSearchText.Location = new System.Drawing.Point(16, 11);
            this.textBoxSearchText.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(314, 24);
            this.textBoxSearchText.TabIndex = 9;
            this.textBoxSearchText.Tag = "";
            this.textBoxSearchText.Text = "Пошук по ключових словах";
            this.textBoxSearchText.Click += new System.EventHandler(this.textBoxSearchText_Click);
            this.textBoxSearchText.Leave += new System.EventHandler(this.textBoxSearchText_Leave);
            // 
            // panelChooseForMilitary
            // 
            this.panelChooseForMilitary.Controls.Add(this.iconButtonAdd);
            this.panelChooseForMilitary.Controls.Add(this.iconButtonCorrect);
            this.panelChooseForMilitary.Controls.Add(this.iconButtonDelete);
            this.panelChooseForMilitary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseForMilitary.Location = new System.Drawing.Point(0, 613);
            this.panelChooseForMilitary.Margin = new System.Windows.Forms.Padding(4);
            this.panelChooseForMilitary.Name = "panelChooseForMilitary";
            this.panelChooseForMilitary.Size = new System.Drawing.Size(1040, 151);
            this.panelChooseForMilitary.TabIndex = 2;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButtonAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 35;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(0, 1);
            this.iconButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonAdd.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonAdd.TabIndex = 8;
            this.iconButtonAdd.Text = "Додати";
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // iconButtonCorrect
            // 
            this.iconButtonCorrect.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonCorrect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonCorrect.FlatAppearance.BorderSize = 0;
            this.iconButtonCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCorrect.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonCorrect.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonCorrect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonCorrect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCorrect.IconSize = 35;
            this.iconButtonCorrect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCorrect.Location = new System.Drawing.Point(0, 51);
            this.iconButtonCorrect.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonCorrect.Name = "iconButtonCorrect";
            this.iconButtonCorrect.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonCorrect.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonCorrect.TabIndex = 7;
            this.iconButtonCorrect.Text = "Редагувати";
            this.iconButtonCorrect.UseVisualStyleBackColor = true;
            this.iconButtonCorrect.Click += new System.EventHandler(this.iconButtonCorrect_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButtonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 35;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDelete.Location = new System.Drawing.Point(0, 101);
            this.iconButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonDelete.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonDelete.TabIndex = 6;
            this.iconButtonDelete.Text = "Видалити";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // panelChooseForVolunteers
            // 
            this.panelChooseForVolunteers.Controls.Add(this.iconButtonCancelHandle);
            this.panelChooseForVolunteers.Controls.Add(this.iconButtonHandle);
            this.panelChooseForVolunteers.Controls.Add(this.iconButtonMap);
            this.panelChooseForVolunteers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseForVolunteers.Location = new System.Drawing.Point(0, 462);
            this.panelChooseForVolunteers.Margin = new System.Windows.Forms.Padding(4);
            this.panelChooseForVolunteers.Name = "panelChooseForVolunteers";
            this.panelChooseForVolunteers.Size = new System.Drawing.Size(1040, 151);
            this.panelChooseForVolunteers.TabIndex = 3;
            // 
            // iconButtonCancelHandle
            // 
            this.iconButtonCancelHandle.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonCancelHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCancelHandle.FlatAppearance.BorderSize = 0;
            this.iconButtonCancelHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelHandle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonCancelHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonCancelHandle.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iconButtonCancelHandle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonCancelHandle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelHandle.IconSize = 35;
            this.iconButtonCancelHandle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCancelHandle.Location = new System.Drawing.Point(0, 50);
            this.iconButtonCancelHandle.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonCancelHandle.Name = "iconButtonCancelHandle";
            this.iconButtonCancelHandle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonCancelHandle.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonCancelHandle.TabIndex = 14;
            this.iconButtonCancelHandle.Text = "Відмінити обробку запиту";
            this.iconButtonCancelHandle.UseVisualStyleBackColor = true;
            this.iconButtonCancelHandle.Click += new System.EventHandler(this.iconButtonCancelHandle_Click);
            // 
            // iconButtonHandle
            // 
            this.iconButtonHandle.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHandle.FlatAppearance.BorderSize = 0;
            this.iconButtonHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHandle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonHandle.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButtonHandle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonHandle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHandle.IconSize = 35;
            this.iconButtonHandle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHandle.Location = new System.Drawing.Point(0, 0);
            this.iconButtonHandle.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonHandle.Name = "iconButtonHandle";
            this.iconButtonHandle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonHandle.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonHandle.TabIndex = 13;
            this.iconButtonHandle.Text = "Обробити запит";
            this.iconButtonHandle.UseVisualStyleBackColor = true;
            this.iconButtonHandle.Click += new System.EventHandler(this.iconButtonHandle_Click);
            // 
            // iconButtonMap
            // 
            this.iconButtonMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonMap.FlatAppearance.BorderSize = 0;
            this.iconButtonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMap.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMap.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.iconButtonMap.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonMap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMap.IconSize = 35;
            this.iconButtonMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMap.Location = new System.Drawing.Point(0, 101);
            this.iconButtonMap.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonMap.Name = "iconButtonMap";
            this.iconButtonMap.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButtonMap.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonMap.TabIndex = 11;
            this.iconButtonMap.Text = "Відкрити карту";
            this.iconButtonMap.UseVisualStyleBackColor = true;
            this.iconButtonMap.Click += new System.EventHandler(this.iconButtonMap_Click);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridViewSupplyTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTable.Location = new System.Drawing.Point(0, 61);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1040, 401);
            this.panelTable.TabIndex = 4;
            // 
            // dataGridViewSupplyTable
            // 
            this.dataGridViewSupplyTable.AllowUserToAddRows = false;
            this.dataGridViewSupplyTable.AllowUserToDeleteRows = false;
            this.dataGridViewSupplyTable.AllowUserToResizeRows = false;
            this.dataGridViewSupplyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSupplyTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.dataGridViewSupplyTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupplyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSupplyTable.ColumnHeadersHeight = 40;
            this.dataGridViewSupplyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSupplyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_supply,
            this.mil_nameOfOrgan,
            this.category,
            this.name_of_goods,
            this.name_of_company,
            this.number_of_goods,
            this.delivery_location,
            this.datetime_add,
            this.vol_nameOfOrgan,
            this.datetime_accept,
            this.is_success,
            this.goods_image});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSupplyTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSupplyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSupplyTable.EnableHeadersVisualStyles = false;
            this.dataGridViewSupplyTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSupplyTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSupplyTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSupplyTable.Name = "dataGridViewSupplyTable";
            this.dataGridViewSupplyTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupplyTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSupplyTable.RowHeadersVisible = false;
            this.dataGridViewSupplyTable.RowHeadersWidth = 40;
            this.dataGridViewSupplyTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSupplyTable.RowTemplate.Height = 50;
            this.dataGridViewSupplyTable.RowTemplate.ReadOnly = true;
            this.dataGridViewSupplyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplyTable.Size = new System.Drawing.Size(1040, 401);
            this.dataGridViewSupplyTable.TabIndex = 5;
            this.dataGridViewSupplyTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplyTable_CellClick);
            this.dataGridViewSupplyTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplyTable_CellContentDoubleClick);
            this.dataGridViewSupplyTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSupplyTable_ColumnHeaderMouseClick);
            this.dataGridViewSupplyTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewSupplyTable_RowPrePaint);
            // 
            // id_supply
            // 
            this.id_supply.FillWeight = 42.81581F;
            this.id_supply.HeaderText = "Id";
            this.id_supply.Name = "id_supply";
            this.id_supply.ReadOnly = true;
            this.id_supply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_supply.Width = 37;
            // 
            // mil_nameOfOrgan
            // 
            this.mil_nameOfOrgan.FillWeight = 200F;
            this.mil_nameOfOrgan.HeaderText = "Бригада";
            this.mil_nameOfOrgan.Name = "mil_nameOfOrgan";
            this.mil_nameOfOrgan.ReadOnly = true;
            this.mil_nameOfOrgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // category
            // 
            this.category.FillWeight = 117.9114F;
            this.category.HeaderText = "Категорія";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category.Width = 105;
            // 
            // name_of_goods
            // 
            this.name_of_goods.FillWeight = 157.9006F;
            this.name_of_goods.HeaderText = "Назва товару";
            this.name_of_goods.Name = "name_of_goods";
            this.name_of_goods.ReadOnly = true;
            this.name_of_goods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_of_goods.Width = 145;
            // 
            // name_of_company
            // 
            this.name_of_company.FillWeight = 117.091F;
            this.name_of_company.HeaderText = "Виробник";
            this.name_of_company.Name = "name_of_company";
            this.name_of_company.ReadOnly = true;
            this.name_of_company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_of_company.Width = 113;
            // 
            // number_of_goods
            // 
            this.number_of_goods.FillWeight = 92.51183F;
            this.number_of_goods.HeaderText = "Кількість";
            this.number_of_goods.Name = "number_of_goods";
            this.number_of_goods.ReadOnly = true;
            this.number_of_goods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number_of_goods.Width = 93;
            // 
            // delivery_location
            // 
            this.delivery_location.FillWeight = 160.635F;
            this.delivery_location.HeaderText = "Місце доставки";
            this.delivery_location.Name = "delivery_location";
            this.delivery_location.ReadOnly = true;
            this.delivery_location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.delivery_location.Width = 167;
            // 
            // datetime_add
            // 
            this.datetime_add.FillWeight = 98.82479F;
            this.datetime_add.HeaderText = "Створено";
            this.datetime_add.Name = "datetime_add";
            this.datetime_add.ReadOnly = true;
            this.datetime_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datetime_add.Width = 110;
            // 
            // vol_nameOfOrgan
            // 
            this.vol_nameOfOrgan.FillWeight = 91.90029F;
            this.vol_nameOfOrgan.HeaderText = "Волонтер";
            this.vol_nameOfOrgan.Name = "vol_nameOfOrgan";
            this.vol_nameOfOrgan.ReadOnly = true;
            this.vol_nameOfOrgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vol_nameOfOrgan.Width = 107;
            // 
            // datetime_accept
            // 
            this.datetime_accept.FillWeight = 87.96994F;
            this.datetime_accept.HeaderText = "Прийнято";
            this.datetime_accept.Name = "datetime_accept";
            this.datetime_accept.ReadOnly = true;
            this.datetime_accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datetime_accept.Width = 107;
            // 
            // is_success
            // 
            this.is_success.FillWeight = 66.11853F;
            this.is_success.HeaderText = "Статус";
            this.is_success.Name = "is_success";
            this.is_success.ReadOnly = true;
            this.is_success.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_success.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.is_success.Width = 84;
            // 
            // goods_image
            // 
            this.goods_image.FillWeight = 51.06857F;
            this.goods_image.HeaderText = "Фото";
            this.goods_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.goods_image.Name = "goods_image";
            this.goods_image.ReadOnly = true;
            this.goods_image.Width = 67;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1040, 764);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelChooseForVolunteers);
            this.Controls.Add(this.panelChooseForMilitary);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryForm_FormClosed);
            this.SizeChanged += new System.EventHandler(this.QueryForm_SizeChanged);
            this.panelSearch.ResumeLayout(false);
            this.panelColumnHeaderName.ResumeLayout(false);
            this.panelColumnHeaderName.PerformLayout();
            this.panelSearchEnter.ResumeLayout(false);
            this.panelSearchEnter.PerformLayout();
            this.panelChooseForMilitary.ResumeLayout(false);
            this.panelChooseForVolunteers.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelChooseForMilitary;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconButton iconButtonCorrect;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Panel panelChooseForVolunteers;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridViewSupplyTable;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.TextBox TextBoxColumnHeaderText;
        private System.Windows.Forms.Panel panelSearchEnter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelColumnHeaderName;
        private System.Windows.Forms.Button buttonClear;
        private FontAwesome.Sharp.IconButton iconButtonCancelHandle;
        private FontAwesome.Sharp.IconButton iconButtonHandle;
        private FontAwesome.Sharp.IconButton iconButtonMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn mil_nameOfOrgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_of_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_of_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_nameOfOrgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime_accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_success;
        private System.Windows.Forms.DataGridViewImageColumn goods_image;
    }
}