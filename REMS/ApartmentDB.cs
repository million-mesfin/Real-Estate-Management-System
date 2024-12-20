using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace REMS
{
    class ApartmentDB
    {
        public string region;
        public string city;
        public int no_bedrooms = -1;
        public string status;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public void setRegion(string str)
        {
            region = str;
        }

        public void setCity(string str)
        {
            city = str;
        }

        public void setNoBedrooms(int num)
        {
            no_bedrooms = num;
        }

        public void setStatus(string str)
        {
            status = str;
        }
    
        public DataTable viewApartments()
        {
            DataTable dtApt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand ("EXEC [usp_show_All_Apartments]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtApt.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtApt;
        }

        public DataTable filterApartments()
        {
            DataTable dtApt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (no_bedrooms.Equals(-1))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_Apartments_Table] '" + region +"', '" + city +"', DEFAULT, '" + status +"'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtApt.Load(reader);
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_Apartments_Table] '" + region + "', '" + city + "', " + no_bedrooms + ", '" + status + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtApt.Load(reader);
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtApt;
        }
    
    }
}
