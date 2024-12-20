using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REMS
{
    public partial class uc_Accounts : UserControl
    {
        public uc_Accounts()
        {
            InitializeComponent();
        }

        private void btnAAccAdd_Click(object sender, EventArgs e)
        {
            uc_AddAccount uc = new uc_AddAccount();
            pnlAccContainer.Controls.Add(uc);
        }

        private void btnAAccChange_Click(object sender, EventArgs e)
        {
            uc_ChangePassword uc = new uc_ChangePassword();
            pnlAccContainer.Controls.Add(uc);
        }
    }
}
