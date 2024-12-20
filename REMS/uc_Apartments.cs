using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_Apartments : UserControl
    {
        public uc_Apartments()
        {
            InitializeComponent();
        }

        private void btnUserAptFilter_Click(object sender, EventArgs e)
        {
            pnlUAptFilter.Visible = true;
            clearAptFilterOptions();
        }

        //Clear the selected options in the filter panel
        private void clearAptFilterOptions()
        {
            cb_UAptFilterRegion.Checked = false;
            cb_UAptFilterCity.Checked = false;
            cb_UAptFilterCont.Checked = false;
            cb_UAptFilterStatus.Checked = false;

            txtUAptFilterCity.Text = null;
            txtUAptFilterCont.Text = null;

            cBoxUAptFilterRegion.SelectedIndex = 0;
            cBoxUAptFilterStatus.SelectedIndex = 0;
        }

        private void cb_UAptFilterRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UAptFilterRegion.Checked == true)
            {
                cBoxUAptFilterRegion.Enabled = true;
            }
            else
            {
                cBoxUAptFilterRegion.Enabled = false;
            }
        }

        private void cb_UAptFilterCity_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UAptFilterCity.Checked == true)
            {
                txtUAptFilterCity.Enabled = true;
            }
            else
            {
                txtUAptFilterCity.Enabled = false;
            }
        }

        private void cb_UAptFilterCont_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UAptFilterCont.Checked == true)
            {
                txtUAptFilterCont.Enabled = true;
            }
            else
            {
                txtUAptFilterCont.Enabled = false;
            }
        }

        private void cb_UAptFilterStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_UAptFilterStatus.Checked == true)
            {
                cBoxUAptFilterStatus.Enabled = true;
            }
            else
            {
                cBoxUAptFilterStatus.Enabled = false;
            }
        }

        private void uc_Apartments_Load(object sender, EventArgs e)
        {
            ApartmentDB adb = new ApartmentDB();
            dgv_Apartments.DataSource = adb.viewApartments();
        }

        private void btnUAptFilterOk_Click(object sender, EventArgs e)
        {
            ApartmentDB adb = new ApartmentDB();
            setValues(adb);

            dgv_Apartments.DataSource = adb.filterApartments();
            pnlUAptFilter.Visible = false;
        }

        private void btnUAptFilterCancle_Click(object sender, EventArgs e)
        {
            pnlUAptFilter.Visible = false;
        }
        
        //Sets up the values from the filter form to ApartmentDB class
        private void setValues(ApartmentDB abd)
        {
            if(cb_UAptFilterRegion.Checked == true)
            {
                abd.setRegion(cBoxUAptFilterRegion.Text);
            }
            if(cb_UAptFilterCity.Checked == true)
            {
                abd.setCity(txtUAptFilterCity.Text);
            }
            if (cb_UAptFilterCont.Checked == true)
            {
                //Check if the given value for 'Number of bedrooms' is a number
                int checkVal;
                if (int.TryParse(txtUAptFilterCont.Text, out checkVal))
                {
                    int rooms = int.Parse(txtUAptFilterCont.Text);
                    //check if number of bedrooms are greater than 0
                    if(rooms > 0)
                    {
                        abd.setNoBedrooms(rooms);
                    }
                    else
                    {
                        MessageBox.Show("The number of bedrooms must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("The value for 'Number Of Bedrooms' must be a number");
                }
            }
            if (cb_UAptFilterStatus.Checked == true)
            {
                abd.setStatus(cBoxUAptFilterStatus.Text);
            }
        }
    }
}
