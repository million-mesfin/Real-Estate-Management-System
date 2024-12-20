using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class pnlHouses : UserControl
    {

        public pnlHouses()
        {
            InitializeComponent();
        }

        private void btnUserRental_Click(object sender, EventArgs e)
        {
            houseBtnControl(btnUserRental);

            pnlUserHouseContainer.Controls.Clear();
            uc_Rental_Shops ucRental = new uc_Rental_Shops();
            pnlUserHouseContainer.Controls.Add(ucRental);
        }

        private void btnUserApartments_Click(object sender, EventArgs e)
        {
            houseBtnControl(btnUserApartments);

            pnlUserHouseContainer.Controls.Clear();
            uc_Apartments ucApt = new uc_Apartments();
            pnlUserHouseContainer.Controls.Add(ucApt);

        }

        private void btnUserSplitLevel_Click(object sender, EventArgs e)
        {
            houseBtnControl(btnUserSplitLevel);

            pnlUserHouseContainer.Controls.Clear();
            uc_SplitLevel ucSpl = new uc_SplitLevel();
            pnlUserHouseContainer.Controls.Add(ucSpl);
        }

        private void houseBtnControl(Button btn)
        {
            btnUserRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btnUserSplitLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));

            btnUserRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserApartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btnUserSplitLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));

            //change the values for the selected button
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            btn.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        private void pnlHouses_Load(object sender, EventArgs e)
        {
            houseBtnControl(btnUserRental);

            pnlUserHouseContainer.Controls.Clear();
            uc_Rental_Shops ucRental = new uc_Rental_Shops();
            pnlUserHouseContainer.Controls.Add(ucRental);
        }
    }
}
