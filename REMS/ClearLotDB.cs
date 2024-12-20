using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace REMS
{
    class ClearLotDB
    {
        private string region, city, permitStatus;
        private int size;

        public ClearLotDB() { }
        public ClearLotDB(int size, string region, string city, string permitStatus)
        {
            this.size = size;
            this.region = region;
            this.city = city;
            this.permitStatus = permitStatus;
        }

        public string conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public void setRegion(string str)
        {
            region = str;
        }

        public void setCity(string str)
        { 
            city = str;
        }

        public void setPermit(string str)
        {
            permitStatus= str;
        }

        public DataTable viewAllClearLots()
        {
            DataTable dtClp = new DataTable();
            try
            {
                using(SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("EXEC [usp_View_All_Clear_Lots]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtClp.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtClp;
        }

        public DataTable filterClearLots()
        {
            DataTable dtClp = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_Clear_Plot] '" + region + "', '" + city + "', '" + permitStatus + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtClp.Load(reader);
                        }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            region = null;
            city = null;
            permitStatus = null;
            return dtClp;
        }

        public void addToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Add_Clear_Lot", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@size", size);
                        cmd.Parameters.AddWithValue("@region", region);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@permitStatus", permitStatus);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Clear Lot added successfully");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getLotInfo(int lotId)
        {
            DataTable dtEdit = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Search_Lot_ByID '" + lotId + "'", conn))
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

        public void setEditedValue(int clId, ClearLot cl)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Edit_Clea_Lot", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clid", clId);
                        cmd.Parameters.AddWithValue("@size", cl.size);
                        cmd.Parameters.AddWithValue("@region", cl.region);
                        cmd.Parameters.AddWithValue("@city", cl.city);
                        cmd.Parameters.AddWithValue("@permitStatus", cl.permitStatus);

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

        public DataTable getDeleteLotInfo(int clid)
        {
            DataTable dtDelete = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Search_Lot_ByID", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clid", clid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtDelete.Load(reader);

                        if (dtDelete.Rows.Count == 0)
                        {
                            MessageBox.Show("No Lot was found with the given ID");
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

        public DataTable DeleteLotInfo(int clid)
        {
            DataTable dtDelete = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Delete_Lot_Info", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clid", clid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtDelete.Load(reader);

                        if (dtDelete.Rows.Count == 0)
                        {
                            MessageBox.Show("Lot deleted successfully");
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
    }
}
