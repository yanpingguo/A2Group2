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

        /*
        * Product ID: 5 - 50000
          Price: $5 - $5000 
          Stock: 5 - 500000
        */
        public Product(int prodId, string prodName, double itemPrice, int stockAmount)
        {
            VerifyProductID(prodId);
            VerifyItemPrice(itemPrice);
            VerifyStockAmount(stockAmount);
             ProdID = prodId;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public bool VerifyProductID(int prodId)
        {
            if (prodId < 5 || prodId > 50000)
            {
                throw new ArgumentException("Product ID have to between 5 and 50000");
            }
            return true;
        }

        public bool VerifyProductName(string prodName)
        {
            if(!string.IsNullOrWhiteSpace(prodName) && prodName != "\t")
            {
                return true;
            }
            else
            {
                throw new ArgumentException("prodName should not write null or white space or line feed");
            }
        }

        public bool VerifyItemPrice(double itemPrice)
        {
            if (itemPrice < 5 || itemPrice > 5000)
            {
                throw new ArgumentException("itemPrice have to between 5 and 5000");
            }
            return true;
        }

        public bool VerifyStockAmount(int stockAmount)
        {
            if (stockAmount < 5 || stockAmount > 500000)
            {
                throw new ArgumentException("stock amount have to between 5 and 500000");
            }
            return true;
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
