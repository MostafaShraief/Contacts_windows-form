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
    public partial class Show_Countries : Form
    {
        public Show_Countries()
        {
            InitializeComponent();
        }

        DataTable dt;

        void AddItemToListView(string ContactID, string CountryName,
            string CountryCode, string PhoneCode)
        {
            ListView.Items.Add(ContactID);

            int LastItemIndex = ListView.Items.Count - 1;

            ListView.Items[LastItemIndex].SubItems.Add(CountryName);
            ListView.Items[LastItemIndex].SubItems.Add(CountryCode);
            ListView.Items[LastItemIndex].SubItems.Add(PhoneCode);
        }

        void LoadCountries()
        {
            ListView.Items.Clear();

            dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                AddItemToListView(row["CountryID"].ToString(),
                    row["CountryName"].ToString(), row["Code"].ToString(),
                    row["PhoneCode"].ToString());
            }
        }

        private void Show_Countries_Load(object sender, EventArgs e)
        {
            LoadCountries();
        }

        enum enSearchMode { ID, Name };
        enSearchMode _SearchMode = enSearchMode.ID;

        void SwitchSearchMode(CheckBox checkBox)
        {
            textboxSearch.Text = string.Empty;
            if (checkBox == cbID)
            {
                cbName.Checked = false;
                _SearchMode = enSearchMode.ID;
            }
            else
            {
                cbID.Checked = false;
                _SearchMode = enSearchMode.Name;
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbID.Checked == cbName.Checked) &&
                (cbName.Checked == false))
            {
                (sender as CheckBox).Checked = true;
                return; // Ignore Uncheck Both Controls.
            }

            if ((sender as CheckBox).Checked)
                SwitchSearchMode((sender as CheckBox));
        }

        void SearchByID()
        {
            int CountryID;

            ListView.Items.Clear();

            if (int.TryParse(textboxSearch.Text, out CountryID))
            {
                clsCountry country = clsCountry.Find(CountryID);

                if (country != null)
                {
                    AddItemToListView(country.CountryID.ToString(), country.CountryName,
                        country.Code, country.PhoneCode);
                }
            }
        }

        void SearchByCountryName()
        {
            string CountryName = textboxSearch.Text;

            ListView.Items.Clear();

            clsCountry country = clsCountry.Find(CountryName);

            if (country != null)
            {
                AddItemToListView(country.CountryID.ToString(), country.CountryName,
                    country.Code, country.PhoneCode);
            }
        }

        void Search()
        {
            if (textboxSearch.Text != string.Empty)
            {
                switch (_SearchMode)
                {
                    case enSearchMode.ID:
                        SearchByID();
                        break;
                    case enSearchMode.Name:
                        SearchByCountryName();
                        break;
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
            LoadCountries();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void _EditCountry()
        {
            int CountryID;

            if (ListView.SelectedItems.Count > 0 && int.TryParse(ListView.SelectedItems[0].Text, out CountryID))
            {
                clsCountry country = clsCountry.Find(CountryID);

                if (country != null)
                    Contacts.LoadUpdateCountryForm(country);
                else
                {
                    MessageBox.Show("Country has no longer exist", "Country Not Found",
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
            _EditCountry();
        }

        void _DeleteCountry()
        {
            int CountryID;

            if (ListView.SelectedItems.Count > 0 && int.TryParse(ListView.SelectedItems[0].Text, out CountryID))
            {
                clsCountry Country = clsCountry.Find(CountryID);

                string Word = "delete";

                DialogResult result = MessageBox.Show($"Are you sure you want to {Word} this country?", $"Cofirm {Word}",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.OK)
                {
                    if (clsCountry.DeleteCountry(Country.CountryID))
                        MessageBox.Show($"Country {Word}d successfuly.", $"{Word}d",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Failed to {Word} country," +
                            " please check your data entered and try again.", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Seems an error occured while catching data", "Opps!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            Reset();
        }

        private void deletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteCountry();
        }
    }
}