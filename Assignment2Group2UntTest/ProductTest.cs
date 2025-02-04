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

        
    }
}