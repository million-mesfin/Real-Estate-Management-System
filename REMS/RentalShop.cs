using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace REMS
{
    class RentalShop
    {
        public int stories;
        public int floorSpace;
        public string region;
        public string city;
        public string builtOn;
        public int contractorId;
        public decimal rent;
        public string status;

        RentalDB rntDB = new RentalDB();

        public RentalShop() { }

        public RentalShop(int stories, int floorSpace, string region, string city, string builtOn, int contractorId, decimal rent, string status)
        {
            this.stories = stories;
            this.floorSpace = floorSpace;
            this.region = region;
            this.city = city;
            this.builtOn = builtOn;
            this.contractorId = contractorId;
            this.rent = rent;
            this.status = status;
        }

        public void setForm(int shopId)
        {
            DataTable dtEdit = rntDB.getRentalInfo(shopId);

            region = (string)dtEdit.Rows[0][1];
            city = (string)dtEdit.Rows[0][2];
            rent = (decimal)dtEdit.Rows[0][3];
            stories = (int)dtEdit.Rows[0][4];
            floorSpace = (int)dtEdit.Rows[0][5];
            contractorId = (int)dtEdit.Rows[0][6];
            DateTime date = (DateTime)dtEdit.Rows[0][7];
            builtOn = date.ToString();
            status = (string)dtEdit.Rows[0][8];
        }
    }
}
