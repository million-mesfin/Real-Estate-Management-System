using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_AddRentalShop : UserControl
    {
        public string region;
        public string city;
        public string builtOn;
        public int contractorId = 0, stories, floorSpace, rent;
        public string status;

        private void btnAddRentalClear_Click(object sender, EventArgs e)
        {
            cBoxAddRentalRegion.Text = "";
            txtAddRentalCity.Text = "";
            txtAddRentalValue.Text = "";
            txtAddRentalStories.Text = "";
            txtAddRentalFloorSpace.Text = "";
            txtAddRentalConId.Text = "";
            txtAddRentalBuiltOn.Text = "";
            cBoxAddRentalStatus.Text = "";
        }

        public uc_AddRentalShop()
        {
            InitializeComponent();
        }

        private void btnAddRentalAdd_Click(object sender, EventArgs e)
        {
            if (cBoxAddRentalRegion.Text.Equals(""))
            {
                MessageBox.Show("Please Select a Region");
            }
            else if (txtAddRentalCity.Text.Equals(""))
            {
                MessageBox.Show("Please enter a City");
            }
            else if (txtAddRentalValue.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Rental Value");
            }
            else if (txtAddRentalStories.Text.Equals(""))
            {
                MessageBox.Show("Please enter number of Stories");
            }
            else if (txtAddRentalFloorSpace.Text.Equals(""))
            {
                MessageBox.Show("Please enter the Floor Space");
            }
            else if (txtAddRentalConId.Text.Equals(""))
            {
                MessageBox.Show("Please enter the Contractor ID");
            }
            else if (txtAddRentalBuiltOn.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Date");
            }
            else if (cBoxAddRentalStatus.Text.Equals(""))
            {
                MessageBox.Show("Please select a House Status");
            }
            else
            {
                addValues();
                RentalDB rdb = new RentalDB(region, city, builtOn, rent, contractorId, stories, floorSpace, status); ;
                rdb.addToDB();
            }
        }

        private void addValues()
        {
            region = cBoxAddRentalRegion.Text;
            city = txtAddRentalCity.Text;
            rent = int.Parse(txtAddRentalValue.Text);
            stories = int.Parse(txtAddRentalStories.Text);
            floorSpace = int.Parse(txtAddRentalFloorSpace.Text);
            contractorId = int.Parse(txtAddRentalConId.Text);
            builtOn = txtAddRentalBuiltOn.Text;
            status = cBoxAddRentalStatus.Text;
        }


    }
}
