using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_SplitLevel : UserControl
    {
        public uc_SplitLevel()
        {
            InitializeComponent();
        }

        private void btnUserSplFilter_Click(object sender, EventArgs e)
        {
            pnlUSplFilter.Visible = true;
            clearSplFilter();
        }

        //Clear the selected options in the filter panel
        private void clearSplFilter()
        {
            cb_USplFilterRegion.Checked = false;
            cb_USplFilterCity.Checked = false;
            cb_USplFilterCont.Checked = false;
            cb_USplFilterStatus.Checked = false;
            cb_USplFilterNoFloor.Checked = false;
            cb_USplFilterContID.Checked = false;

            cBoxUSplFilterRegion.Text = null;
            cBoxUSplFilterStatus.Text = null;

            txtUSplFilterCity.Text = null;
            txtUSplFilterCont.Text = null;
            txtUSplFilterNoFloor.Text = null;
            txtUSplFilterContID.Text = null;
        }

        private void cb_USplFilterRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterRegion.Checked == true)
            {
                cBoxUSplFilterRegion.Enabled = true;
            }
            else
            {
                cBoxUSplFilterRegion.Enabled = false;
            }
        }

        private void cb_USplFilterCity_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterCity.Checked == true)
            {
                txtUSplFilterCity.Enabled = true;
            }
            else
            {
                txtUSplFilterCity.Enabled = false;
            }
        }

        private void cb_USplFilterCont_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterCont.Checked == true)
            {
                txtUSplFilterCont.Enabled = true;
            }
            else
            {
                txtUSplFilterCont.Enabled = false;
            }
        }

        private void cb_USplFilterStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterStatus.Checked == true)
            {
                cBoxUSplFilterStatus.Enabled = true;
            }
            else
            {
                cBoxUSplFilterStatus.Enabled = false;
            }
        }

        private void cb_USplFilterNoFloor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterNoFloor.Checked == true)
            {
                txtUSplFilterNoFloor.Enabled = true;
            }
            else
            {
                txtUSplFilterNoFloor.Enabled = false;
            }
        }

        private void cb_USplFilterContID_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_USplFilterContID.Checked == true)
            {
                txtUSplFilterContID.Enabled = true;
            }
            else
            {
                txtUSplFilterContID.Enabled = false;
            }
        }

        //set up the values from the filter form to SplitLevelDB class
        private void setValues(SplitLevelDB sdb)
        {
            if(cb_USplFilterRegion.Checked == true)
            {
                sdb.setRegion(cBoxUSplFilterRegion.Text);
            }
            if(cb_USplFilterCity.Checked == true)
            {
                sdb.setCity(txtUSplFilterCity.Text);
            }
            if(cb_USplFilterStatus.Checked == true)
            {
                sdb.setStatus(cBoxUSplFilterStatus.Text);
            }
            if(cb_USplFilterCont.Checked == true)
            {
                //check if value is numeric
                int checkVal;
                if(int.TryParse(txtUSplFilterCont.Text, out checkVal))
                {
                    int rooms = int.Parse(txtUSplFilterCont.Text);
                    //Check if value is negative or zero
                    if(rooms > 0)
                    {
                        sdb.setNoBedroom(rooms);
                    }
                    else
                    {
                        MessageBox.Show("The number of bedrooms must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("The value for 'Number of Bedrooms' must be a number");
                }
            }

            if (cb_USplFilterNoFloor.Checked == true)
            {
                //check if value is numeric
                int checkVal;
                if (int.TryParse(txtUSplFilterNoFloor.Text, out checkVal))
                {
                    int floors = int.Parse(txtUSplFilterNoFloor.Text);
                    //Check if value is negative or zero
                    if (floors > 0)
                    {
                        sdb.setFloors(floors);
                    }
                    else
                    {
                        MessageBox.Show("The number of floors must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("The value for 'Number of Floors' must be a number");
                }
            }

            if (cb_USplFilterContID.Checked == true)
            {
                //check if value is numeric
                int checkVal;
                if (int.TryParse(txtUSplFilterContID.Text, out checkVal))
                {
                    int id = int.Parse(txtUSplFilterContID.Text);
                    //Check if value is negative or zero
                    if (id > 0)
                    {
                        sdb.setContractorId(id);
                    }
                    else
                    {
                        MessageBox.Show("The Contractor's ID must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("The value for 'Contractor's ID' must be a number");
                }
            }
        }

        private void uc_SplitLevel_Load(object sender, EventArgs e)
        {
            SplitLevelDB sdb = new SplitLevelDB();
            dgv_SplitLevel.DataSource = sdb.viewSplHouses();
        }

        private void btnUAptFilterCancle_Click(object sender, EventArgs e)
        {
            pnlUSplFilter.Visible = false;
        }

        private void btnUAptFilterOk_Click(object sender, EventArgs e)
        {
            pnlUSplFilter.Visible = false;

            SplitLevelDB sdb = new SplitLevelDB();
            setValues(sdb);
            dgv_SplitLevel.DataSource = sdb.filterSplHouses();

            sdb.filterSplHouses();
        }
    }
}
