using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_Branches : UserControl
    {
        public uc_Branches()
        {
            InitializeComponent();
        }

        private void uc_Branches_Load(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            sideNavBtnControl(btnUBrnViewAll);
            pnlUBrnFilter.Visible = false;
            dgv_Branches.DataSource = brndb.viewAllBranches();
        }

        private void sideNavPnlControl()
        {
            if(pnlUBrnFilter.Visible == true)
            {
                pnlUBrnFilter.Visible = false;
            }
            else if(pnlUBrnFilter.Visible == false)
            {
                pnlUBrnFilter.Visible = true;
            }
        }

        private void sideNavBtnControl(Button btn)
        {
            btnUBrnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUBrnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void setValues()
        {
            BranchesDB brndb = new BranchesDB();
            brndb.setBranchType(txtUBrnFilterBranchType.Text);
            brndb.setCity(txtUBrnFilterCity.Text);
            brndb.setRegion(cBoxUBrnFilterRegion.Text);
        }

        private void btnUBrnViewAll_Click(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            sideNavBtnControl(btnUBrnViewAll);
            pnlUBrnFilter.Visible = false;
            dgv_Branches.DataSource = brndb.viewAllBranches();
        }

        private void btnUBrnFilter_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnUBrnFilter);
            sideNavPnlControl();
        }

        private void btnUBrnFilterShow_Click(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            if(cBoxUBrnFilterRegion.Text.Equals("") && txtUBrnFilterCity.Text.Equals("") && txtUBrnFilterBranchType.Text.Equals(""))
            {
                MessageBox.Show("Please enter at least 1 fiter parameter");
            }
            else
            {
                setValues();
                dgv_Branches.DataSource = brndb.filterBranches();
            }
        }
    }
}
