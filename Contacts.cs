using Contacts_WF.Contact_Section;
using Contacts_WF.Contact_Section.Update_Contact;
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

        private void LoadForm(Form form, Panel panel)
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
            LoadForm(new Add_Country(), RightPanel);
        }

        private void btnShowCountries_Click(object sender, EventArgs e)
        {
            LoadForm(new Show_Countries(), RightPanel);
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            LoadForm(new Update_Main_Form(), RightPanel);
        }
    }
}
