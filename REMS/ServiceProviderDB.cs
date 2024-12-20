using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class ServiceProviderDB
    {
        private string name, phone, region, city, serviceType;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";


        public void setName(string str)
        {
            name = str;
        }
        public void setPhone(string str)
        {
            phone = str;
        }
        
        public void setRegion(string str)
        {
            region = str;
        }

        public void setCity(string str)
        {
            city = str;
        }
        
        public void setServiceType(string str)
        {
            serviceType = str;
        }

        public DataTable viewAllProviders()
        {
            DataTable dtsp = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_ViewAllProviders]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtsp.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtsp;
        }

        public DataTable searchProviderByName()
        {
            DataTable dtsp = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_SearchProviderByName] '" + name + "'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtsp.Load(reader);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            name = null;
            return dtsp;
        }

        public DataTable searchProviderByPhone()
        {
            DataTable dtsp = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_SearchProviderByPhone] '" + phone + "'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtsp.Load(reader);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            phone = null;
            return dtsp;
        }

        public DataTable filterProvider()
        {
            DataTable dtsp = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_FilterProviders]'" + region +"', '" + city +"', '" + serviceType +"'", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtsp.Load(reader);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            region = null;
            city = null;
            serviceType = null;
            return dtsp;
        }
    }
}
