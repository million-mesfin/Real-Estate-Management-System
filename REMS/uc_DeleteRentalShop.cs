using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_DeleteRentalShop : UserControl
    {
        public uc_DeleteRentalShop()
        {
            InitializeComponent();
        }

        private void btnDeleteRntSearch_Click(object sender, EventArgs e)
        {
            RentalDB rdb = new RentalDB();
            int checkVal;
            if (int.TryParse(txtDeleteRntIDSearch.Text, out checkVal))
            {
                int shopid = int.Parse(txtDeleteRntIDSearch.Text);
                dgv_Delete.DataSource = rdb.getDeleteHouseInfo(shopid);
                
            }
            else
            {
                MessageBox.Show("The Shop ID must be an Integer");
            }
        }

        private void btnDeleteRntDelete_Click(object sender, EventArgs e)
        {
            RentalDB rdb = new RentalDB();
            int rows = dgv_Delete.Rows.Count - 1;
            if (rows == 1)
            {
                rdb.deleteRentalInfo(int.Parse(txtDeleteRntIDSearch.Text));

            }
            else if (rows == 0)
            {
                MessageBox.Show("There is no Shop selected");
            }
            else
            {
                MessageBox.Show("Error. There is no data to delete");
            }
        }

        private void btnDeleteRntCancel_Click(object sender, EventArgs e)
        {
            txtDeleteRntIDSearch.Text = null;
            dgv_Delete = null;
        }
    }
}
