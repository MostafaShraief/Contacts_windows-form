using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF.Contact_Section.Update_Contact
{
    public partial class Update_Main_Form : Form
    {
        public Update_Main_Form()
        {
            InitializeComponent();
        }

        private static void LoadForm(Form form, Guna2Panel panel)
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

        private void Update_Main_Form_Load(object sender, EventArgs e)
        {
            LoadForm(new Find_Contact(), MainPanel);
        }

        internal static void LoadUpdateForm(clsContact contact)
        {
            LoadForm(new Save_Contact(contact), MainPanel);
        }
    }
}
