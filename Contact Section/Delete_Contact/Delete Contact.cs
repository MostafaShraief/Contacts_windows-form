using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Contacts_WF.Contact_Section.Delete_Contact
{
    public partial class Delete_Contact : Form
    {
        clsContact contact;

        void FillLabelsByContactInfo()
        {
            lblContactID.Text = contact.ContactID.ToString();
            lblFirstName.Text = contact.FirstName;
            lblLastName.Text = contact.LastName;
            lblEmail.Text = contact.Email;
            lblPhone.Text = contact.Phone;
            lblAddress.Text = contact.Address;
            lblDateOfBirth.Text = contact.DateOfBirth.ToString();
            clsCountry country = clsCountry.Find(contact.CountryID);
            lblCountry.Text = country.CountryName;

            if (contact.ImagePath != string.Empty)
                lblImagePath.Text = contact.ImagePath;
            else
                lblImagePath.Text = "None";
        }

        public Delete_Contact(clsContact contact)
        {
            InitializeComponent();
            this.contact = contact;
            FillLabelsByContactInfo();
        }

        void DeleteContact()
        {
            string Word = "delete";

            DialogResult result = MessageBox.Show($"Are you sure you want to {Word} this contact?", $"Cofirm {Word}",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                if (clsContact.DeleteContact(contact.ContactID))
                    MessageBox.Show($"Contact {Word}d successfuly.", $"{Word}d",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Failed to {Word} contact," +
                        " please check your data entered and try again.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Delete_Main_Form.LoadFindForm();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }
    }
}
