using System;
namespace Demo_Testing_Project.Tests
{
	public class CheckOutStep1Tests:BaseTest
	{
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutStep1PageLoaded()
        {
            Assert.That(checkoutStep1Page.IsPageOpen(), Is.True, "The checkout step 1 page was not opened");
        }

        public void TestContinueToNextStep()
        {
            checkoutStep1Page.EnterOrderDetails("ala", "bala", "1111");
            Assert.That(CheckoutStep2Page.IsPageOpen(), Is.True, "The checkout step 2 page was not opened");
        }

        [Test]
        public void TestWithEmptyInput()
        {
            checkoutStep1Page.EnterOrderDetails("", "", "");
            string error = checkoutStep1Page.GetErrorMsg();
            Assert.That(error, Is.EqualTo("Error: First Name is required"));
        }

      
        [TestCase("", "aaa", "", "Error: First Name is required")]
        [TestCase("", "", "111", "Error: First Name is required")]
        [TestCase("", "aaa", "1111", "Error: First Name is required")]
        [TestCase("ala", "", "", "Error: Last Name is required")]
        [TestCase("ala", "", "1111", "Error: Last Name is required")]
        [TestCase("ala", "aaa", "", "Error: Postal Code is required")]
        public void TestWithInvalidInputs(string firstName,string lastName, string zipCode,string errorMsg)
        {
            checkoutStep1Page.EnterOrderDetails(firstName, lastName, zipCode);
            string error = checkoutStep1Page.GetErrorMsg();
            Assert.That(error, Is.EqualTo(errorMsg));
        }
    }
}

