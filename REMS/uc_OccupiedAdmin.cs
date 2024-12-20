using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_OccupiedAdmin : UserControl
    {
        public uc_OccupiedAdmin()
        {
            InitializeComponent();
        }

        private void uc_OccupiedAdmin_Load(object sender, EventArgs e)
        {
            sideNavControl(btnASldViewAll);
            pnlASldSearch.Visible = false;
            pnlASldFilter.Visible = false;

            SoldHousesDB slddb = new SoldHousesDB();
            dgv_SoldHouses.DataSource = slddb.viewAllSoldHouses();
        }

        private void sideNavControl(Button btn)
        {
            btnASldSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnASldViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnASldFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnASldModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnASldModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            //Change the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));

        }

        private void sidePnlControl()
        {
            pnlASldSearch.Visible = false;
            pnlASldFilter.Visible = false;
            pnlASldModify.Visible = false;
        }

        private void btnASldViewAll_Click(object sender, EventArgs e)
        {
            sidePnlControl();
            SoldHousesDB otiDB = new SoldHousesDB();
            dgv_SoldHouses.DataSource = otiDB.viewAllSoldHouses();
            sideNavControl(btnASldViewAll);
        }

        private void btnASldSearch_Click(object sender, EventArgs e)
        {
            sideNavControl(btnASldSearch);
            sidePnlControl();
            if (pnlASldSearch.Visible == true)
            {
                pnlASldSearch.Visible = false;
            }
            else
                pnlASldSearch.Visible = true;
        }

        private void btnASldFilter_Click(object sender, EventArgs e)
        {
            sideNavControl(btnASldFilter);
            sidePnlControl();

            if (pnlASldFilter.Visible == true)
                pnlASldFilter.Visible = false;
            else
                pnlASldFilter.Visible = true;
        }

        private void btnASldModify_Click(object sender, EventArgs e)
        {
            sideNavControl(btnASldModify);
            sidePnlControl();
            pnlASldModify.Visible = true;
        }

        private void rb_ASldSearchByHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ASldSearchByHouse.Checked == true)
            {
                rb_ASldSearchByOpt.Checked = false;
            }
        }

        private void rb_ASldSearchByOpt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ASldSearchByOpt.Checked == true)
            {
                rb_ASldSearchByHouse.Checked = false;
            }
        }

        private void btnASldSearchShow_Click(object sender, EventArgs e)
        {
            SoldHousesDB sdb = new SoldHousesDB();
            if (rb_ASldSearchByHouse.Checked == true)
            {
                int checkVal;
                if (int.TryParse(txtASldSearch.Text, out checkVal))
                {
                    sdb.setHouseId(int.Parse(txtASldSearch.Text));
                    dgv_SoldHouses.DataSource = sdb.searchOnHouseId();
                }
                else
                    MessageBox.Show("Please enter an integer value");
            }
            else if (rb_ASldSearchByOpt.Checked == true)
            {
                int checkVal;
                if (int.TryParse(txtASldSearch.Text, out checkVal))
                {
                    sdb.setOccupantId(int.Parse(txtASldSearch.Text));
                    dgv_SoldHouses.DataSource = sdb.searchOnOccId();
                }
            }
            else
            {
                MessageBox.Show("Please select one of the search options");
            }
        }

        private void btnASldFilterShow_Click(object sender, EventArgs e)
        {
            SoldHousesDB sdb = new SoldHousesDB();
            sdb.setHouseType(cBoxASldFilterHouseType.Text);
            sdb.setPayStatus(btnASldFilterPaymentStatus.Text);

            dgv_SoldHouses.DataSource = sdb.filterByHousePayment();
        }

        private void btnASldAddHouse_Click(object sender, EventArgs e)
        {
            uc_AddSoldHouse uc = new uc_AddSoldHouse();
            pnlASldContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnASldEditHouse_Click(object sender, EventArgs e)
        {
            uc_EditSoldHouse uc = new uc_EditSoldHouse();
            pnlASldContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnASldDeleteHouse_Click(object sender, EventArgs e)
        {
            uc_DeleteSoldInfo uc = new uc_DeleteSoldInfo();
            pnlASldContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
