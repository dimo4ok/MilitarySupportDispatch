namespace MilitarySupportDispatch.MainForms.ElementsMainForms
{
    partial class GoogleMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleMap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelUpp = new System.Windows.Forms.Panel();
            this.buttonMaximized = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTextBoxLocation = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.panelGoogleMap = new System.Windows.Forms.Panel();
            this.chromiumWebBrowserMap = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panelUpp.SuspendLayout();
            this.panelTextBoxLocation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelGoogleMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 6);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 794);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1094, 6);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1094, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 800);
            this.panel3.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 788);
            this.panel2.TabIndex = 31;
            // 
            // panelUpp
            // 
            this.panelUpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.panelUpp.Controls.Add(this.buttonMaximized);
            this.panelUpp.Controls.Add(this.buttonMinimize);
            this.panelUpp.Controls.Add(this.buttonClose);
            this.panelUpp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpp.Location = new System.Drawing.Point(6, 6);
            this.panelUpp.Name = "panelUpp";
            this.panelUpp.Size = new System.Drawing.Size(1088, 43);
            this.panelUpp.TabIndex = 32;
            this.panelUpp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpp_MouseDown);
            this.panelUpp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpp_MouseMove);
            this.panelUpp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUpp_MouseUp);
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
            this.buttonMaximized.Location = new System.Drawing.Point(1013, 6);
            this.buttonMaximized.Name = "buttonMaximized";
            this.buttonMaximized.Size = new System.Drawing.Size(25, 25);
            this.buttonMaximized.TabIndex = 28;
            this.buttonMaximized.UseVisualStyleBackColor = false;
            this.buttonMaximized.Click += new System.EventHandler(this.buttonMaximized_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMinimize.Location = new System.Drawing.Point(972, 6);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.TabIndex = 27;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonMinimize_KeyDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(1054, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonClose_KeyDown);
            // 
            // panelTextBoxLocation
            // 
            this.panelTextBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelTextBoxLocation.Controls.Add(this.panel5);
            this.panelTextBoxLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTextBoxLocation.Location = new System.Drawing.Point(6, 736);
            this.panelTextBoxLocation.Name = "panelTextBoxLocation";
            this.panelTextBoxLocation.Size = new System.Drawing.Size(1088, 58);
            this.panelTextBoxLocation.TabIndex = 35;
            this.panelTextBoxLocation.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.textBoxLocation);
            this.panel5.Location = new System.Drawing.Point(6, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 57);
            this.panel5.TabIndex = 36;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLocation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxLocation.Location = new System.Drawing.Point(16, 17);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(554, 24);
            this.textBoxLocation.TabIndex = 35;
            this.textBoxLocation.Text = "Натисність, щоб відобразити скопійовану локацію";
            this.textBoxLocation.Click += new System.EventHandler(this.textBoxLocation_Click);
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // panelGoogleMap
            // 
            this.panelGoogleMap.Controls.Add(this.chromiumWebBrowserMap);
            this.panelGoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoogleMap.Location = new System.Drawing.Point(6, 49);
            this.panelGoogleMap.Name = "panelGoogleMap";
            this.panelGoogleMap.Size = new System.Drawing.Size(1088, 687);
            this.panelGoogleMap.TabIndex = 36;
            // 
            // chromiumWebBrowserMap
            // 
            this.chromiumWebBrowserMap.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowserMap.Name = "chromiumWebBrowserMap";
            this.chromiumWebBrowserMap.Size = new System.Drawing.Size(1088, 687);
            this.chromiumWebBrowserMap.TabIndex = 34;
            this.chromiumWebBrowserMap.LoadError += new System.EventHandler<CefSharp.LoadErrorEventArgs>(this.chromiumWebBrowser1_LoadError);
            // 
            // GoogleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.panelGoogleMap);
            this.Controls.Add(this.panelTextBoxLocation);
            this.Controls.Add(this.panelUpp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoogleMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GoogleMaps";
            this.Load += new System.EventHandler(this.GoogleMap_Load);
            this.panelUpp.ResumeLayout(false);
            this.panelTextBoxLocation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelGoogleMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUpp;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximized;
        private System.Windows.Forms.Panel panelTextBoxLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Panel panelGoogleMap;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowserMap;
        private System.Windows.Forms.Panel panel5;
    }
}