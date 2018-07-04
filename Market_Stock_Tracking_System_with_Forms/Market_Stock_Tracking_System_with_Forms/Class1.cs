using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Stock_Tracking_System_with_Forms
{
    class Product
    {
        private int id;
        private string name;
        private string unit;
        private int quantity;

        public int getID() { return id; }
        public void setID(int id)
        {
            if (id > 0)
                this.id = id;
            else
                this.id = -1;
        }

        public string getName() { return name; }
        public void setName(string name)
        {
            if (name != null)
                this.name = name;
            else
                this.name = "\0";
        }

        public string getUnit() { return unit; }
        public void setUnit(string unit)
        {
            if (unit != "kg" && unit != "g" && unit != "lt"
                && unit != "km" && unit != "m" && unit != "cm"
                && unit != "packet" && unit != "bottle")
            {
                this.unit = unit;
            }
            else
                this.unit = "invalid";
        }

        public int getQuantity() { return quantity; }
        public void setQuantity(int quantity)
        {
            if (quantity >= 0)
                this.quantity = quantity;
            else
                this.quantity = -1;
        }

        public override string ToString()
        {
            return id.ToString() + " " + name + " " + quantity.ToString() + " " + unit;
        }
    }
}
