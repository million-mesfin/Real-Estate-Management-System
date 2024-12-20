using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_EditClearLot : UserControl
    {
        public uc_EditClearLot()
        {
            InitializeComponent();
        }

        private bool checkValues()
        {
            bool val = false;

            if (txtEditClearLotSize.Text.Equals(""))
            {
                MessageBox.Show("Please enter the size");
            }
            else if (cBoxEditClearLotRegion.Text.Equals(""))
            {
                MessageBox.Show("Please select the region");
            }
            else if (txtEditClearLotCity.Text.Equals(""))
            {
                MessageBox.Show("Please enter a city");
            }
            else if (cBoxEditClearLotPermit.Text.Equals(""))
            {
                MessageBox.Show("Please select a permit stauts");
            }

            int check;
            if (int.TryParse(txtEditClearLotSize.Text, out check))
            {
                val = true;
            }
            else
            {
                MessageBox.Show("The size must be a numeric value");
            }
            return val;
        }

        private void btnEditRentalClear_Click(object sender, EventArgs e)
        {
            txtEditClearLotSize.Text = null;
            txtEditClearLotCity.Text = null;
            cBoxEditClearLotPermit.Text = null;
            cBoxEditClearLotRegion.Text = null;
        }

        private void btnEditClearLotSearch_Click(object sender, EventArgs e)
        {
            int check;
            if (int.TryParse(txtEditClearLotID.Text, out check))
            {
                ClearLot cl = new ClearLot();

                cl.setToForm(int.Parse(txtEditClearLotID.Text));

                txtEditClearLotSize.Text = cl.size.ToString();
                cBoxEditClearLotRegion.Text = cl.region;
                txtEditClearLotCity.Text = cl.city;
                cBoxEditClearLotPermit.Text = cl.permitStatus;

            }
        }

        private void btnEditRentalAdd_Click(object sender, EventArgs e)
        {
            checkValues();
            ClearLot cl = new ClearLot(int.Parse(txtEditClearLotSize.Text), cBoxEditClearLotRegion.Text, txtEditClearLotCity.Text, cBoxEditClearLotPermit.Text); ;
            cl.setEditToDB(int.Parse(txtEditClearLotID.Text), cl);
        }
    }
}
