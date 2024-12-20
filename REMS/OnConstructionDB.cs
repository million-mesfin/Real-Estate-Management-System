using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class OnConstructionDB
    {
        private string region, city, houseType;
        private int contractorId;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";


        public void setRegion(string str)
        {
            region = str;
        }
        public void setCity(string str)
        {
            city = str;
        }
        public void setHouseType(string str)
        {
            houseType = str;
        }
        public void setContractorId(int num)
        {
            contractorId = num;
        }

        public DataTable viewAllOnConstruction()
        {
            DataTable dtOco = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_ViewAllOnConstruction]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtOco.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtOco;
        }

        public DataTable filterOnConstruction()
        {
            DataTable dtOco = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_FilterOnConstruction] '" + region +"', '" + city +"', '" + houseType +"'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtOco.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            region = null;
            city = null;
            houseType = null;
            return dtOco;
        }
    }
}
