using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_AddAccount : UserControl
    {
        public uc_AddAccount()
        {
            InitializeComponent();
        }

        private void btnAAccAdd_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                int check;
                if (int.TryParse(txtAAccAddBranch.Text, out check))
                {
                    if (int.TryParse(txtAAccAddUserType.Text, out check))
                    {
                        int type = int.Parse(txtAAccAddUserType.Text);
                        if (type == 1 || type == 2)
                        {
                            AccountDB adb = new AccountDB(txtAAccAddUserName.Text, txtAAccAddPassword.Text, txtAAccAddFName.Text, txtAAccAddLName.Text, int.Parse(txtAAccAddUserType.Text), int.Parse(txtAAccAddBranch.Text));
                            adb.addToDB();
                        }
                        else
                        {
                            MessageBox.Show("The value of User Type must be either 1 or 2");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("User Type must be an integer with value 1 or 2");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Branch ID must be an integer");
                }
            }
        }

        private bool checkValues()
        {
            bool val = false;
            if (txtAAccAddUserName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a user name");
            }
            else if (txtAAccAddPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter a password");
            }
            else if(txtAAccAddFName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a First Name");
            }
            else if (txtAAccAddLName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Last Name");
            }
            else if (txtAAccAddUserType.Text.Equals(""))
            {
                MessageBox.Show("Please enter a User Type");
            }
            else if (txtAAccAddBranch.Text.Equals(""))
            {
                MessageBox.Show("Please enter a branch ID");
            }
            else
            {
                val = true;
            }

            return val;
        }
    }
}
