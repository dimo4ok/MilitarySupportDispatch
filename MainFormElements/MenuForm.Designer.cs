namespace MilitarySupportDispatch.MainForms.VolunteerFormsElements
{
    partial class MenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelMap = new System.Windows.Forms.Panel();
            this.iconButtonMap = new FontAwesome.Sharp.IconButton();
            this.panelChooseForVolunteers = new System.Windows.Forms.Panel();
            this.iconButtonConfirmShipping = new FontAwesome.Sharp.IconButton();
            this.panelChooseForMilitary = new System.Windows.Forms.Panel();
            this.iconButtonConfirmReceiving = new FontAwesome.Sharp.IconButton();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridViewGeneralSupplyTable = new System.Windows.Forms.DataGridView();
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelColumnHeaderName = new System.Windows.Forms.Panel();
            this.TextBoxColumnHeaderText = new System.Windows.Forms.TextBox();
            this.panelSearchEnter = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.panelMap.SuspendLayout();
            this.panelChooseForVolunteers.SuspendLayout();
            this.panelChooseForMilitary.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralSupplyTable)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelColumnHeaderName.SuspendLayout();
            this.panelSearchEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.iconButtonMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMap.Location = new System.Drawing.Point(0, 713);
            this.panelMap.Margin = new System.Windows.Forms.Padding(6);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1040, 51);
            this.panelMap.TabIndex = 4;
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
            this.iconButtonMap.Location = new System.Drawing.Point(0, 1);
            this.iconButtonMap.Margin = new System.Windows.Forms.Padding(6);
            this.iconButtonMap.Name = "iconButtonMap";
            this.iconButtonMap.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButtonMap.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonMap.TabIndex = 11;
            this.iconButtonMap.Text = "Відкрити карту";
            this.iconButtonMap.UseVisualStyleBackColor = true;
            this.iconButtonMap.Click += new System.EventHandler(this.iconButtonMap_Click);
            // 
            // panelChooseForVolunteers
            // 
            this.panelChooseForVolunteers.Controls.Add(this.iconButtonConfirmShipping);
            this.panelChooseForVolunteers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseForVolunteers.Location = new System.Drawing.Point(0, 662);
            this.panelChooseForVolunteers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelChooseForVolunteers.Name = "panelChooseForVolunteers";
            this.panelChooseForVolunteers.Size = new System.Drawing.Size(1040, 51);
            this.panelChooseForVolunteers.TabIndex = 5;
            // 
            // iconButtonConfirmShipping
            // 
            this.iconButtonConfirmShipping.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonConfirmShipping.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonConfirmShipping.FlatAppearance.BorderSize = 0;
            this.iconButtonConfirmShipping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfirmShipping.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonConfirmShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonConfirmShipping.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.iconButtonConfirmShipping.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonConfirmShipping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfirmShipping.IconSize = 35;
            this.iconButtonConfirmShipping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfirmShipping.Location = new System.Drawing.Point(0, 1);
            this.iconButtonConfirmShipping.Margin = new System.Windows.Forms.Padding(6);
            this.iconButtonConfirmShipping.Name = "iconButtonConfirmShipping";
            this.iconButtonConfirmShipping.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButtonConfirmShipping.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonConfirmShipping.TabIndex = 14;
            this.iconButtonConfirmShipping.Text = "Підтвердити/відмінити відправку";
            this.iconButtonConfirmShipping.UseVisualStyleBackColor = true;
            this.iconButtonConfirmShipping.Click += new System.EventHandler(this.iconButtonAcceptCancelShipping_Click);
            // 
            // panelChooseForMilitary
            // 
            this.panelChooseForMilitary.Controls.Add(this.iconButtonConfirmReceiving);
            this.panelChooseForMilitary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChooseForMilitary.Location = new System.Drawing.Point(0, 611);
            this.panelChooseForMilitary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelChooseForMilitary.Name = "panelChooseForMilitary";
            this.panelChooseForMilitary.Size = new System.Drawing.Size(1040, 51);
            this.panelChooseForMilitary.TabIndex = 6;
            // 
            // iconButtonConfirmReceiving
            // 
            this.iconButtonConfirmReceiving.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonConfirmReceiving.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonConfirmReceiving.FlatAppearance.BorderSize = 0;
            this.iconButtonConfirmReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfirmReceiving.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonConfirmReceiving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonConfirmReceiving.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox;
            this.iconButtonConfirmReceiving.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.iconButtonConfirmReceiving.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfirmReceiving.IconSize = 35;
            this.iconButtonConfirmReceiving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfirmReceiving.Location = new System.Drawing.Point(0, 1);
            this.iconButtonConfirmReceiving.Margin = new System.Windows.Forms.Padding(6);
            this.iconButtonConfirmReceiving.Name = "iconButtonConfirmReceiving";
            this.iconButtonConfirmReceiving.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButtonConfirmReceiving.Size = new System.Drawing.Size(1040, 50);
            this.iconButtonConfirmReceiving.TabIndex = 15;
            this.iconButtonConfirmReceiving.Text = "Підтвердити отримання";
            this.iconButtonConfirmReceiving.UseVisualStyleBackColor = true;
            this.iconButtonConfirmReceiving.Click += new System.EventHandler(this.iconButtonConfirmReceiving_Click);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridViewGeneralSupplyTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTable.Location = new System.Drawing.Point(0, 61);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1040, 550);
            this.panelTable.TabIndex = 8;
            // 
            // dataGridViewGeneralSupplyTable
            // 
            this.dataGridViewGeneralSupplyTable.AllowUserToAddRows = false;
            this.dataGridViewGeneralSupplyTable.AllowUserToDeleteRows = false;
            this.dataGridViewGeneralSupplyTable.AllowUserToResizeRows = false;
            this.dataGridViewGeneralSupplyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGeneralSupplyTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.dataGridViewGeneralSupplyTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneralSupplyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGeneralSupplyTable.ColumnHeadersHeight = 40;
            this.dataGridViewGeneralSupplyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGeneralSupplyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewGeneralSupplyTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGeneralSupplyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGeneralSupplyTable.EnableHeadersVisualStyles = false;
            this.dataGridViewGeneralSupplyTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewGeneralSupplyTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGeneralSupplyTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGeneralSupplyTable.Name = "dataGridViewGeneralSupplyTable";
            this.dataGridViewGeneralSupplyTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGeneralSupplyTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGeneralSupplyTable.RowHeadersVisible = false;
            this.dataGridViewGeneralSupplyTable.RowHeadersWidth = 40;
            this.dataGridViewGeneralSupplyTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewGeneralSupplyTable.RowTemplate.Height = 50;
            this.dataGridViewGeneralSupplyTable.RowTemplate.ReadOnly = true;
            this.dataGridViewGeneralSupplyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGeneralSupplyTable.Size = new System.Drawing.Size(1040, 550);
            this.dataGridViewGeneralSupplyTable.TabIndex = 5;
            this.dataGridViewGeneralSupplyTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGeneralSupplyTable_CellClick);
            this.dataGridViewGeneralSupplyTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGeneralSupplyTable_CellContentDoubleClick);
            this.dataGridViewGeneralSupplyTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGeneralSupplyTable_ColumnHeaderMouseClick);
            this.dataGridViewGeneralSupplyTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewGeneralSupplyTable_RowPrePaint);
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
            this.mil_nameOfOrgan.FillWeight = 114.3582F;
            this.mil_nameOfOrgan.HeaderText = "Бригада";
            this.mil_nameOfOrgan.Name = "mil_nameOfOrgan";
            this.mil_nameOfOrgan.ReadOnly = true;
            this.mil_nameOfOrgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // category
            // 
            this.category.FillWeight = 116.2601F;
            this.category.HeaderText = "Категорія";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category.Width = 105;
            // 
            // name_of_goods
            // 
            this.name_of_goods.FillWeight = 155.193F;
            this.name_of_goods.HeaderText = "Назва товару";
            this.name_of_goods.Name = "name_of_goods";
            this.name_of_goods.ReadOnly = true;
            this.name_of_goods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_of_goods.Width = 145;
            // 
            // name_of_company
            // 
            this.name_of_company.FillWeight = 115.3767F;
            this.name_of_company.HeaderText = "Виробник";
            this.name_of_company.Name = "name_of_company";
            this.name_of_company.ReadOnly = true;
            this.name_of_company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_of_company.Width = 113;
            // 
            // number_of_goods
            // 
            this.number_of_goods.FillWeight = 91.5564F;
            this.number_of_goods.HeaderText = "Кількість";
            this.number_of_goods.Name = "number_of_goods";
            this.number_of_goods.ReadOnly = true;
            this.number_of_goods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number_of_goods.Width = 93;
            // 
            // delivery_location
            // 
            this.delivery_location.FillWeight = 159.567F;
            this.delivery_location.HeaderText = "Місце доставки";
            this.delivery_location.Name = "delivery_location";
            this.delivery_location.ReadOnly = true;
            this.delivery_location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.delivery_location.Width = 167;
            // 
            // datetime_add
            // 
            this.datetime_add.FillWeight = 99.54679F;
            this.datetime_add.HeaderText = "Створено";
            this.datetime_add.Name = "datetime_add";
            this.datetime_add.ReadOnly = true;
            this.datetime_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datetime_add.Width = 110;
            // 
            // vol_nameOfOrgan
            // 
            this.vol_nameOfOrgan.FillWeight = 93.4565F;
            this.vol_nameOfOrgan.HeaderText = "Волонтер";
            this.vol_nameOfOrgan.Name = "vol_nameOfOrgan";
            this.vol_nameOfOrgan.ReadOnly = true;
            this.vol_nameOfOrgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vol_nameOfOrgan.Width = 107;
            // 
            // datetime_accept
            // 
            this.datetime_accept.FillWeight = 90.27957F;
            this.datetime_accept.HeaderText = "Прийнято";
            this.datetime_accept.Name = "datetime_accept";
            this.datetime_accept.ReadOnly = true;
            this.datetime_accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datetime_accept.Width = 107;
            // 
            // is_success
            // 
            this.is_success.FillWeight = 68.45612F;
            this.is_success.HeaderText = "Статус";
            this.is_success.Name = "is_success";
            this.is_success.ReadOnly = true;
            this.is_success.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_success.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.is_success.Width = 84;
            // 
            // goods_image
            // 
            this.goods_image.FillWeight = 53.13354F;
            this.goods_image.HeaderText = "Фото";
            this.goods_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.goods_image.Name = "goods_image";
            this.goods_image.ReadOnly = true;
            this.goods_image.Width = 67;
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
            this.panelSearch.TabIndex = 7;
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
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1040, 764);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelChooseForMilitary);
            this.Controls.Add(this.panelChooseForVolunteers);
            this.Controls.Add(this.panelMap);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.SizeChanged += new System.EventHandler(this.MenuForm_SizeChanged);
            this.panelMap.ResumeLayout(false);
            this.panelChooseForVolunteers.ResumeLayout(false);
            this.panelChooseForMilitary.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralSupplyTable)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelColumnHeaderName.ResumeLayout(false);
            this.panelColumnHeaderName.PerformLayout();
            this.panelSearchEnter.ResumeLayout(false);
            this.panelSearchEnter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private FontAwesome.Sharp.IconButton iconButtonMap;
        private System.Windows.Forms.Panel panelChooseForVolunteers;
        private FontAwesome.Sharp.IconButton iconButtonConfirmShipping;
        private System.Windows.Forms.Panel panelChooseForMilitary;
        private FontAwesome.Sharp.IconButton iconButtonConfirmReceiving;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridViewGeneralSupplyTable;
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
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelColumnHeaderName;
        private System.Windows.Forms.TextBox TextBoxColumnHeaderText;
        private System.Windows.Forms.Panel panelSearchEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchText;
    }
}