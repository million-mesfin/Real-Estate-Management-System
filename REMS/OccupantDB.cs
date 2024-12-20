using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMS
{
    class OccupantDB
    {
        private string name, phone, email, houseType;
        private int houseId; 
        
        public OccupantDB() { }

        public OccupantDB(string name, string pNumber, string email, int houseId, string houseType)
        {
            this.name = name;
            this.phone = pNumber;
            this.email = email;
            this.houseId = houseId;
            this.houseType = houseType;
        }

        public String conString = "Data Source=MILLAS\\SQLEXPRESS;Initial Catalog=" + "Real Estate Managment" + ";Integrated Security=True";

        public void setName (string name)
        {
            this.name = name;
        }

        public void setPhone (string phone)
        {
            this.phone = phone;
        }

        public void setHouseType(string houseType)
        {
            this.houseType = houseType;
        }

        public DataTable viewAllOccupants()
        {
            DataTable dtOti = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("[usp_View_All_OccupantInfo]", conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtOti.Load(reader);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtOti;
        }

        public DataTable fiterOnHouseType()
        {
            DataTable dtOti = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (houseType != null)
                    {
                        MessageBox.Show("non");
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Filter_OnHouseType] '" + houseType + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtOti.Load(reader);
                        }
                    }
                    else
                    {
                        MessageBox.Show("House type is invalid");
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            houseType = null;
            return dtOti;
        }

        public DataTable searchByName()
        {
            DataTable dtOti = new DataTable();
            try
            {
                if (name != null)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Search_By_Name] '" + name + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtOti.Load(reader);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Search term can't be empty. Please enter a search term");
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            name = null;

            return dtOti;
        }

        public DataTable searchByPhone()
        {
            DataTable dtOti = new DataTable();
            try
            {
                if (phone != null)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("EXEC [usp_Search_By_Phone] '" + phone + "'", conn))
                        {
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            dtOti.Load(reader);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Search term can't be empty. Please enter a search term");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            phone = null;

            return dtOti;
        }

        public void addToDB()
        {
            OccupantInfo oi = new OccupantInfo();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_AddOccupantInfo", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phoneNumber", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@houseId", houseId);
                        cmd.Parameters.AddWithValue("@houseType", houseType);

                        int row = cmd.ExecuteNonQuery();
                        if(row > 0)
                        {
                            MessageBox.Show("Occupant info added successfully");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getOccupantInfo(int Oid)
        {
            DataTable dtOcc = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Search_By_ID '" + Oid + "'", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        sda.Fill(dtOcc);

                        if (dtOcc.Rows.Count == 1)
                        {
                            conn.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                        }
                        else
                        {
                            MessageBox.Show("No Occupant was found with the given ID");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dtOcc;
        }

        public void setEdited(int oid)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Edit_Occupant_Info", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@oid", oid);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@houseID", houseId);
                        cmd.Parameters.AddWithValue("@houseType", houseType);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Occupant information edited successfully");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getDeleteOccpantInfo(int oid)
        {
            DataTable dtDelete = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("[usp_Search_By_ID] '" + oid + "'", conn))
                    {

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        dtDelete.Load(reader);

                        if (dtDelete.Rows.Count == 0)
                        {
                            MessageBox.Show("No Occupant was found with the given ID");
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

        public void deleteOccupantInfo(int oid)
        {
            DataTable dtRnt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("[usp_Delete_Occupant_Info]", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@oid", oid);

                        int row = cmd.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Occupant deleted successfully");
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
