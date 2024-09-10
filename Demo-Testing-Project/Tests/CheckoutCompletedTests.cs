using System;
namespace Demo_Testing_Project.Tests
{
    [TestFixture]
	public class CheckoutCompletedTests:BaseTest
	{
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
            checkoutStep1Page.EnterOrderDetails("firstName", "lastName", "1111");
            CheckoutStep2Page.ClickFinish();
        }

        [Test]
        public void TestCheckoutCompletedMessage()
        {
            Assert.That(checkoutCompletePage.IsPageOpen(),Is.True, "The checkout complete page was not opened");
            Assert.That(checkoutCompletePage.IsCheckoutComplete(), Is.True, "The checkout was not completed");
        }

        [Test]
        public void TestBackHomeButton()
        {
            checkoutCompletePage.ClickBackToHome();
            Assert.That(inventoryPage.IsPageOpen(), Is.True, "The button did not redirect to inventory page");
        }

    }

    [TestFixture]
    public class CheckoutCompletedTestsWithPerformanceGlitchUser : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login("performance_glitch_user", "secret_sauce");
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
            checkoutStep1Page.EnterOrderDetails("firstName", "lastName", "1111");
            CheckoutStep2Page.ClickFinish();
        }

        [Test]
        public void TestCheckoutCompletedMessage()
        {
            Assert.That(checkoutCompletePage.IsPageOpen(), Is.True, "The checkout complete page was not opened");
            Assert.That(checkoutCompletePage.IsCheckoutComplete(), Is.True, "The checkout was not completed");
        }

        [Test]
        public void TestBackHomeButton()
        {
            checkoutCompletePage.ClickBackToHome();
            Assert.That(inventoryPage.IsPageOpen(), Is.True, "The button did not redirect to inventory page");
        }

    }
}

