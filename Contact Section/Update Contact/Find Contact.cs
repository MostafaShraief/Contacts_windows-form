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
using Contacts_WF.Contact_Section.Update_Contact;

namespace Contacts_WF.Contact_Section.Update_Contact
{
    public partial class Find_Contact : Form
    {
        public Find_Contact()
        {
            InitializeComponent();
        }

        void FindContact()
        {
            int ContactID;

            if (int.TryParse(tbContactID.Text, out ContactID))
            {
                if (clsContact.IsContactExist(ContactID))
                {
                    clsContact contact = clsContact.Find(ContactID);
                    Update_Main_Form.LoadUpdateForm(contact);
                }
                else
                    MessageBox.Show("Please enter existing contact ID.", "Contact Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Inter a valid number.", "Incorrect Insertion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            FindContact();
        }

        private void tbContactID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindContact();
        }
    }
}
