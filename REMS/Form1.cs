using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;

namespace REMS
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        //Connection String for the database 'Real Estate Management'
        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("SELECT userType FROM accounts WHERE userId = '" + txtUserName.Text + "' AND u_password = '" + txtPassword.Text + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                int userType = 0; //To hold the user type read from the database
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //Set the value from the database
                userType = reader.GetInt32(0);

                if (userType == 1)
                {
                    pnlAdminHome uc = new pnlAdminHome();
                    addUserControl(uc);
                }
                else if (userType == 0)
                {
                    MessageBox.Show("There was an error during login");
                }
                else
                {
                    pnlUserHome uc = new pnlUserHome();
                    addUserControl(uc);
                }
            }
            else
            {
                MessageBox.Show("Incorrect password or user name. Login after 10 seconds");
                lblTimer.Visible = true;
                lblSeconds.Visible = true;
                btnLogin.Enabled = false;
                seconds = 10;
                countDown.Start();
            }
            conn.Close();
        }

        private void addUserControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void countDown_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = seconds--.ToString();
            if(seconds < 0)
            {
                countDown.Stop();
                btnLogin.Enabled = true;
                lblSeconds.Visible = false;
                lblTimer.Visible = false;
            }
        }
    }
}
