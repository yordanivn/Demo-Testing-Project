using System;
namespace Demo_Testing_Project.Tests
{
    [TestFixture]
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
    [TestFixture]
    public class CheckStep2TestsWithPerformanceGlitchUser : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login("performance_glitch_user", "secret_sauce");
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
        }

        //ToDo Tests
        //Check if the displayed product names matches the one in the cart
    }

}

