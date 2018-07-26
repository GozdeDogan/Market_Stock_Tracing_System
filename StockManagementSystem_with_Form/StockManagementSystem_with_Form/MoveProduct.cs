using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem_with_Form
{
    class MoveProduct
    {
        private int MoveProductID;
        private string MoveType;
        private DateTime MoveDate;
        private int MoveQuantity;
        private string MoveQuantityUnit;

        public MoveProduct(int MoveProductID, string MoveType, DateTime MoveDate, int MoveQuantity, string MoveQuantityUnit)
        {
            this.MoveProductID = MoveProductID;
            this.MoveType = MoveType;
            this.MoveDate = MoveDate;
            this.MoveQuantity = MoveQuantity;
            this.MoveQuantityUnit = MoveQuantityUnit;
        }

        public int getMoveProductID() { return MoveProductID; }
        public void setMoveProductID(int MoveProductID) { this.MoveProductID = MoveProductID;  }

        public string getMoveType() { return MoveType; }
        public void setMoveType(string MoveType) { this.MoveType = MoveType; }

        public DateTime getMoveDate() { return MoveDate; }
        public void setMoveDate(DateTime MoveDate) { this.MoveDate = MoveDate; }


        public int getMoveQuantity() { return MoveQuantity; }
        public void setMoveQuantity(int MoveQuantity) { this.MoveQuantity = MoveQuantity; }

        public string getMoveQuantityUnit() { return MoveQuantityUnit; }
        public void setMoveQuantityUnit(string MoveQuantityUnit) { this.MoveQuantityUnit = MoveQuantityUnit; }

        public override string ToString()
        {
            return "MoveProductID:" + MoveProductID.ToString() + "\t MoveType:" + MoveType + "\t MoveDate:" + MoveDate.ToString() + "\t MoveQuantity:" + MoveQuantity.ToString();
        }
    }
}
