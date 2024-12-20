using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_Rental_Shops : UserControl
    {
        public uc_Rental_Shops()
        {
            InitializeComponent();
        }

        //Gets the Rental Shops table form the database
        private void uc_Rental_Shops_Load(object sender, EventArgs e)
        {
            RentalDB rdb = new RentalDB();
            dgv_RentalHouses.DataSource = rdb.viewRentalShops();
        }


        //Hide the filter panel when cancle is clicked and show all rental shops
        private void btnURntFilterCancle_Click(object sender, EventArgs e)
        {
            pnlUserRentalFilter.Visible = false;
        }

        //Apply filter to the information shown on the DataGridView
        private void btnURntFilterOk_Click(object sender, EventArgs e)
        {
            RentalDB rdb = new RentalDB();

            setValues(rdb);

            dgv_RentalHouses.DataSource = rdb.filterRentalShops();

            pnlUserRentalFilter.Visible = false;
            clearFilterValues();
        }

        //Show the Rental shop filter panel when clicked
        private void btnUserRentalFilter_Click(object sender, EventArgs e)
        {
            pnlUserRentalFilter.Visible = true;
            clearFilterValues();
        }

        //Function to clear the previous entered filter values
        private void clearFilterValues()
        {
            cb_URntFilterRegion.Checked = false;
            cb_URntFilterCity.Checked = false;
            cb_URntFilterCont.Checked = false;
            cb_URntFilterStat.Checked = false;

            cBoxURntFilterRegion.SelectedIndex = 0;
            cBoxURntFilterStat.SelectedIndex = 0;

            txtURntCont.Text = null;
            txtURntFilterCity.Text = null;
        }

        private void cb_URntFilterRegion_CheckedChanged(object sender, EventArgs e)
        {
            //Enable if Checked and disable if unchecked
            if (cb_URntFilterRegion.Checked == true)
            {
                cBoxURntFilterRegion.Enabled = true;
                string value = cBoxURntFilterRegion.Text;
            }
            else
            {
                cBoxURntFilterRegion.Enabled = false;
            }
        }

        private void cb_URntFilterCity_CheckedChanged(object sender, EventArgs e)
        {
            //Enable if Checked and disable if unchecked
            if (cb_URntFilterCity.Checked == true)
            {
                txtURntFilterCity.Enabled = true;
            }
            else
            {
                txtURntFilterCity.Enabled = false;
            }
        }

        private void cb_URntFilterCont_CheckedChanged(object sender, EventArgs e)
        {
            //Enable if Checked and disable if unchecked
            if (cb_URntFilterCont.Checked == true)
            {
                txtURntCont.Enabled = true;
            }
            else
            {
                txtURntCont.Enabled = false;
            }
        }

        private void cb_URntFilterStat_CheckedChanged(object sender, EventArgs e)
        {
            //Enable if Checked and disable if unchecked
            if (cb_URntFilterStat.Checked == true)
            {
                cBoxURntFilterStat.Enabled = true;
            }
            else
            {
                cBoxURntFilterStat.Enabled = false;
            }
        }

        //Sets up the values form the filter form to RentalDB class
        private void setValues(RentalDB rdb)
        {
            if(cb_URntFilterRegion.Checked == true)
            {
                rdb.setRegion(cBoxURntFilterRegion.Text);
            }
            if(cb_URntFilterCity.Checked == true)
            {
                rdb.setCity(txtURntFilterCity.Text);
            }
            if (cb_URntFilterCont.Checked == true)
            {
                //Check if the given value for 'Contructor ID' is a number
                int checkVal;
                if (int.TryParse(txtURntCont.Text, out checkVal))
                {
                    int contID = int.Parse(txtURntCont.Text);
                    if (contID > 0)
                    {
                        rdb.setContractorId(int.Parse(txtURntCont.Text));
                    }
                    else
                    {
                        MessageBox.Show("Contractor ID must be greater then Zero");
                    }
                }
                else
                {
                    MessageBox.Show("The value for 'Contractor ID' must be a number");
                }
            }
            if(cb_URntFilterStat.Checked == true)
            {
                rdb.setStatus(cBoxURntFilterStat.Text);
            }
        }

        
    }
}
