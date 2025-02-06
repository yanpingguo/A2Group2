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
        /// </summary>
        /// <param name="prodId"></param>

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50000)]
        public void ProductId_Input5And10And50000_Verify(int prodId)
        {  
            // Arrange - Define the valid range
            int inputValue = prodId;
            bool expected = true;

            // Act - Check if the product ID is within the range
            bool actual = product.VerifyProductID(inputValue);

            // Assert - Verify the result
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("Apple")]
        [TestCase("Orange")]
        [TestCase("Banana")]
        public void ProductName_InputAppleAndOrangeAndBanana_Verify(string prodName)
        {
            // Arrange - Define invalid cases
            string inputValue = prodName;
            bool expected = true;

            // Act - Check if the product name is invalid
            bool actual = product.VerifyProductName(inputValue);

            // Assert - Verify the name is valid
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Ryjo Kollely Mathew  
        /// </summary>
        /// <param name="itemPrice"></param>
        [TestCase(50)]
        [TestCase(100.01)]
        [TestCase(5000)]
        public void ItemPrice_ShouldBeWithinValidRange(double itemPrice)
        {
            Assert.That(itemPrice, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(5000));
        }

        [TestCase(59)]
        [TestCase(40000)]
        [TestCase(500000)]
        public void StockAmount_ShouldBeWithinValidRange(int stockAmount)
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