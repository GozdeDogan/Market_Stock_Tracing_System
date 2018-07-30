using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockManagementSystem_with_Form
{
    /*[Table(Name = "Product_Card_Table")]*/
    class Product
    {
        /*[Column(IsPrimaryKey = true)]*/
        private int id;
        private string name;
        private string unit;
        private int quantity;
        private int money;
        private string moneyunit;

        public Product()
        {

        }

        public Product(int id, string name, string unit, int quantity, int money, string moneyunit)
        {
            this.id = id;
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
            this.money = money;
            this.moneyunit = moneyunit;
        }

        public int getID()
        {
            return id;
        }

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
            this.unit = unit;
        }

        public int getQuantity() { return quantity; }
        public void setQuantity(int quantity)
        {
            if (quantity >= 0)
                this.quantity = quantity;
            else
                this.quantity = -1;
        }

        public int getMoney() { return money; }
        public void setMoney(int money)
        {
            this.money = money;
        }

        public string getMoneyunit() { return moneyunit; }
        public void setMoneyunit(string moneyunit)
        {
            this.moneyunit = moneyunit;
        }

        public override string ToString()
        {
            return id.ToString() + " " + name + " " + quantity.ToString() + " " + unit;
        }
    }

    /* [Table("STOCK_CARDS_TABLE")]
     public class Product
     {  
         [Column(IsPrimaryKey = true)]
         public int id { get => id; set => id = value; }
         [Column]
         public string name { get => name; set => name = value; }
         [Column]
         public string unit { get => unit; set => unit = value; }
         [Column]
         public int quantity { get => quantity; set => quantity = value; }
     }*/
}
