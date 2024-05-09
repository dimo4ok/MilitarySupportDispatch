namespace MilitarySupportDispatch.MainFormElements
{
    partial class VolunteersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteersListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUpp = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelSearchEnter = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.dataGridVolunteersList = new System.Windows.Forms.DataGridView();
            this.id_volunter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_nameOfOrgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            this.panelSearchEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVolunteersList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpp
            // 
            this.panelUpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelUpp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpp.Location = new System.Drawing.Point(0, 0);
            this.panelUpp.Name = "panelUpp";
            this.panelUpp.Size = new System.Drawing.Size(1040, 10);
            this.panelUpp.TabIndex = 9;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelSearch.Controls.Add(this.panelSearchEnter);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 10);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1040, 61);
            this.panelSearch.TabIndex = 10;
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
            this.textBoxSearchText.Text = "Пошук по назві організації";
            this.textBoxSearchText.Click += new System.EventHandler(this.textBoxSearchText_Click);
            this.textBoxSearchText.Leave += new System.EventHandler(this.textBoxSearchText_Leave);
            // 
            // dataGridVolunteersList
            // 
            this.dataGridVolunteersList.AllowUserToAddRows = false;
            this.dataGridVolunteersList.AllowUserToDeleteRows = false;
            this.dataGridVolunteersList.AllowUserToResizeRows = false;
            this.dataGridVolunteersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVolunteersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.dataGridVolunteersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVolunteersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVolunteersList.ColumnHeadersHeight = 40;
            this.dataGridVolunteersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVolunteersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_volunter,
            this.vol_nameOfOrgan,
            this.vol_firstName,
            this.vol_lastName,
            this.vol_number,
            this.vol_post});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVolunteersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVolunteersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVolunteersList.EnableHeadersVisualStyles = false;
            this.dataGridVolunteersList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridVolunteersList.Location = new System.Drawing.Point(0, 71);
            this.dataGridVolunteersList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVolunteersList.Name = "dataGridVolunteersList";
            this.dataGridVolunteersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVolunteersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVolunteersList.RowHeadersVisible = false;
            this.dataGridVolunteersList.RowHeadersWidth = 40;
            this.dataGridVolunteersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridVolunteersList.RowTemplate.Height = 50;
            this.dataGridVolunteersList.RowTemplate.ReadOnly = true;
            this.dataGridVolunteersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVolunteersList.Size = new System.Drawing.Size(1040, 693);
            this.dataGridVolunteersList.TabIndex = 11;
            this.dataGridVolunteersList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridMilitaryList_RowPrePaint);
            // 
            // id_volunter
            // 
            this.id_volunter.FillWeight = 42.81581F;
            this.id_volunter.HeaderText = "Id";
            this.id_volunter.Name = "id_volunter";
            this.id_volunter.ReadOnly = true;
            this.id_volunter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vol_nameOfOrgan
            // 
            this.vol_nameOfOrgan.FillWeight = 115.2521F;
            this.vol_nameOfOrgan.HeaderText = "Організація";
            this.vol_nameOfOrgan.Name = "vol_nameOfOrgan";
            this.vol_nameOfOrgan.ReadOnly = true;
            this.vol_nameOfOrgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vol_firstName
            // 
            this.vol_firstName.HeaderText = "Ім\'я";
            this.vol_firstName.Name = "vol_firstName";
            this.vol_firstName.ReadOnly = true;
            this.vol_firstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vol_firstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vol_lastName
            // 
            this.vol_lastName.HeaderText = "Прізвище";
            this.vol_lastName.Name = "vol_lastName";
            this.vol_lastName.ReadOnly = true;
            this.vol_lastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vol_number
            // 
            this.vol_number.FillWeight = 117.091F;
            this.vol_number.HeaderText = "Номер телефону";
            this.vol_number.Name = "vol_number";
            this.vol_number.ReadOnly = true;
            this.vol_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vol_post
            // 
            this.vol_post.FillWeight = 92.51183F;
            this.vol_post.HeaderText = "Пошта";
            this.vol_post.Name = "vol_post";
            this.vol_post.ReadOnly = true;
            this.vol_post.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VolunteersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1040, 764);
            this.Controls.Add(this.dataGridVolunteersList);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelUpp);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "VolunteersListForm";
            this.Text = "VolunteersListForm";
            this.Load += new System.EventHandler(this.VolunteersListForm_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearchEnter.ResumeLayout(false);
            this.panelSearchEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVolunteersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpp;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelSearchEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.DataGridView dataGridVolunteersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_volunter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_nameOfOrgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol_post;
    }
}