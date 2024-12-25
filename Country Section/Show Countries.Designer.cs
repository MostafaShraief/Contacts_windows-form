namespace Contacts_WF.Country_Section
{
    partial class Show_Countries
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
            this.ListView = new System.Windows.Forms.ListView();
            this.CountryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbName = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbID = new Guna.UI2.WinForms.Guna2CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textboxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmsRows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.cmsRows.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AutoArrange = false;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CountryID,
            this.CountryName,
            this.CountryCode,
            this.PhoneCode});
            this.ListView.ContextMenuStrip = this.cmsRows;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(844, 576);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // CountryID
            // 
            this.CountryID.Text = "Country ID";
            this.CountryID.Width = 200;
            // 
            // CountryName
            // 
            this.CountryName.Text = "Name";
            this.CountryName.Width = 301;
            // 
            // CountryCode
            // 
            this.CountryCode.Text = "Code";
            this.CountryCode.Width = 87;
            // 
            // PhoneCode
            // 
            this.PhoneCode.Text = "Phone Code";
            this.PhoneCode.Width = 194;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(462, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(58, 56);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(526, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(58, 56);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cbName);
            this.guna2Panel2.Controls.Add(this.cbID);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(169, 56);
            this.guna2Panel2.TabIndex = 2;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbName.CheckedState.BorderRadius = 2;
            this.cbName.CheckedState.BorderThickness = 0;
            this.cbName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbName.Location = new System.Drawing.Point(81, 27);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(79, 26);
            this.cbName.TabIndex = 3;
            this.cbName.Text = "Name";
            this.cbName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbName.UncheckedState.BorderRadius = 2;
            this.cbName.UncheckedState.BorderThickness = 0;
            this.cbName.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Checked = true;
            this.cbID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbID.CheckedState.BorderRadius = 2;
            this.cbID.CheckedState.BorderThickness = 0;
            this.cbID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbID.Location = new System.Drawing.Point(81, 3);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(49, 26);
            this.cbID.TabIndex = 2;
            this.cbID.Text = "ID";
            this.cbID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbID.UncheckedState.BorderRadius = 2;
            this.cbID.UncheckedState.BorderThickness = 0;
            this.cbID.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbID.UseVisualStyleBackColor = true;
            this.cbID.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListView);
            this.splitContainer1.Size = new System.Drawing.Size(844, 639);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanel1.Controls.Add(this.textboxSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(844, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textboxSearch
            // 
            this.textboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxSearch.DefaultText = "";
            this.textboxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSearch.DisabledState.Parent = this.textboxSearch;
            this.textboxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSearch.FocusedState.Parent = this.textboxSearch;
            this.textboxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSearch.HoverState.Parent = this.textboxSearch;
            this.textboxSearch.Location = new System.Drawing.Point(184, 9);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(9);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.PasswordChar = '\0';
            this.textboxSearch.PlaceholderText = "";
            this.textboxSearch.SelectedText = "";
            this.textboxSearch.ShadowDecoration.Parent = this.textboxSearch;
            this.textboxSearch.Size = new System.Drawing.Size(266, 46);
            this.textboxSearch.TabIndex = 4;
            this.textboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxSearch_KeyDown);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.splitContainer1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(844, 639);
            this.guna2Panel1.TabIndex = 1;
            // 
            // cmsRows
            // 
            this.cmsRows.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deletteToolStripMenuItem});
            this.cmsRows.Name = "cmsRows";
            this.cmsRows.Size = new System.Drawing.Size(119, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deletteToolStripMenuItem
            // 
            this.deletteToolStripMenuItem.Name = "deletteToolStripMenuItem";
            this.deletteToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deletteToolStripMenuItem.Text = "Delete";
            this.deletteToolStripMenuItem.Click += new System.EventHandler(this.deletteToolStripMenuItem_Click);
            // 
            // Show_Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 639);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Countries";
            this.Text = "Show_Countries";
            this.Load += new System.EventHandler(this.Show_Countries_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.cmsRows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader CountryID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ColumnHeader CountryName;
        private System.Windows.Forms.ColumnHeader CountryCode;
        private System.Windows.Forms.ColumnHeader PhoneCode;
        private Guna.UI2.WinForms.Guna2CheckBox cbName;
        private Guna.UI2.WinForms.Guna2CheckBox cbID;
        private Guna.UI2.WinForms.Guna2TextBox textboxSearch;
        private System.Windows.Forms.ContextMenuStrip cmsRows;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletteToolStripMenuItem;
    }
}