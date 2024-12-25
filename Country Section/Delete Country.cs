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

namespace Contacts_WF.Country_Section
{
    public partial class Delete_Country : Form
    {
        clsCountry country;

        void FillLabelsByCountryInfo()
        {
            lblCountryID.Text = this.country.CountryName;
            lblCountryCode.Text = this.country.Code;
            lblPhoneCode.Text = this.country.PhoneCode;
        }

        public Delete_Country(clsCountry country)
        {
            InitializeComponent();
            this.country = country;
            FillLabelsByCountryInfo();
        }

        void DeleteCountry()
        {
            string Word = "delete";

            DialogResult result = MessageBox.Show($"Are you sure you want to {Word} this country?", $"Cofirm {Word}",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                if (clsCountry.DeleteCountry(country.CountryID))
                    MessageBox.Show($"Country {Word}d successfuly.", $"{Word}d",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Failed to {Word} country," +
                        " please check your data entered and try again.", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Contacts.LoadFindForm(true, true);
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            DeleteCountry();
        }
    }
}
