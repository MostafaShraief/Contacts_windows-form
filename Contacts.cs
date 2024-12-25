using BusinessLayer;
using Contacts_WF.Contact_Section;
using Contacts_WF.Contact_Section.Delete_Contact;
using Contacts_WF.Country_Section;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        static internal void LoadForm(Form form, Panel panel)
        {
            if ((panel.Controls.Count == 0) || (form.Text != panel.Controls[0].Text))
            {
                if (panel.Controls.Count > 0)
                {
                    panel.Controls[0].Dispose();
                    panel.Controls.Clear();
                }

                panel.Enabled = true;
                if (form != null)
                {
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    panel.Controls.Add(form);
                    form.Show();
                }
            }
        }

        private void ShowContacts_Click(object sender, EventArgs e)
        {
            LoadForm(new Show_Contacts(), RightPanel);
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            LoadForm(new Save_Contact(), RightPanel);
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            LoadForm(new Save_Country(), RightPanel);
        }

        private void btnShowCountries_Click(object sender, EventArgs e)
        {
            LoadForm(new Show_Countries(), RightPanel);
        }

        internal static void LoadFindForm(bool IsDelete = false, bool IsCountry = false)
        {
            LoadForm(new Find(IsDelete, IsCountry), RightPanel);
        }

        internal static void btnUpdateContact_Click(object sender = null, EventArgs e = null)
        {
            LoadFindForm();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            LoadForm(new Delete_Main_Form(), RightPanel);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            LoadFindForm(false, true);
        }

        internal static void LoadUpdateContactForm(clsContact contact)
        {
            LoadForm(new Save_Contact(contact), RightPanel);
        }

        internal static void LoadUpdateCountryForm(clsCountry country)
        {
            LoadForm(new Save_Country(country), RightPanel);
        }

        internal static void LoadDeleteCountryForm(clsCountry country)
        {
            LoadForm(new Delete_Country(country), RightPanel);
        }
        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            LoadFindForm(true, true);
        }
    }
}
