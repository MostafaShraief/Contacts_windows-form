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

namespace Contacts_WF.Country_Section
{
    public partial class Add_Country : Form
    {
        public Add_Country()
        {
            InitializeComponent();
        }

        bool CheckCountryInfo()
        {
            bool IsOk = false;

            IsOk = (tbCountryName.Text != string.Empty) &&
                (tbCountryCode.Text != string.Empty) &&
                (tbPhoneCode.Text != string.Empty);

            return IsOk;
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (CheckCountryInfo())
            {
                clsCountry country = new clsCountry();

                country.CountryName = tbCountryName.Text;
                country.Code = tbCountryCode.Text;
                country.PhoneCode = tbPhoneCode.Text;

                if (country.Save())
                    MessageBox.Show("Country saved successfuly.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to save country," +
                        " please check your data entered and try again.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Failed to save country," +
                    " please check your data entered and try again.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
