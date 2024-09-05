using System;
namespace Demo_Testing_Project.Tests
{
	public class CheckStep2Tests:BaseTest
	{
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
        }

        //ToDo Tests
        //Check if the displayed product names matches the one in the cart
    }
}

