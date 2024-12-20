using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_AddClearLot : UserControl
    {
        public uc_AddClearLot()
        {
            InitializeComponent();
        }

        private bool checkValues()
        {
            bool val = false;
            if (txtAddClearLotSize.Text.Equals(""))
            {
                MessageBox.Show("Please enter the size of the plot");
            }
            else if (cBoxAddClearLotRegion.Text.Equals(""))
            {
                MessageBox.Show("Please select the region");
            }
            else if (txtAddClearLotCity.Text.Equals(""))
            {
                MessageBox.Show("Please enter a city");
            }
            else if (cBoxAddClearLotPermit.Text.Equals(""))
            {
                MessageBox.Show("Please select a permit stauts");
            }

            int check;
            if (int.TryParse(txtAddClearLotSize.Text, out check))
            {
                val = true;
            }
            else
            {
                MessageBox.Show("The size must be a numeric value");
            }
            return val;
        }

        private void btnAddRentalClear_Click(object sender, EventArgs e)
        {
            txtAddClearLotSize.Text = null;
            txtAddClearLotCity.Text = null;
            cBoxAddClearLotPermit.Text = null;
            cBoxAddClearLotRegion.Text = null;
        }

        private void btnAddClearLotAdd_Click(object sender, EventArgs e)
        {
            bool check = checkValues();

            if (check)
            {
                ClearLot cl = new ClearLot(int.Parse(txtAddClearLotSize.Text), cBoxAddClearLotRegion.Text, txtAddClearLotCity.Text, cBoxAddClearLotPermit.Text);
                cl.setToDB();
            }
        }
    }
}
