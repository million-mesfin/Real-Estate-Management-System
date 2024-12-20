using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_DeleteOccupantInfo : UserControl
    {
        public uc_DeleteOccupantInfo()
        {
            InitializeComponent();
        }

        private void btnDeleteOccupantSearch_Click(object sender, EventArgs e)
        {
            OccupantDB odb = new OccupantDB();
            int check;
            if (int.TryParse(txtDeleteOccupantIDSearch.Text, out check))
            {
                int oid = int.Parse(txtDeleteOccupantIDSearch.Text);
                dgv_Delete.DataSource = odb.getDeleteOccpantInfo(oid);
            }
            else
            {
                MessageBox.Show("The occupant ID must be a number");
            }
        }

        private void btnDeleteOccDelete_Click(object sender, EventArgs e)
        {
            OccupantDB odb = new OccupantDB();
            int rows = dgv_Delete.Rows.Count - 1;
            if (rows == 1)
            {
                odb.deleteOccupantInfo(int.Parse(txtDeleteOccupantIDSearch.Text));

            }
            else if (rows == 0)
            {
                MessageBox.Show("There is no Occupant selected");
            }
            else
            {
                MessageBox.Show("Error. There is no data to delete");
            }
        }

        private void btnDeleteOccCancel_Click(object sender, EventArgs e)
        {
            txtDeleteOccupantIDSearch.Text = null;
            dgv_Delete.Equals(null);
        }
    }
}
