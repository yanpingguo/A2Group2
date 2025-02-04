using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Group2
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product() { }
        public Product(int prodId, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodId;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int stockAmount)
        {
            StockAmount += stockAmount;
        }

        public void DecreaseStock(int stockAmount)
        {
            StockAmount -= stockAmount;
        }

    }
}
