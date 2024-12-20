using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class AccountDB
    {
        private string userName, password, fName, lName;
        private int branchId, userType;
        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public AccountDB() { }
        public AccountDB (string userName, string password, string fName, string lName, int userType, int branchId)
        {
            this.userName = userName;
            this.password = password;
            this.fName = fName;
            this.lName = lName;
            this.userType = userType;
            this.branchId = branchId;
        }

        public void addToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_addAccount", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@firstName", fName);
                        cmd.Parameters.AddWithValue("@lastName", lName);
                        cmd.Parameters.AddWithValue("@userType", userType);
                        cmd.Parameters.AddWithValue("@branchId", branchId);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Account Added Successfully");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void changePassword(string nPassword, string userName, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Change_Password", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@newPassword", nPassword);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Account Added Successfully");
                        }
                        else if (row == 0)
                        {
                            MessageBox.Show("The password was not updated");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
