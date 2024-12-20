using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class pnlAdminHome : UserControl
    {
        public pnlAdminHome()
        {
            InitializeComponent();
        }

        private void btnAdminHouses_Click(object sender, EventArgs e)
        {
            uc_HousesAdmin uc = new uc_HousesAdmin();
            containerControl(uc);
            adminNavControl(btnAdminHouses);
        }

        private void containerControl(UserControl uc)
        {
            pnlAdminContainer.Controls.Clear();
            pnlAdminContainer.Controls.Add(uc);
        }

        private void pnlAdminHome_Load(object sender, EventArgs e)
        {
            uc_HousesAdmin uc = new uc_HousesAdmin();
            containerControl(uc);
        }

        private void adminNavControl(Button btn)
        {
            //Default Background color of buttons
            btnAdminOccupant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminOnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminBranches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminHouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminContractors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            //Default font colors of buttons
            btnAdminOccupant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminOnCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminProviders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminHouses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminContractors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnAdminAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));

            //Changing the apperance of the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
        }

        private void btnAdminOccupant_Click(object sender, EventArgs e)
        {
            uc_OccupantAdmin uc = new uc_OccupantAdmin();
            containerControl(uc);
            adminNavControl(btnAdminOccupant);
        }

        private void btnAdminSold_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminSold);
            uc_OccupiedAdmin uc = new uc_OccupiedAdmin();
            containerControl(uc);
        }

        private void btnAdminClear_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminClear);
            uc_ClearLotAdmin uc = new uc_ClearLotAdmin();
            containerControl(uc);
        }

        private void btnAdminOnCon_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminOnCon);
        }

        private void btnAdminBranches_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminBranches);
            uc_BranchesAdmin uc = new uc_BranchesAdmin();
            containerControl(uc);
        }

        private void btnAdminProviders_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminProviders);
        }

        private void btnAdminContractors_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminContractors);
        }

        private void btnAdminAccount_Click(object sender, EventArgs e)
        {
            adminNavControl(btnAdminAccount);
            uc_Accounts uc = new uc_Accounts();
            containerControl(uc);

        }
    }
}
