using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_AddHouse : UserControl
    {
        public uc_AddHouse()
        {
            InitializeComponent();
        }

        private void cBoxAddHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxAddHouseType.SelectedIndex == 0)
            {
                uc_AddRentalShop uc = new uc_AddRentalShop();
                pnlAddContainer.Controls.Clear();
                pnlAddContainer.Controls.Add(uc);
            }
        }
    }
}
