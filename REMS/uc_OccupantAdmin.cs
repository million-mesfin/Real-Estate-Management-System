using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_OccupantAdmin : UserControl
    {
        public uc_OccupantAdmin()
        {
            InitializeComponent();
        }

        private void uc_OccupantAdmin_Load(object sender, EventArgs e)
        {
            OccupantDB otiDB = new OccupantDB();
            dgv_Occupants.DataSource = otiDB.viewAllOccupants();
        }

        private void btnAOtiFilterShow_Click(object sender, EventArgs e)
        {
            OccupantDB otiDB = new OccupantDB();

            if (cBoxAOtiFilter.Text == null)
            {
                MessageBox.Show("Please select a house type");
            }
            else
            {
                string houseType = cBoxAOtiFilter.Text;

                otiDB.setHouseType(houseType);
                dgv_Occupants.DataSource = otiDB.fiterOnHouseType();
                otiDB.setHouseType(houseType);
            }
        }

        private void sideNavControl(Button btn)
        {
            btnAOtiSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAOtiViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAOtiFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAOtiModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            //Change the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void btnAOtiSearch_Click(object sender, EventArgs e)
        {
            sideNavControl(btnAOtiSearch);
            sidePnlControl();
            if (pnlAOtiSearch.Visible == true)
            {
                pnlAOtiSearch.Visible = false;
            }
            else
                pnlAOtiSearch.Visible = true;
        }

        private void sidePnlControl()
        {
            pnlAOtiSearch.Visible = false;
            pnlAOtiFilter.Visible = false;
            pnlAOtiModify.Visible = false;
        }

        private void btnAOtiFilter_Click(object sender, EventArgs e)
        {
            sideNavControl(btnAOtiFilter);
            sidePnlControl();

            if (pnlAOtiFilter.Visible == true)
                pnlAOtiFilter.Visible = false;
            else
                pnlAOtiFilter.Visible = true;
        }

        private void btnAOtiViewAll_Click(object sender, EventArgs e)
        {
            sidePnlControl();
            OccupantDB otiDB = new OccupantDB();
            dgv_Occupants.DataSource = otiDB.viewAllOccupants();
            sideNavControl(btnAOtiViewAll);
        }

        private void btnAOtiSearchShow_Click(object sender, EventArgs e)
        {
            OccupantDB otidb = new OccupantDB();
            if (rb_AOtiByName.Checked == true)
            {
                otidb.setName(txtAOtiSearch.Text);
                dgv_Occupants.DataSource = otidb.searchByName();
            }
            else if (rb_AOtiByPhone.Checked == true)
            {
                otidb.setPhone(txtAOtiSearch.Text);
                dgv_Occupants.DataSource = otidb.searchByPhone();
            }
            else
            {
                MessageBox.Show("Please select one search option");
            }
        }

        private void rb_AOtiByName_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AOtiByName.Checked == true)
            {
                rb_AOtiByPhone.Checked = false;
            }
        }

        private void rb_AOtiByPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AOtiByPhone.Checked == true)
            {
                rb_AOtiByName.Checked = false;
            }
        }

        private void btnAOtiModify_Click(object sender, EventArgs e)
        {
            sideNavControl(btnAOtiModify);
            sidePnlControl();
            pnlAOtiModify.Visible = true;
        }

        private void btnAOtiAddOccupant_Click(object sender, EventArgs e)
        {
            uc_AddOccupant uc = new uc_AddOccupant();
            pnlAOtiContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnAOtiEditInfo_Click(object sender, EventArgs e)
        {
            uc_EditOccupantInfo uc = new uc_EditOccupantInfo();
            pnlAOtiContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnAOtiDeleteInfo_Click(object sender, EventArgs e)
        {
            uc_DeleteOccupantInfo uc = new uc_DeleteOccupantInfo();
            pnlAOtiContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
