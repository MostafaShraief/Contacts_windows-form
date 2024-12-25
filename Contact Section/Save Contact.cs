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
    public partial class Save_Contact : Form
    {
        clsContact contact;
        enum enMode { New, Existing }
        enMode _Mode = enMode.New;

        void FillFieldsByContactInfo()
        {
            tbFirstName.Text = contact.FirstName;
            tbLastName.Text = contact.LastName;
            tbAddress.Text = contact.Address;
            tbEmail.Text = contact.Email;
            mtbPhone.Text = contact.Phone;
            dtbDateOfBirth.Value = contact.DateOfBirth;
            clsCountry country = clsCountry.Find(contact.CountryID);
            cbCountry.SelectedItem = country.CountryName;
        }

        void SwitchToUpdateForm()
        {
            btnAddContact.Text = "Update";
            FillFieldsByContactInfo();
        }

        public Save_Contact(clsContact contact = null)
        {
            InitializeComponent();
            LoadCountries();

            if (contact != null )
            {
                this.contact = contact;
                _Mode = enMode.Existing;
                SwitchToUpdateForm();
            }
            else
                this.contact = new clsContact();
        }

        void LoadCountries()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
                cbCountry.Items.Add(row["CountryName"]);
        }

        void CorrectDateOfBirth()
        {
            if (dtbDateOfBirth.Value > (DateTime.Now - TimeSpan.FromDays(365)))
                dtbDateOfBirth.Value = (DateTime.Now - TimeSpan.FromDays(365));
        }

        private void Add_Contact_Load(object sender, EventArgs e)
        {
            CorrectDateOfBirth();
        }

        bool CheckContactInfo()
        {
            bool IsOk = false;

            IsOk = (cbCountry.SelectedIndex != -1) &&
                (tbFirstName.Text != string.Empty) &&
                (tbLastName.Text != string.Empty) &&
                (tbEmail.Text != string.Empty) &&
                (tbAddress.Text != string.Empty) &&
                (mtbPhone.Text != string.Empty);

            return IsOk;
        }

        bool SaveContact()
        {
            bool IsSaved = false;

            string Word = "save";

            if (_Mode == enMode.Existing)
                Word = "update";

            if (CheckContactInfo())
            {
                contact.FirstName = tbFirstName.Text;
                contact.LastName = tbLastName.Text;
                contact.Email = tbEmail.Text;
                contact.Address = tbAddress.Text;
                contact.Phone = mtbPhone.Text;
                contact.DateOfBirth = dtbDateOfBirth.Value;
                clsCountry country = clsCountry.Find(cbCountry.SelectedItem.ToString());
                contact.CountryID = country.CountryID;
                contact.ImagePath = null;

                IsSaved = contact.Save();
                if (IsSaved)
                {
                    MessageBox.Show($"Contact {Word}d successfuly.", $"{Word}d",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == enMode.Existing)
                        Contacts.LoadFindForm();
                }
                else
                    MessageBox.Show($"Failed to {Word} contact," +
                        " please check your data entered and try again.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"Failed to {Word} contact," +
                    " please check your data entered and try again.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return IsSaved;
        }

        void Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    if (SaveContact())
                    {
                        SwitchToUpdateForm();
                        _Mode = enMode.Existing;
                    }
                    break;
                case enMode.Existing:
                    SaveContact();
                    break;
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void dtbDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            CorrectDateOfBirth();
        }
    }
}
