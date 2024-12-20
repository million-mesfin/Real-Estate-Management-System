using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_ServiceProviders : UserControl
    {
        public uc_ServiceProviders()
        {
            InitializeComponent();
        }

        private void sideNavPnlControl(Panel pnl)
        {
            if(pnl.Visible == true)
            {
                pnl.Visible = false;
            }
            else if(pnl.Visible == false)
            {
                pnl.Visible = true;
            }
        }

        private void sideNavBtnControl(Button btn)
        {
            btnUSpViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUSpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUSpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void uc_ServiceProviders_Load(object sender, EventArgs e)
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            sideNavBtnControl(btnUSpViewAll);
            pnlUSpSearch.Visible = false;
            pnlUSpFilter.Visible = false;
            dgv_ServiceProviders.DataSource = spdb.viewAllProviders();
        }

        private void btnUSpViewAll_Click(object sender, EventArgs e)
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            sideNavBtnControl(btnUSpViewAll);
            pnlUSpSearch.Visible = false;
            pnlUSpFilter.Visible = false;
            dgv_ServiceProviders.DataSource = spdb.viewAllProviders();
        }

        private void btnUSpSearch_Click(object sender, EventArgs e)
        {
            sideNavPnlControl(pnlUSpSearch);
            sideNavBtnControl(btnUSpSearch);
            pnlUSpFilter.Visible = false;
        }

        private void btnUSpFilter_Click(object sender, EventArgs e)
        {
            sideNavPnlControl(pnlUSpFilter);
            sideNavBtnControl(btnUSpFilter);
            pnlUSpSearch.Visible = false;
        }

        private void rb_USpSearchName_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_USpSearchName.Checked == true)
            {
                rb_USpSearchByPhone.Checked = false;
            }
        }

        private void rb_USpSearchByPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_USpSearchByPhone.Checked == true)
            {
                rb_USpSearchName.Checked = false;
            }
        }

        private void btnUSpSearchShow_Click(object sender, EventArgs e)
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            setSearchValues();
            if (rb_USpSearchName.Checked == true) 
            {
                dgv_ServiceProviders.DataSource = spdb.searchProviderByName();
            }
            else if (rb_USpSearchByPhone.Checked == true)
            {
                dgv_ServiceProviders.DataSource = spdb.searchProviderByPhone();
            }
            else
            {
                MessageBox.Show("Please select 1 search option");
            }
        }

        private void btnUSpFilterShow_Click(object sender, EventArgs e)
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            setFilterValues();
            dgv_ServiceProviders.DataSource = spdb.filterProvider();
        }

        private void setSearchValues()
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            if (rb_USpSearchName.Checked == true)
            {
                if (txtUSpSearch.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a search term first.");
                }
                else
                {
                    spdb.setName(txtUSpSearch.Text);
                }
            }
            else if (rb_USpSearchByPhone.Checked == true)
            {
                if (rb_USpSearchByPhone.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a search term");
                }
                else
                {
                    spdb.setPhone(rb_USpSearchByPhone.Text);
                }
            }
        }

        private void setFilterValues()
        {
            ServiceProviderDB spdb = new ServiceProviderDB();
            if (cBoxUSpFilterRegion.Text.Equals("") && txtUSpFilterCity.Text.Equals("") && txtUSpFilterServiceType.Text.Equals(""))
            {
                MessageBox.Show("Please enter at least 1 filter parameter");
            }
            else
            {
                spdb.setRegion(cBoxUSpFilterRegion.Text);
                spdb.setCity(txtUSpFilterCity.Text);
                spdb.setServiceType(txtUSpFilterServiceType.Text);
            }
        }
    }
}
