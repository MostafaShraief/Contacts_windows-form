namespace Contacts_WF
{
    partial class Contacts
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
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowContacts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddContact = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateContact = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteContact = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowCountries = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCountry = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCountry = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCountry = new Guna.UI2.WinForms.Guna2Button();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.foreverTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.foreverTabPage1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.RightPanel);
            this.splitContainer.Size = new System.Drawing.Size(1095, 639);
            this.splitContainer.SplitterDistance = 246;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverTabPage1.Controls.Add(this.tabPage1);
            this.foreverTabPage1.Controls.Add(this.tabPage2);
            this.foreverTabPage1.DeactiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreverTabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverTabPage1.ItemSize = new System.Drawing.Size(120, 40);
            this.foreverTabPage1.Location = new System.Drawing.Point(0, 0);
            this.foreverTabPage1.Name = "foreverTabPage1";
            this.foreverTabPage1.SelectedIndex = 0;
            this.foreverTabPage1.Size = new System.Drawing.Size(246, 639);
            this.foreverTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.foreverTabPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(238, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnShowContacts);
            this.flowLayoutPanel1.Controls.Add(this.btnAddContact);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateContact);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteContact);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 585);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnShowContacts
            // 
            this.btnShowContacts.CheckedState.Parent = this.btnShowContacts;
            this.btnShowContacts.CustomImages.Parent = this.btnShowContacts;
            this.btnShowContacts.FillColor = System.Drawing.Color.Gray;
            this.btnShowContacts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowContacts.ForeColor = System.Drawing.Color.White;
            this.btnShowContacts.HoverState.Parent = this.btnShowContacts;
            this.btnShowContacts.Location = new System.Drawing.Point(3, 3);
            this.btnShowContacts.Name = "btnShowContacts";
            this.btnShowContacts.ShadowDecoration.Parent = this.btnShowContacts;
            this.btnShowContacts.Size = new System.Drawing.Size(230, 82);
            this.btnShowContacts.TabIndex = 0;
            this.btnShowContacts.Text = "Show Contacts";
            this.btnShowContacts.Click += new System.EventHandler(this.ShowContacts_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.CheckedState.Parent = this.btnAddContact;
            this.btnAddContact.CustomImages.Parent = this.btnAddContact;
            this.btnAddContact.FillColor = System.Drawing.Color.Gray;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.HoverState.Parent = this.btnAddContact;
            this.btnAddContact.Location = new System.Drawing.Point(3, 91);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.ShadowDecoration.Parent = this.btnAddContact;
            this.btnAddContact.Size = new System.Drawing.Size(230, 82);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.CheckedState.Parent = this.btnUpdateContact;
            this.btnUpdateContact.CustomImages.Parent = this.btnUpdateContact;
            this.btnUpdateContact.FillColor = System.Drawing.Color.Gray;
            this.btnUpdateContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateContact.ForeColor = System.Drawing.Color.White;
            this.btnUpdateContact.HoverState.Parent = this.btnUpdateContact;
            this.btnUpdateContact.Location = new System.Drawing.Point(3, 179);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.ShadowDecoration.Parent = this.btnUpdateContact;
            this.btnUpdateContact.Size = new System.Drawing.Size(230, 82);
            this.btnUpdateContact.TabIndex = 3;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.CheckedState.Parent = this.btnDeleteContact;
            this.btnDeleteContact.CustomImages.Parent = this.btnDeleteContact;
            this.btnDeleteContact.FillColor = System.Drawing.Color.Gray;
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteContact.ForeColor = System.Drawing.Color.White;
            this.btnDeleteContact.HoverState.Parent = this.btnDeleteContact;
            this.btnDeleteContact.Location = new System.Drawing.Point(3, 267);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.ShadowDecoration.Parent = this.btnDeleteContact;
            this.btnDeleteContact.Size = new System.Drawing.Size(230, 82);
            this.btnDeleteContact.TabIndex = 4;
            this.btnDeleteContact.Text = "Delete Contact";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(238, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Countries";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnShowCountries);
            this.flowLayoutPanel2.Controls.Add(this.btnAddCountry);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdateCountry);
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteCountry);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(232, 585);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnShowCountries
            // 
            this.btnShowCountries.CheckedState.Parent = this.btnShowCountries;
            this.btnShowCountries.CustomImages.Parent = this.btnShowCountries;
            this.btnShowCountries.FillColor = System.Drawing.Color.Gray;
            this.btnShowCountries.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowCountries.ForeColor = System.Drawing.Color.White;
            this.btnShowCountries.HoverState.Parent = this.btnShowCountries;
            this.btnShowCountries.Location = new System.Drawing.Point(3, 3);
            this.btnShowCountries.Name = "btnShowCountries";
            this.btnShowCountries.ShadowDecoration.Parent = this.btnShowCountries;
            this.btnShowCountries.Size = new System.Drawing.Size(230, 82);
            this.btnShowCountries.TabIndex = 0;
            this.btnShowCountries.Text = "Show Counties";
            this.btnShowCountries.Click += new System.EventHandler(this.btnShowCountries_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.CheckedState.Parent = this.btnAddCountry;
            this.btnAddCountry.CustomImages.Parent = this.btnAddCountry;
            this.btnAddCountry.FillColor = System.Drawing.Color.Gray;
            this.btnAddCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCountry.ForeColor = System.Drawing.Color.White;
            this.btnAddCountry.HoverState.Parent = this.btnAddCountry;
            this.btnAddCountry.Location = new System.Drawing.Point(3, 91);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.ShadowDecoration.Parent = this.btnAddCountry;
            this.btnAddCountry.Size = new System.Drawing.Size(230, 82);
            this.btnAddCountry.TabIndex = 1;
            this.btnAddCountry.Text = "Add Country";
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.CheckedState.Parent = this.btnUpdateCountry;
            this.btnUpdateCountry.CustomImages.Parent = this.btnUpdateCountry;
            this.btnUpdateCountry.FillColor = System.Drawing.Color.Gray;
            this.btnUpdateCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateCountry.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCountry.HoverState.Parent = this.btnUpdateCountry;
            this.btnUpdateCountry.Location = new System.Drawing.Point(3, 179);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.ShadowDecoration.Parent = this.btnUpdateCountry;
            this.btnUpdateCountry.Size = new System.Drawing.Size(230, 82);
            this.btnUpdateCountry.TabIndex = 3;
            this.btnUpdateCountry.Text = "Update Country";
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.CheckedState.Parent = this.btnDeleteCountry;
            this.btnDeleteCountry.CustomImages.Parent = this.btnDeleteCountry;
            this.btnDeleteCountry.FillColor = System.Drawing.Color.Gray;
            this.btnDeleteCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCountry.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCountry.HoverState.Parent = this.btnDeleteCountry;
            this.btnDeleteCountry.Location = new System.Drawing.Point(3, 267);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.ShadowDecoration.Parent = this.btnDeleteCountry;
            this.btnDeleteCountry.Size = new System.Drawing.Size(230, 82);
            this.btnDeleteCountry.TabIndex = 4;
            this.btnDeleteCountry.Text = "Delete Country";
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(848, 639);
            this.RightPanel.TabIndex = 0;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 639);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.foreverTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnShowContacts;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnAddContact;
        private Guna.UI2.WinForms.Guna2Button btnUpdateContact;
        private Guna.UI2.WinForms.Guna2Button btnDeleteContact;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnShowCountries;
        private Guna.UI2.WinForms.Guna2Button btnAddCountry;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCountry;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCountry;
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
    }
}

