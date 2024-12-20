using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace REMS
{
    class ClearLot
    {
        public string region, city, permitStatus;
        public int size;

        public ClearLot() { }

        public ClearLot (int size, string region, string city, string permitStatus)
        {
            this.size = size;
            this.region = region;
            this.city = city;
            this.permitStatus = permitStatus;
        }

        public void setToDB()
        {
            ClearLotDB cldb = new ClearLotDB(size, region, city, permitStatus);
            cldb.addToDB();
        }

        public void setToForm(int lotId)
        {
            ClearLotDB cldb = new ClearLotDB();

            DataTable dtEdit = cldb.getLotInfo(lotId);
            size = (int)dtEdit.Rows[0][1];
            region = (string)dtEdit.Rows[0][2];
            city = (string)dtEdit.Rows[0][3];
            permitStatus = (string)dtEdit.Rows[0][4];
        }

        public void setEditToDB(int clId, ClearLot cl)
        {
            ClearLotDB cldb = new ClearLotDB();
            cldb.setEditedValue(clId, cl);
        }
    }
}
