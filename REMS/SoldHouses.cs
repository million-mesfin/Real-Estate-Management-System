using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class SoldHouses : UserControl
    {
        public SoldHouses()
        {
            InitializeComponent();
        }
        private void sideNavControl(Button btn)
        {
            btnUSldViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUSldSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUSldFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void hideSideNavPnls(Panel pnl)
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

        private void btnUSldViewAll_Click(object sender, EventArgs e)
        {
            sideNavControl(btnUSldViewAll);
            pnlUSldSearch.Visible = false;
            pnlUSldFilter.Visible = false;

            SoldHousesDB slddb = new SoldHousesDB();
            dgv_SoldHouses.DataSource = slddb.viewAllSoldHouses();
        }

        private void btnUSldSearch_Click(object sender, EventArgs e)
        {
            sideNavControl(btnUSldSearch);
            hideSideNavPnls(pnlUSldSearch);
            pnlUSldFilter.Visible = false;
        }

        private void rb_USldSearchByHouse_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_USldSearchByHouse.Checked == true)
            {
                rb_USldSearchByOpt.Checked = false;
            }
        }

        private void rb_USldSearchByOpt_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_USldSearchByOpt.Checked == true)
            {
                rb_USldSearchByHouse.Checked = false;
            }
        }

        private void btnUSldSearchShow_Click(object sender, EventArgs e)
        {
            SoldHousesDB sdb = new SoldHousesDB();
            if (rb_USldSearchByHouse.Checked == true)
            {
                int checkVal;
                if (int.TryParse(txtUSldSearch.Text, out checkVal))
                {
                    sdb.setHouseId(int.Parse(txtUSldSearch.Text));
                    dgv_SoldHouses.DataSource = sdb.searchOnHouseId();
                }
                else
                    MessageBox.Show("Please enter an integer value");
            }
            else if (rb_USldSearchByOpt.Checked == true)
            {
                int checkVal;
                if (int.TryParse(txtUSldSearch.Text, out checkVal))
                {
                    sdb.setOccupantId(int.Parse(txtUSldSearch.Text));
                    dgv_SoldHouses.DataSource = sdb.searchOnOccId();
                }
            }
            else
            {
                MessageBox.Show("Please select one of the search options");
            }
        }

        private void btnUSldFilter_Click(object sender, EventArgs e)
        {
            sideNavControl(btnUSldFilter);
            hideSideNavPnls(pnlUSldFilter);
            pnlUSldSearch.Visible = false;
        }

        private void btnUSldFilterShow_Click(object sender, EventArgs e)
        {
            SoldHousesDB sdb = new SoldHousesDB();
            sdb.setHouseType(cBoxUSldFilterHouseType.Text);
            sdb.setPayStatus(btnUSldFilterPaymentStatus.Text);

            dgv_SoldHouses.DataSource = sdb.filterByHousePayment();
        }

        private void SoldHouses_Load(object sender, EventArgs e)
        {
            sideNavControl(btnUSldViewAll);
            pnlUSldSearch.Visible = false;
            pnlUSldFilter.Visible = false;

            SoldHousesDB slddb = new SoldHousesDB();
            dgv_SoldHouses.DataSource = slddb.viewAllSoldHouses();
        }
    }
}
