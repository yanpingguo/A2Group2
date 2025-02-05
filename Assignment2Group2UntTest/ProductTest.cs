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


    }
}