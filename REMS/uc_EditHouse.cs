using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_EditHouse : UserControl
    {
        public uc_EditHouse()
        {
            InitializeComponent();
        }

        private void cBoxEditHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxEditHouseType.SelectedIndex == 0)
            {
                uc_EditRentalShop uc = new uc_EditRentalShop();
                pnlEditContainer.Controls.Clear();
                pnlEditContainer.Controls.Add(uc);
            }
        }
    }
}
