using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_ChangePassword : UserControl
    {
        public uc_ChangePassword()
        {
            InitializeComponent();
        }

        private void btnAAccChangeApply_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                AccountDB adb = new AccountDB();
                adb.changePassword(txtAAccChangeNewPassword.Text, txtAAccChangeUserName.Text, txtAAccChangePassword.Text);
            }
        }

        private bool checkValues()
        {
            bool val = false;
            if (txtAAccChangeUserName.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a user name");
            }
            else if (txtAAccChangePassword.Text.Equals(""))
            {
                MessageBox.Show("Please Enter the current password");
            }
            else if (txtAAccChangeNewPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter the new password");
            }
            else if (txtAAccChangePassword.Text.Equals(txtAAccChangeNewPassword.Text))
            {
                MessageBox.Show("The current and the new password can't be the same");
            }
            else
            {
                val = true;
            }
            return val;
        }
    }
}
