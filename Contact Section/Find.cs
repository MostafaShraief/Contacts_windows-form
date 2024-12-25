using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contacts_WF.Contact_Section;
using Contacts_WF.Contact_Section.Delete_Contact;

namespace Contacts_WF.Contact_Section
{
    public partial class Find : Form
    {
        enum enMode { Contact, Country };
        enMode _Mode = enMode.Contact;

        bool IsDelete;

        void SwitchToCountrySearchMode()
        {
            lblFind.Text = lblFind.Text.Replace("contact", "country");
            lblInsertTitle.Text = lblInsertTitle.Text.Replace("Contact", "Country");
            btnFind.Text = btnFind.Text.Replace("Contact", "Country");
        }

        public Find(bool IsDelete = false, bool IsCountry = false)
        {
            InitializeComponent();

            // this is nececery to be able change between :
            // ((delete & update) (contact & coutnry)).
            this.Text += IsDelete.ToString() + IsCountry.ToString();

            this.IsDelete = IsDelete;
            if (IsDelete)
                lblFind.Text = lblFind.Text.Replace("update", "delete");

            if (IsCountry)
            {
                _Mode = enMode.Country;
                SwitchToCountrySearchMode();
            }
        }

        void _FindCountry(int CountryID)
        {
            if (clsCountry.IsCountryExist(CountryID))
            {
                clsCountry country = clsCountry.Find(CountryID);
                if (IsDelete)
                    Contacts.LoadDeleteCountryForm(country);
                else
                    Contacts.LoadUpdateCountryForm(country);
            }
            else
                MessageBox.Show("Please enter existing country ID.", "Country Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void _FindContact(int ContactID)
        {
            if (clsContact.IsContactExist(ContactID))
            {
                clsContact contact = clsContact.Find(ContactID);
                if (IsDelete)
                    Delete_Main_Form.LoadDeleteForm(contact);
                else
                    Contacts.LoadUpdateContactForm(contact);
            }
            else
                MessageBox.Show("Please enter existing contact ID.", "Contact Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void _Find()
        {
            int ID;

            if (int.TryParse(tbContactID.Text, out ID))
            {
                if (_Mode == enMode.Contact)
                    _FindContact(ID);
                else
                    _FindCountry(ID);
            }
            else
                MessageBox.Show("Inter a valid number.", "Incorrect Insertion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            _Find();
        }

        private void tbContactID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _Find();
        }
    }
}
