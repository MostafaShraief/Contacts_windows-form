using BusinessLayer;
using Contacts_WF.Contact_Section;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF.Country_Section
{
    public partial class Save_Country : Form
    {
        clsCountry country;

        enum enMode { New, Existing }
        enMode _Mode = enMode.New;

        void FillFieldsByCountryInfo()
        {
            tbCountryName.Text = country.CountryName;
            tbCountryCode.Text = country.Code;
            tbPhoneCode.Text = country.PhoneCode;
        }

        void SwitchToUpdateForm()
        {
            btnAddCountry.Text = "Update";
            FillFieldsByCountryInfo();
        }

        public Save_Country(clsCountry country = null)
        {
            InitializeComponent();

            if (country != null)
            {
                this.country = country;
                _Mode = enMode.Existing;
                SwitchToUpdateForm();
            }
            else
                this.country = new clsCountry();
        }

        bool CheckCountryInfo()
        {
            bool IsOk = false;

            IsOk = (tbCountryName.Text != string.Empty) &&
                (tbCountryCode.Text != string.Empty) &&
                (tbPhoneCode.Text != string.Empty);

            return IsOk;
        }

        bool SaveCountry()
        {
            bool IsSaved = false;

            string Word = "save";

            if (_Mode == enMode.Existing)
                Word = "update";

            if (CheckCountryInfo())
            {
                country.CountryName = tbCountryName.Text;
                country.Code = tbCountryCode.Text;
                country.PhoneCode = tbPhoneCode.Text;

                IsSaved = country.Save();
                if (IsSaved)
                {
                    MessageBox.Show($"Country {Word}d successfuly.", $"{Word}d",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == enMode.Existing)
                        Contacts.LoadFindForm();
                }
                else
                    MessageBox.Show($"Failed to {Word} country," +
                        " please check your data entered and try again.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"Failed to {Word} country," +
                    " please check your data entered and try again.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return IsSaved;
        }

        void Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    if (SaveCountry())
                    {
                        SwitchToUpdateForm();
                        _Mode = enMode.Existing;
                    }
                    break;
                case enMode.Existing:
                    SaveCountry();
                    break;
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
