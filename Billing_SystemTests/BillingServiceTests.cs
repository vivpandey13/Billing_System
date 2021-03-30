using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Billing_System.Tests
{
    [TestClass()]
    public class BillingServiceTests
    {
        [TestMethod()]
        public void CalculateTotalPriceTest()
        {
            //Arrange.
            string input = "[Apple, Apple, Avocado, Apple, Apple]";
            BillingService billingService = new BillingService(input);

            //Act.
            var totalPrice = billingService.CalculateTotalPrice();

            //Assert.
            Assert.AreEqual(totalPrice, 0.85m);
        }
    }
}