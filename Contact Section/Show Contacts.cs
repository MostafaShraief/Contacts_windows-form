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
using Contacts_WF.Contact_Section;

namespace Contacts_WF.Contact_Section
{
    public partial class Show_Contacts : Form
    {
        public Show_Contacts()
        {
            InitializeComponent();
        }

        DataTable dt;

        void AddItemToListView(string ContactID, string FirstName,
            string LastName, string Email, string Phone, string Address,
            string DateOfBirth, string CountryID, string ImagePath)
        {
            ListView.Items.Add(ContactID);

            int LastItemIndex = ListView.Items.Count - 1;

            ListView.Items[LastItemIndex].SubItems.Add(FirstName);
            ListView.Items[LastItemIndex].SubItems.Add(LastName);
            ListView.Items[LastItemIndex].SubItems.Add(Email);
            ListView.Items[LastItemIndex].SubItems.Add(Phone);
            ListView.Items[LastItemIndex].SubItems.Add(Address);
            ListView.Items[LastItemIndex].SubItems.Add(DateOfBirth);
            ListView.Items[LastItemIndex].SubItems.Add(CountryID);
            ListView.Items[LastItemIndex].SubItems.Add(ImagePath);
        }

        void LoadContacts()
        {
            ListView.Items.Clear();

            dt = clsContact.GetAllContacts();

            foreach (DataRow row in dt.Rows)
            {
                AddItemToListView(row["ContactID"].ToString(),
                    row["FirstName"].ToString(), row["LastName"].ToString(),
                    row["Email"].ToString(), row["Phone"].ToString(),
                    row["Address"].ToString(), row["DateOfBirth"].ToString(),
                    row["CountryID"].ToString(), row["ImagePath"].ToString());
            }
        }

        private void Show_Contacts_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        void Search()
        {
            if (textboxSearch.Text != string.Empty)
            {
                int ContactID;

                ListView.Items.Clear();

                if (int.TryParse(textboxSearch.Text, out ContactID))
                {
                    clsContact contact = clsContact.Find(ContactID);

                    if (contact != null)
                    {
                        AddItemToListView(contact.ContactID.ToString(), contact.FirstName,
                            contact.LastName, contact.Email, contact.Phone,
                            contact.Address, contact.DateOfBirth.ToString(), contact.CountryID.ToString(),
                            contact.ImagePath);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        void Reset()
        {
            textboxSearch.Text = string.Empty;
            LoadContacts();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
            else if (e.KeyCode == Keys.Escape)
            {
                Reset();
                ListView.Focus();
            }
        }

        void _EditContact()
        {
            int ContactID;

            if (ListView.SelectedItems.Count > 0 && int.TryParse(ListView.SelectedItems[0].Text, out ContactID))
            {
                clsContact contact = clsContact.Find(ContactID);

                if (contact != null)
                    Contacts.LoadUpdateContactForm(contact);
                else
                {
                    MessageBox.Show("Contact has no longer exist", "Contact Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Reset();
                }
            }
            else
                MessageBox.Show("Seems an error occured while catching data", "Opps!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditContact();
        }

        void _DeleteContact()
        {
            int ContactID;

            if (ListView.SelectedItems.Count > 0 && int.TryParse(ListView.SelectedItems[0].Text, out ContactID))
            {
                clsContact contact = clsContact.Find(ContactID);

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
            }
            else
                MessageBox.Show("Seems an error occured while catching data", "Opps!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            Reset();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteContact();
        }
    }
}
