using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_ClearLot : UserControl
    {
        public uc_ClearLot()
        {
            InitializeComponent();
        }

        private void uc_ClearLot_Load(object sender, EventArgs e)
        {
            ClearLotDB clpdb = new ClearLotDB();
            dgv_ClearPlot.DataSource = clpdb.viewAllClearLots();
            btnUCplViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
        }

        private void sideNavBtnControl(Button btn)
        {
            btnUCplViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUCplFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void sideNavPnlControl()
        {
            if(pnlUCplFilter.Visible == false)
            {
                pnlUCplFilter.Visible = true;
            }
            else if(pnlUCplFilter.Visible == true)
            {
                pnlUCplFilter.Visible = false;
                btnUCplFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            }
        }

        private void btnUCplViewAll_Click(object sender, EventArgs e)
        {
            ClearLotDB clpdb = new ClearLotDB();
            sideNavBtnControl(btnUCplViewAll);
            dgv_ClearPlot.DataSource = clpdb.viewAllClearLots();
            pnlUCplFilter.Visible = false;

        }

        private void btnUCplFilter_Click(object sender, EventArgs e)
        {
            sideNavPnlControl();
            sideNavBtnControl(btnUCplFilter);
        }

        private void btnUCplFilterShow_Click(object sender, EventArgs e)
        {

            ClearLotDB clpdb = new ClearLotDB();

            clpdb.setRegion(cBoxUCplFilterRegion.Text);
            clpdb.setCity(txtUCplFilterCity.Text);
            clpdb.setPermit(cBoxUCplFilterPermit.Text);
            dgv_ClearPlot.DataSource = clpdb.filterClearLots();
        }
    }
}
