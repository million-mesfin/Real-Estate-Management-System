using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_BranchesAdmin : UserControl
    {
        public uc_BranchesAdmin()
        {
            InitializeComponent();
        }

        private void uc_BranchesAdmin_Load(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            sideNavBtnControl(btnABrnViewAll);
            pnlABrnFilter.Visible = false;
            dgv_Branches.DataSource = brndb.viewAllBranches();
        }

        private void sideNavPnlControl()
        {
            if (pnlABrnFilter.Visible == true)
            {
                pnlABrnFilter.Visible = false;
            }
            else if (pnlABrnFilter.Visible == false)
            {
                pnlABrnFilter.Visible = true;
            }
        }

        private void sideNavBtnControl(Button btn)
        {
            btnABrnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnABrnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnABrnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }
        private void setValues()
        {
            BranchesDB brndb = new BranchesDB();
            brndb.setBranchType(txtABrnFilterBranchType.Text);
            brndb.setCity(txtABrnFilterCity.Text);
            brndb.setRegion(cBoxABrnFilterRegion.Text);
        }

        private void btnABrnViewAll_Click(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            sideNavBtnControl(btnABrnViewAll);
            pnlABrnFilter.Visible = false;
            pnlABrnModify.Visible = false;
            dgv_Branches.DataSource = brndb.viewAllBranches();
        }

        private void btnABrnFilter_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnABrnFilter);
            sideNavPnlControl();
        }

        private void btnABrnFilterShow_Click(object sender, EventArgs e)
        {
            BranchesDB brndb = new BranchesDB();
            if (cBoxABrnFilterRegion.Text.Equals("") && txtABrnFilterCity.Text.Equals("") && txtABrnFilterBranchType.Text.Equals(""))
            {
                MessageBox.Show("Please enter at least 1 fiter parameter");
            }
            else
            {
                setValues();
                dgv_Branches.DataSource = brndb.filterBranches();
            }
        }

        private void btnABrnModify_Click(object sender, EventArgs e)
        {
            pnlABrnFilter.Visible = false;

            if (pnlABrnModify.Visible == false)
                pnlABrnModify.Visible = true;
            else
                pnlABrnModify.Visible = false;
        }

        private void btnABrnAdd_Click(object sender, EventArgs e)
        {
            uc_AddBranch uc = new uc_AddBranch();
            pnlBranchContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnABrnEdit_Click(object sender, EventArgs e)
        {
            uc_EditBranch uc = new uc_EditBranch();
            pnlBranchContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnABrnDelete_Click(object sender, EventArgs e)
        {
            uc_DeleteBranch uc = new uc_DeleteBranch();
            pnlBranchContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
