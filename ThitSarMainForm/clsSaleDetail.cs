using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThitSarMainForm
{
    public class clsSaleDetail
    {
        public clsSaleDetail(int ID, string CodeID, string ItemName, string ItemBrand, string ItemSize, int Price, int Quantity, int Amount)
        {
            this.ID = ID;
            this.CodeID = CodeID;
            this.ItemName = ItemName;
            this.ItemBrand = ItemBrand;
            this.ItemSize = ItemSize;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Amount = Amount;
            //this.Date = Date;

        }
        public int ID { get; set; }
        public string CodeID { get; set; }
        public string ItemName { get; set; }
        public string ItemBrand { get; set; }
        public string ItemSize { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
