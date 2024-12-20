using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_DeleteHouse : UserControl
    {
        public uc_DeleteHouse()
        {
            InitializeComponent();
        }

        private void cBoxDeleteHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxDeleteHouseType.SelectedIndex == 0)
            {
                uc_DeleteRentalShop uc = new uc_DeleteRentalShop();
                pnlDeleteContainer.Controls.Clear();
                pnlDeleteContainer.Controls.Add(uc);
            }
        }
    }
}
