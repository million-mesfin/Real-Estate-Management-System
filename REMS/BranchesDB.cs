using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class BranchesDB
    {
        private string region, city, branchType;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public void setRegion(string str)
        {
            region = str;
        }

        public void setCity(string str)
        {
            city = str;
        }

        public void setBranchType(string str)
        {
            branchType = str;
        }

        public DataTable viewAllBranches()
        {
            DataTable dtBrn = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_ViewAllBranches]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtBrn.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtBrn;
        }

        public DataTable filterBranches()
        {
            DataTable dtBrn = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_FilterBranches] '" + region +"','" + city +"','" + branchType +"'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtBrn.Load(reader);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            region = null;
            city = null;
            branchType = null;
            return dtBrn;
        }
    }
}
