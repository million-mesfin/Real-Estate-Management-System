using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_HousesAdmin : UserControl
    {
        public uc_HousesAdmin()
        {
            InitializeComponent();
        }

        private void uc_HousesAdmin_Load(object sender, EventArgs e)
        {
            uc_Rental_Shops uc = new uc_Rental_Shops();
            containerControl(uc);
            sideNavBtnControl(btnAdminRental);
        }

        private void containerControl(UserControl pnl)
        {
            pnlAdminHouseContainer.Controls.Clear();
            pnlAdminHouseContainer.Controls.Add(pnl);
        }

        private void btnAdminRental_Click(object sender, EventArgs e)
        {
            uc_Rental_Shops uc = new uc_Rental_Shops();
            containerControl(uc);
            sideNavBtnControl(btnAdminRental);
        }

        private void btnAdminApartment_Click(object sender, EventArgs e)
        {
            uc_Apartments uc = new uc_Apartments();
            containerControl(uc);
            sideNavBtnControl(btnAdminApartment);
        }


        private void btnAdminSplitLevel_Click(object sender, EventArgs e)
        {
            uc_SplitLevel uc = new uc_SplitLevel();
            containerControl(uc);

            sideNavBtnControl(btnAdminSplitLevel);
        }

        private void btnAdminModifyHouse_Click(object sender, EventArgs e)
        {
            if (pnlAdminModHouse.Visible == true)
            {
                pnlAdminModHouse.Visible = false;
            }
            else if (pnlAdminModHouse.Visible == false)
            {
                pnlAdminModHouse.Visible = true;
            }

            sideNavBtnControl(btnAdminModifyHouse);
        }

        private void sideNavBtnControl(Button btn)
        {
            btnAdminRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminSplitLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnAdminModifyHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAdminHouseContainer.Controls.Clear();
            uc_AddHouse uc = new uc_AddHouse();
            pnlAdminHouseContainer.Controls.Add(uc);
        }

        private void btnEditHouseInfo_Click(object sender, EventArgs e)
        {
            pnlAdminHouseContainer.Controls.Clear();
            uc_EditHouse uc = new uc_EditHouse();
            pnlAdminHouseContainer.Controls.Add(uc);
        }

        private void btnDeleteHouse_Click(object sender, EventArgs e)
        {
            pnlAdminHouseContainer.Controls.Clear();
            uc_DeleteHouse uc = new uc_DeleteHouse();
            pnlAdminHouseContainer.Controls.Add(uc);
        }
    }
}
