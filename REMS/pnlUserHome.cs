using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class pnlUserHome : UserControl
    {
        public pnlUserHome()
        {
            InitializeComponent();
        }

        private void userNavControl(Button btn)
        {
            //Default Background color of buttons
            btnUserOccupant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserOnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserBranches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserHouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserContractors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            //Default font colors of buttons
            btnUserOccupant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserOnCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserProviders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserHouses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserContractors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            //Changing the apperance of the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
        }

        private void btnUserOccupant_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserOccupant);
            uc_OccupantInfo uc = new uc_OccupantInfo();
            userPnlControl(uc);
        }

        private void btnUserSold_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserSold);
            SoldHouses uc = new SoldHouses();
            userPnlControl(uc);

        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserClear);
            uc_ClearLot uc = new uc_ClearLot();
            userPnlControl(uc);
        }

        private void btnUserOnCon_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserOnCon);
            uc_OnConstruction uc = new uc_OnConstruction();
            userPnlControl(uc);
        }

        private void btnUserBranches_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserBranches);
            uc_Branches uc = new uc_Branches();
            userPnlControl(uc);
        }

        private void btnUserProviders_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserProviders);
            uc_ServiceProviders uc = new uc_ServiceProviders();
            userPnlControl(uc);
        }

        private void btnUserHouses_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserHouses);
            pnlHouses uc = new pnlHouses();
            userPnlControl(uc);
        }

        private void btnUserContractors_Click(object sender, EventArgs e)
        {
            userNavControl(btnUserContractors);
            uc_Contractors uc = new uc_Contractors();

            userPnlControl(uc);
        }

        private void userPnlControl(UserControl uc)
        {
            pnlUserContainer.Controls.Clear();
            pnlUserContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}
