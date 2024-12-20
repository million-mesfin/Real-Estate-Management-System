using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_Contractors : UserControl
    {
        public uc_Contractors()
        {
            InitializeComponent();
        }

        private void sideNavBtnControl(Button btn)
        {
            btnUConViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUConSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void sideNavPnlControl()
        {
            if(pnlUConSearch.Visible == false)
            {
                pnlUConSearch.Visible = true;
            }
            else
            {
                pnlUConSearch.Visible = false;
            }
        }

        private void btnUConViewAll_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnUConViewAll);
            pnlUConSearch.Visible = false;
            ContractorDB condb = new ContractorDB();
            dgv_Contractors.DataSource =  condb.viewAllContractors();
        }

        private void btnUConSearch_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnUConSearch);
            sideNavPnlControl();
        }

        private void rb_UConByName_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_UConByName.Checked == true)
            {
                rb_UConByPhone.Checked = false;
            }
        }

        private void rb_UConByPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_UConByPhone.Checked == true)
            {
                rb_UConByName.Checked = false;
            }
        }

        private void setValues()
        {
            ContractorDB condb = new ContractorDB();
            if (!txtUConSearch.Text.Equals(""))
            {
                if (rb_UConByName.Checked == true)
                {
                    condb.setName(txtUConSearch.Text);
                }
                else if (rb_UConByPhone.Checked == true)
                {
                    condb.setPhone(txtUConSearch.Text);
                }
                else
                {
                    MessageBox.Show("Please select one of the searching options");
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term first");
            }
        }

        private void btnUConSearchShow_Click(object sender, EventArgs e)
        {
            setValues();
            ContractorDB condb = new ContractorDB();
            dgv_Contractors.DataSource = condb.searchContractors();
        }
    }
}
