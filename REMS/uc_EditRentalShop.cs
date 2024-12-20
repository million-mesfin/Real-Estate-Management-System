using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_EditRentalShop : UserControl
    {
        public uc_EditRentalShop()
        {
            InitializeComponent();
        }

        private void btnEditRntSearch_Click(object sender, EventArgs e)
        {
            int checkVal;
            if (int.TryParse(txtEditRntIDSearch.Text, out checkVal))
            {

                RentalShop rs = new RentalShop();
                rs.setForm(int.Parse(txtEditRntIDSearch.Text));

                //Set the values from rental shop class to the form
                    cBoxEditRntRegion.Text = rs.region;
                    txtEditRntCity.Text = rs.city;
                    txtEditRntStories.Text = rs.stories.ToString();
                    txtEditRntSpace.Text = rs.floorSpace.ToString();
                    txtEditRntRent.Text = rs.rent.ToString();
                    txtEditRntConId.Text = rs.contractorId.ToString();
                    txtEditRntBuiltOn.Text = rs.builtOn;
                    cBoxEditRntStatus.Text = rs.status;
            }
            else
            {
                MessageBox.Show("The Contractor ID must be an Integer");
            }

        }

        private void btnEditRntApply_Click(object sender, EventArgs e)
        {
            try
            {
                int shopId = int.Parse(txtEditRntIDSearch.Text);
                string region = cBoxEditRntRegion.Text;
                string city = txtEditRntCity.Text;
                int stories = int.Parse(txtEditRntStories.Text);
                int space = int.Parse(txtEditRntSpace.Text);
                decimal rent = decimal.Parse(txtEditRntRent.Text);
                int conId = int.Parse(txtEditRntConId.Text);
                string builtOn = txtEditRntBuiltOn.Text;
                string status = cBoxEditRntStatus.Text;

                RentalDB rdb = new RentalDB(region, city, builtOn, rent, conId, stories, space, status);
                rdb.setEditedValue(shopId);
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure all the data is in correct format");
            }
            
        }

        private void btnEditRntCancel_Click(object sender, EventArgs e)
        {
            cBoxEditRntRegion.Text = "";
            txtEditRntCity.Text = "";
            txtEditRntStories.Text = "";
            txtEditRntSpace.Text = "";
            txtEditRntRent.Text = "";
            txtEditRntConId.Text = "";
            txtEditRntBuiltOn.Text = "";
            cBoxEditRntStatus.Text = "";
        }
    }
}
