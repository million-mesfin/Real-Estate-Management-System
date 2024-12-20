using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_OccupantInfo : UserControl
    {
        public uc_OccupantInfo()
        {
            InitializeComponent();
        }

        private void uc_OccupantInfo_Load(object sender, EventArgs e)
        {
            OccupantDB otiDB = new OccupantDB();
            dgv_Occupants.DataSource = otiDB.viewAllOccupants();
        }

        private void btnUOtiFilterShow_Click(object sender, EventArgs e)
        {
            OccupantDB otiDB = new OccupantDB();

            if(cBoxUOtiFilter.Text == null)
            {
                MessageBox.Show("Please select a house type");
            }
            else
            {
                string houseType = cBoxUOtiFilter.Text;

                otiDB.setHouseType(houseType);
                dgv_Occupants.DataSource = otiDB.fiterOnHouseType();
                otiDB.setHouseType(houseType);
            }
        }

        private void sideNavControl(Button btn)
        {
            btnUOtiSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUOtiViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUOtiFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            //Change the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void btnUOtiSearch_Click(object sender, EventArgs e)
        {
            sideNavControl(btnUOtiSearch);
            sidePnlControl();
            if (pnlUOtiSearch.Visible == true)
                pnlUOtiSearch.Visible = false;
            else
                pnlUOtiSearch.Visible = true; 
        }

        private void btnUOtiFilter_Click(object sender, EventArgs e)
        {
            sideNavControl(btnUOtiFilter);
            sidePnlControl();

            if (pnlUOtiFilter.Visible == true)
                pnlUOtiFilter.Visible = false;
            else
                pnlUOtiFilter.Visible = true;
        }

        private void btnUOtiViewAll_Click(object sender, EventArgs e)
        {
            sidePnlControl();
            OccupantDB otiDB = new OccupantDB();
            dgv_Occupants.DataSource = otiDB.viewAllOccupants();
            sideNavControl(btnUOtiViewAll);
        }

        private void btnUOtiSearchShow_Click(object sender, EventArgs e)
        {
            OccupantDB otidb = new OccupantDB();
            if(rb_UOtiByName.Checked == true)
            {
                otidb.setName(txtUOtiSearch.Text);
                dgv_Occupants.DataSource = otidb.searchByName();
            }
            else if (rb_UOtiByPhone.Checked == true)
            {
                otidb.setPhone(txtUOtiSearch.Text);
                dgv_Occupants.DataSource = otidb.searchByPhone();
            }
            else
            {
                MessageBox.Show("Please select one search option");
            }
        }

        private void sidePnlControl()
        {
            pnlUOtiSearch.Visible = false;
            pnlUOtiFilter.Visible = false;
        }

        private void rb_UOtiByName_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_UOtiByName.Checked == true)
            {
                rb_UOtiByPhone.Checked = false;
            }
        }

        private void rb_UOtiByPhone_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_UOtiByPhone.Checked == true)
            {
                rb_UOtiByName.Checked = false;
            }
        }
    }
}
