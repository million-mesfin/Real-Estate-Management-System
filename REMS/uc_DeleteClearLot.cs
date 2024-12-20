using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_DeleteClearLot : UserControl
    {
        public uc_DeleteClearLot()
        {
            InitializeComponent();
        }

        private void btnDeleteClearLotSearch_Click(object sender, EventArgs e)
        {
            ClearLotDB cldb = new ClearLotDB();
            int check;
            if(int.TryParse(txtDeleteClearLotIDSearch.Text, out check))
            {
                dgv_Delete.DataSource = cldb.getDeleteLotInfo(int.Parse(txtDeleteClearLotIDSearch.Text));
            }
            else
            {
                MessageBox.Show("The Lot ID must be an integer");
            }
        }

        private void btnDeleteClearLotDelete_Click(object sender, EventArgs e)
        {
            ClearLotDB cldb = new ClearLotDB();
            int rows = dgv_Delete.Rows.Count - 1;
            if (rows == 1)
            {
                cldb.DeleteLotInfo(int.Parse(txtDeleteClearLotIDSearch.Text));
            }
        }

        private void btnDeleteClearLotClear_Click(object sender, EventArgs e)
        {
            txtDeleteClearLotIDSearch.Text = null;
            dgv_Delete = null;
        }
    }
}
