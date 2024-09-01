using System;
namespace Demo_Testing_Project.Tests
{
	public class CartTests:BaseTest
	{
		[SetUp]
		public void SetUp()
		{
            Login("standard_user", "secret_sauce");
			inventoryPage.AddToCardByIndex(1);
			inventoryPage.ClickCartLink();
        }

		[Test]
        public void TestCartItemDisplayed()
        {
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

		[Test]
		public void TestClickCheckout()
		{
			cartPage.ClickCheckout();
			Assert.True(checkoutStep1Page.IsPageOpen(), "Not navigated to the correct page");
		}
    }
}

