using Assignment2Group2;
using NUnit.Framework;

namespace Assignment2Group2UntTest
{
    public class Tests
    {
        public Product product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            product = new Product(6, "Banana", 7, 2000);

        }
        /// <summary>
        /// yanping guo（Anna）
        /// write ValidateProductId and ValidateProductName method
        /// </summary>
        /// <param name="prodId"></param>

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50000)]
        public void ValidateProductId(int prodId)
        {
            Assert.That(prodId, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(50000));
        }

        [TestCase("Apple")]
        [TestCase("Orange")]
        [TestCase("Banana")]
        public void ValidateProductName(string prodName)
        {
            Assert.That(prodName, Is.Not.Null.And.Not.Empty.And.Not.EqualTo(" ").And.Not.EqualTo("\t"));
        }

        /// <summary>
        /// Ryjo Kollely Mathew  
        /// wirte ValidateItemPrice and ValidateStockAmount method 
        /// </summary>
        /// <param name="itemPrice"></param>
        [TestCase(50)]
        [TestCase(100.01)]
        [TestCase(5000)]
        public void ValidateItemPrice(double itemPrice)
        {
            Assert.That(itemPrice, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(5000));
        }

        [TestCase(59)]
        [TestCase(40000)]
        [TestCase(500000)]
        public void ValidateStockAmount(int stockAmount)
        {
            Assert.That(stockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));
        }


        // Meet Parmar
        [TestCase(5)]
        [TestCase(4689)]
        [TestCase(49000)]
        public void IncreaseStock_ShouldWorkProperly(int stockAmount)
        {
            // Arrange- Get initial stock
            int initialStock = product.StockAmount;

            // Act - Increase the stock
            product.IncreaseStock(stockAmount);
            int updatedStock = product.StockAmount;

            // Assert - Verify the stock increased correctly
            Assert.That(updatedStock, Is.EqualTo(initialStock + stockAmount));
            Assert.That(updatedStock, Is.InRange(5, 500000));
        }

        [TestCase(66)]
        [TestCase(899)]
        [TestCase(370)]
        public void DecreaseStock_ShouldWorkProperly(int stockAmount)
        {
            // Arrange - Ensure enough stock is available
            product.IncreaseStock(1000);
            int initialStock = product.StockAmount;

            // Act - Decrease the stock
            product.DecreaseStock(stockAmount);
            int updatedStock = product.StockAmount;

            // Assert - Verify the stock decreased correctly
            Assert.That(updatedStock, Is.EqualTo(initialStock - stockAmount));
            Assert.That(updatedStock, Is.InRange(5, 500000));
        }


    }
}