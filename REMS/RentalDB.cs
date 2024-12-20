using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace REMS
{
    class RentalDB
    {
        public string region;
        public string city;
        public string builtOn;
        public int contractorId = 0, stories, floorSpace, shopId;
        public decimal rent;
        public string status;

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public RentalDB() { }

        public RentalDB(string region, string city, string builtOn, decimal rent,  int contractorId, int stories, int floorSpace, string status)
        {
            this.region = region;
            this.city = city;
            this.builtOn = builtOn;
            this.rent = rent;
            this.contractorId = contractorId;
            this.stories = stories;
            this.floorSpace = floorSpace;
            this.status = status;
        }

        public void setRegion(string str)
        {
            region = str;
        }

        public void setCity(string str)
        {
            city = str;
        }

        public void setContractorId(int id)
        {
            contractorId = id;
        }

        public void setStatus(string str)
        {
            status = str;
        }

        public DataTable viewRentalShops()
        {
            DataTable dtRental = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_Show_All_Rental_Shops]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtRental.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return dtRental;
        }

        public DataTable filterRentalShops()
        {
            DataTable dtRnt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (contractorId.Equals(0))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_Rental_Shops_Table] '" + region + "','" + city + "', DEFAULT, '" + status + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtRnt.Load(reader);
                        }
                    }
                    else
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_Rental_Shops_Table] '" + region + "','" + city + "'," + contractorId + ", '" + status + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtRnt.Load(reader);
                        }

                    region = null;
                    city = null;
                    contractorId = 0;
                    status = null;
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return dtRnt;
        }

        //Addes the provided info to the database
        public void addToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_AddRentalShop", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@region", region);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@rent", rent);
                        cmd.Parameters.AddWithValue("@stories", stories);
                        cmd.Parameters.AddWithValue("@floorSpace", floorSpace);
                        cmd.Parameters.AddWithValue("@contractorId", contractorId);
                        cmd.Parameters.AddWithValue("@builtOn", builtOn);
                        cmd.Parameters.AddWithValue("@status", status);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("House added successfully");
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getRentalInfo(int shopId)
        {
            DataTable dtEdit = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("[usp_searchRentalShopInfo] '" + shopId + "'", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        
                        sda.Fill(dtEdit);

                        if (dtEdit.Rows.Count == 1)
                        {
                            conn.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                        }
                        else
                        {
                            MessageBox.Show("No shop was found with the given ID");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return dtEdit;
        }

        public void setEditedValue(int shopId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_editRentalShopInfo", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@shopId", shopId);
                        cmd.Parameters.AddWithValue("@region", region);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@rent", rent);
                        cmd.Parameters.AddWithValue("@stories", stories);
                        cmd.Parameters.AddWithValue("@floorSpace", floorSpace);
                        cmd.Parameters.AddWithValue("@contractorId", contractorId);
                        cmd.Parameters.AddWithValue("@builtOn", builtOn);
                        cmd.Parameters.AddWithValue("@status", status);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Shop information edited successfully");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getDeleteHouseInfo(int shopId)
        {
            DataTable dtDelete = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("[usp_searchRentalShopInfo] '" + shopId + "'", conn))
                    {
                            conn.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            dtDelete.Load(reader);

                        if (dtDelete.Rows.Count == 0)
                        {
                            MessageBox.Show("No shop was found with the given ID");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtDelete;
        }

        public void deleteRentalInfo(int shopId)
        {
            DataTable dtRnt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_deleteRentalShopInfo", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@shopId", shopId);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("House deleted successfully");
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
