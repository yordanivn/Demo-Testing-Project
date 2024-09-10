using System;
namespace Demo_Testing_Project.Tests
{
    [TestFixture]
	public class InventoryTests:BaseTest
	{
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test,Order(1)]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The inventory page has no items displayed");
        }

        [Test,Order(2)]
        public void TestAddTocartButtonIsVisibleBeforeClicking()
        {
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed(), Is.True, "Add to cart button is not displayed");
        }
        [Test,Order(3)]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "Cart item was not added to the cart");
        }
        [Test,Order(4)]
        public void TestsAddToCartButtonChangesToRemoveAfterClick()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.IsRemoveButtonDisplayed(), Is.True, "The remove button was not displayed after clicking add to cart button");
        }

        [Test,Order(5)]
        public void TestCartCountDisplayCorrectNumberOfAddedItmes()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.GetNumberOfAddedItems(), Is.EqualTo("1"));
        }
    }

    [TestFixture]
    public class InventoryTestsProblemUser : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login("problem_user", "secret_sauce");
        }

        [Test, Order(1)]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The inventory page has no items displayed");
        }

        [Test, Order(2)]
        public void TestAddTocartButtonIsVisibleBeforeClicking()
        {
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed(), Is.True, "Add to cart button is not displayed");
        }
        [Test, Order(3)]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "Cart item was not added to the cart");
        }
        [Test, Order(4)]
        public void TestsAddToCartButtonChangesToRemoveAfterClick()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.IsRemoveButtonDisplayed(), Is.True, "The remove button was not displayed after clicking add to cart button");
        }

        [Test, Order(5)]
        public void TestCartCountDisplayCorrectNumberOfAddedItmes()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.GetNumberOfAddedItems(), Is.EqualTo("1"));
        }
        [Test,Order(6)]
        public void TestRemoveButtonShouldRemoveAddedItem()
        {
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickRemoveButton();
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed(), Is.False, "The add button was not displayed after clicking remove button");
        }
    }
    [TestFixture]
    public class InventoryTestsWithPerformanceGlitchUser : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login("performance_glitch_user", "secret_sauce");
        }

        [Test, Order(1)]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The inventory page has no items displayed");
        }

        [Test, Order(2)]
        public void TestAddTocartButtonIsVisibleBeforeClicking()
        {
            Assert.That(inventoryPage.IsAddToCartButtonDisplayed(), Is.True, "Add to cart button is not displayed");
        }
        [Test, Order(3)]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCardByIndex(1);
            inventoryPage.ClickCartLink();
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "Cart item was not added to the cart");
        }
        [Test, Order(4)]
        public void TestsAddToCartButtonChangesToRemoveAfterClick()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.IsRemoveButtonDisplayed(), Is.True, "The remove button was not displayed after clicking add to cart button");
        }

        [Test, Order(5)]
        public void TestCartCountDisplayCorrectNumberOfAddedItmes()
        {
            inventoryPage.AddToCardByIndex(1);
            Assert.That(inventoryPage.GetNumberOfAddedItems(), Is.EqualTo("1"));
        }
    }
}

