using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class SplitLevelDB
    {
        private string region;
        private string city;
        private int noBedroom = -1;
        private string status;
        private int noFloors = -1;
        private int contractorId = -1;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public void setRegion (string str)
        {
            region = str;
        }
        public void setCity(string str)
        {
            city = str;
        }
        public void setNoBedroom(int num)
        {
            noBedroom = num;
        }
        public void setStatus(string str)
        {
            status = str;
        }
        public void setFloors(int num)
        {
            noFloors = num;
        }
        public void setContractorId(int num)
        {
            contractorId = num;
        }

        public DataTable viewSplHouses()
        {
            DataTable dtSpl = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_Show_All_SplitLevel_Houses]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtSpl.Load(reader);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtSpl;
        }

        public DataTable filterSplHouses()
        {
            DataTable dtSpl = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    //if all of the number values are given
                    if (noBedroom != -1 && noFloors != -1 && contractorId != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', '" + noFloors +"', '" + noBedroom +"', '" + status + "', '" + contractorId +"'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if only number of floors is given
                    if (noBedroom == -1 && noFloors != -1 && contractorId == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', '" + noFloors + "', DEFAULT, '" + status + "', DEFAULT", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if only number of bedrooms are given
                    if (noBedroom != -1 && noFloors == -1 && contractorId == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', DEFAULT, '" + noBedroom + "', '" + status + "', DEFAULT", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if only contractor ID is given
                    if (noBedroom == -1 && noFloors == -1 && contractorId != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', DEFAULT, DEFAULT, '" + status + "', '" + contractorId + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if number of floor and Contractor ID is given
                    if (noBedroom == -1 && noFloors != -1 && contractorId != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', '" + noFloors + "', DEFAULT, '" + status + "', '" + contractorId + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //number of number of bedroom and contractor ID is given
                    if (noBedroom != -1 && noFloors == -1 && contractorId != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', DEFAULT, '" + noBedroom + "', '" + status + "', '" + contractorId + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if number of bedroom and number of floor is given
                    if (noBedroom != -1 && noFloors != -1 && contractorId == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', '" + noFloors + "', '" + noBedroom + "', '" + status + "', DEFAULT", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                    //if all of the number values are not given
                    if (noBedroom == -1 && noFloors == -1 && contractorId == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_SplitLevel_Houses] '" + region + "', '" + city + "', DEFAULT, DEFAULT, '" + status + "', DEFAULT", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtSpl.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            region = null;
            city = null;
            noBedroom = -1;
            status = null;
            noFloors = -1;
            contractorId = -1;

            return dtSpl;
        }
    }
}
