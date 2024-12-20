using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_EditOccupantInfo : UserControl
    {
        public uc_EditOccupantInfo()
        {
            InitializeComponent();
        }

        private void btnEditOccupantSearch_Click(object sender, EventArgs e)
        {
            int check;
            if(int.TryParse(txtEditOccupantIDSearch.Text, out check))
            {
                OccupantInfo oi = new OccupantInfo();
                oi.setForm(int.Parse(txtEditOccupantIDSearch.Text));

                txtEditOccupantName.Text = oi.name;
                txtEditOccupantPhone.Text = oi.phoneNumber;
                txtEditOccupantEmail.Text = oi.email;
                txtEditOccupantHouseId.Text = oi.houseId.ToString();
                cBoxEditOccupantHouseType.Text = oi.houseType;
            }
            else
            {
                MessageBox.Show("The Occupant ID must be a number");
            }
        }

        private void btnEditOccupantCancel_Click(object sender, EventArgs e)
        {
            txtEditOccupantName.Text = "";
            txtEditOccupantPhone.Text = "";
            txtEditOccupantEmail.Text = "";
            txtEditOccupantHouseId.Text = "";
            cBoxEditOccupantHouseType.Text = "";
        }

        private void btnEditOccupantAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int oid = int.Parse(txtEditOccupantIDSearch.Text);
                string name = txtEditOccupantName.Text;
                string phone = txtEditOccupantPhone.Text;
                string email = txtEditOccupantEmail.Text;
                int houseId = int.Parse(txtEditOccupantHouseId.Text);
                string houseType = cBoxEditOccupantHouseType.Text;

                OccupantDB odb = new OccupantDB(name, phone, email, houseId, houseType);
                odb.setEdited(oid);
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure all the data is in correct format");
            }
        }
    }
}
