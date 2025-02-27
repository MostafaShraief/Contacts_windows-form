﻿namespace Contacts_WF.Contact_Section
{
    partial class Find
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.tbContactID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInsertTitle = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(848, 639);
            this.guna2Panel2.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.lblFind);
            this.guna2Panel1.Controls.Add(this.btnFind);
            this.guna2Panel1.Controls.Add(this.tbContactID);
            this.guna2Panel1.Controls.Add(this.lblInsertTitle);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(804, 599);
            this.guna2Panel1.TabIndex = 6;
            // 
            // lblFind
            // 
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblFind.Location = new System.Drawing.Point(157, 124);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(530, 31);
            this.lblFind.TabIndex = 21;
            this.lblFind.Text = "Find contact to update its informations";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.FillColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(375, 360);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(95, 45);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find Contact";
            this.btnFind.Click += new System.EventHandler(this.btnFindContact_Click);
            // 
            // tbContactID
            // 
            this.tbContactID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContactID.DefaultText = "";
            this.tbContactID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbContactID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbContactID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContactID.DisabledState.Parent = this.tbContactID;
            this.tbContactID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContactID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContactID.FocusedState.Parent = this.tbContactID;
            this.tbContactID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContactID.HoverState.Parent = this.tbContactID;
            this.tbContactID.Location = new System.Drawing.Point(317, 300);
            this.tbContactID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContactID.Name = "tbContactID";
            this.tbContactID.PasswordChar = '\0';
            this.tbContactID.PlaceholderText = "";
            this.tbContactID.SelectedText = "";
            this.tbContactID.ShadowDecoration.Parent = this.tbContactID;
            this.tbContactID.Size = new System.Drawing.Size(211, 39);
            this.tbContactID.TabIndex = 11;
            this.tbContactID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbContactID_KeyDown);
            // 
            // lblInsertTitle
            // 
            this.lblInsertTitle.AutoSize = true;
            this.lblInsertTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblInsertTitle.Location = new System.Drawing.Point(349, 265);
            this.lblInsertTitle.Name = "lblInsertTitle";
            this.lblInsertTitle.Size = new System.Drawing.Size(144, 31);
            this.lblInsertTitle.TabIndex = 0;
            this.lblInsertTitle.Text = "Contact ID";
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(848, 639);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find";
            this.Text = "Find";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2TextBox tbContactID;
        private System.Windows.Forms.Label lblInsertTitle;
        private System.Windows.Forms.Label lblFind;
    }
}