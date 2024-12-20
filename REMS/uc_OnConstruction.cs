using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_OnConstruction : UserControl
    {
        public uc_OnConstruction()
        {
            InitializeComponent();
        }

        private void uc_OnConstruction_Load(object sender, EventArgs e)
        {
            OnConstructionDB ocodb = new OnConstructionDB();
            sideNavBtnControl(btnUOcoViewAll);
            pnlUOcoFilter.Visible = false;
            dgv_OnConstruction.DataSource = ocodb.viewAllOnConstruction();
        }

        private void btnUOcoViewAll_Click(object sender, EventArgs e)
        {
            OnConstructionDB ocodb = new OnConstructionDB();
            sideNavBtnControl(btnUOcoViewAll);
            pnlUOcoFilter.Visible = false;
            dgv_OnConstruction.DataSource = ocodb.viewAllOnConstruction();
        }

        private void btnUOcoFilter_Click(object sender, EventArgs e)
        {
            sideNavBtnControl(btnUOcoFilter);
            sideNavPnlControl();
        }

        private void btnUOcoFilterShow_Click(object sender, EventArgs e)
        {
            OnConstructionDB ocodb = new OnConstructionDB();
            if (cBoxUOcoFilterRegion.Text.Equals("") && cBoxUOcoFilterHouse.Text.Equals("") && txtUOcoFilterCity.Text.Equals(""))
            {
                MessageBox.Show("Please enter at least 1 fiter parameter.");
            }
            else
            {
                setValues();
                dgv_OnConstruction.DataSource = ocodb.filterOnConstruction();
            }
        }

        private void setValues()
        {
            OnConstructionDB ocodb = new OnConstructionDB();

            ocodb.setRegion(cBoxUOcoFilterRegion.Text);
            ocodb.setCity(txtUOcoFilterCity.Text);
            ocodb.setHouseType(cBoxUOcoFilterHouse.Text);
        }

        private void sideNavBtnControl(Button btn)
        {
            btnUOcoViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUOcoFilter.BackColor  = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void sideNavPnlControl()
        {
            if(pnlUOcoFilter.Visible == true)
            {
                pnlUOcoFilter.Visible = false;
            }
            else if (pnlUOcoFilter.Visible == false)
            {
                pnlUOcoFilter.Visible = true;
            }
        }
    }
}
