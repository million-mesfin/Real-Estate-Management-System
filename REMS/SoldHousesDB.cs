using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class SoldHousesDB
    {
        private int houseId = -1, occupantId = -1;
        private string houseType, payStatus;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";


        public void setHouseId(int num)
        {
            houseId = num;
        }

        public void setOccupantId(int num)
        {
            occupantId = num;
        }

        public void setHouseType(string str)
        {
            houseType = str;
        }

        public void setPayStatus(string str)
        {
            payStatus = str;
        }

        public DataTable viewAllSoldHouses()
        {
            DataTable dtSld = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand ("EXEC [usp_View_All_SoldHouses]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtSld.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtSld;
        }

        public DataTable filterByHousePayment()
        {
            DataTable dtSld = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_FilterByHouseType_PayStatus] '" + houseType + "', '" + payStatus + "'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtSld.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            houseType = null;
            payStatus = null;
            return dtSld;
        }

        public DataTable searchOnHouseId()
        {
            DataTable dtSld = new DataTable();
            try
            {
                if (houseId != -1)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Search_By_HouseID]" + houseId, conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSld.Load(reader);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The House ID must be greater than 0");
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            houseId = -1;
            return dtSld;
        }

        public DataTable searchOnOccId()
        {
            DataTable dtSld = new DataTable();
            try
            {
                if (occupantId != 0)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Search_By_OccupantID]" + occupantId, conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSld.Load(reader);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The Occupant ID must be greater than 0");
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            occupantId = -1;
            return dtSld;
        }
    }
}
