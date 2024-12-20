using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_AddOccupant : UserControl
    {
        public uc_AddOccupant()
        {
            InitializeComponent();
        }

        private void btnAddOccupantCancel_Click(object sender, EventArgs e)
        {
            txtAddOccupantName.Text = null;
            txtAddOccupantPhone.Text = null;
            txtAddOccupantEmail.Text = null;
            txtAddOccupantHouseId.Text = null;
            cBoxAddOccupantHouseType.Text = "";
        }

        private void btnAddOccupantAdd_Click(object sender, EventArgs e)
        {
            if (txtAddOccupantName.Text.Equals(""))
                MessageBox.Show("Name can't be empty");
            else if (txtAddOccupantPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone Number can't be empty");
            }
            else if (txtAddOccupantEmail.Text.Equals(""))
            {
                MessageBox.Show("Email can't be empty");
            }
            else if (txtAddOccupantHouseId.Text.Equals(""))
            {
                MessageBox.Show("House ID can't be empty");      
            }
            else if (cBoxAddOccupantHouseType.Text.Equals(""))
            {
                MessageBox.Show("Please select a house type");
            }
            else
            {
                OccupantInfo oi = new OccupantInfo();
                bool emailCheck = oi.checkEmail(txtAddOccupantEmail.Text);
                bool phoneCheck = oi.checkPhone(txtAddOccupantPhone.Text);
                int houseId;

                if (int.TryParse(txtAddOccupantHouseId.Text, out houseId))
                {
                    if (emailCheck == true && phoneCheck == true)
                    {
                        OccupantDB odb = new OccupantDB(txtAddOccupantName.Text, txtAddOccupantPhone.Text, txtAddOccupantEmail.Text, int.Parse(txtAddOccupantHouseId.Text), cBoxAddOccupantHouseType.Text);
                        odb.addToDB();
                    }
                }
                else
                {
                    MessageBox.Show("The value of House ID must be a number");
                }
                
            }
        }
    }
}
