using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_ClearLotAdmin : UserControl
    {
        public uc_ClearLotAdmin()
        {
            InitializeComponent();
        }

        private void btnACplViewAll_Click(object sender, EventArgs e)
        {
            ClearLotDB clpdb = new ClearLotDB();
            sideNavBtnControl(btnACplViewAll);
            dgv_ClearPlot.DataSource = clpdb.viewAllClearLots();
            pnlACplFilter.Visible = false;
            pnlACplModify.Visible = false;
        }

        private void uc_ClearLotAdmin_Load(object sender, EventArgs e)
        {
            ClearLotDB clpdb = new ClearLotDB();
            dgv_ClearPlot.DataSource = clpdb.viewAllClearLots();
            btnACplViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
        }

        private void sideNavBtnControl(Button btn)
        {
            btnACplViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnACplFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnACplModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }
        private void sideNavPnlControl()
        {
            if (pnlACplFilter.Visible == false)
            {
                pnlACplFilter.Visible = true;
                pnlACplModify.Visible = false;
            }
            else if (pnlACplFilter.Visible == true)
            {
                pnlACplFilter.Visible = false;
                btnACplFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            }
        }

        private void btnACplFilter_Click(object sender, EventArgs e)
        {
            sideNavPnlControl();
            sideNavBtnControl(btnACplFilter);
        }

        private void btnACplFilterShow_Click(object sender, EventArgs e)
        {
            ClearLotDB clpdb = new ClearLotDB();
            setValues();
            dgv_ClearPlot.DataSource = clpdb.filterClearLots();
        }
        public void setValues()
        {
            ClearLotDB clpdb = new ClearLotDB();

            clpdb.setRegion(cBoxACplFilterRegion.Text);
            clpdb.setCity(txtACplFilterCity.Text);
            clpdb.setPermit(cBoxACplFilterPermit.Text);
        }

        private void btnACplModify_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnACplModify);
            if (pnlACplModify.Visible == true)
                pnlACplModify.Visible = false;
            else
                pnlACplModify.Visible = true;

            pnlACplFilter.Visible = false;
        }

        private void btnACplAdd_Click(object sender, EventArgs e)
        {
            uc_AddClearLot uc = new uc_AddClearLot();
            pnlAClearLotContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnACplEditInfo_Click(object sender, EventArgs e)
        {
            uc_EditClearLot uc = new uc_EditClearLot();
            pnlAClearLotContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnAcplDeleteInfo_Click(object sender, EventArgs e)
        {
            uc_DeleteClearLot uc = new uc_DeleteClearLot();
            pnlAClearLotContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
