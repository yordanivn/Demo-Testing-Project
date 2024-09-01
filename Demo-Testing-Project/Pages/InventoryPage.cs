using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demo_Testing_Project.Pages
{
    public class InventoryPage : BasePage
	{
		public InventoryPage(IWebDriver driver):base(driver)
		{
		}
		protected readonly By cartLink = By.ClassName("shopping_cart_link");
		protected readonly By productsTitle = By.ClassName("inventory_item_name");
		protected readonly By inventoryItems = By.ClassName("inventory_item");
		protected readonly By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
		protected readonly By removeFromCartButton = By.Id("remove-sauce-labs-backpack");
        public readonly By cartCount = By.ClassName("shopping_cart_badge");

		public void AddToCardByIndex(int itemIdex)
		{
			var itemAddToCardButton = By.XPath($"//div[@class='inventory_item'][{itemIdex}]//button");
			Click(itemAddToCardButton);
		}

		public void ClickCartLink()
		{
			Click(cartLink);
		}
		public bool IsInventoryDisplayed()
		{
			return FindElements(inventoryItems).Any();
		}
		public bool IsPageOpen()
		{
			return driver.Url.Contains("inventory.html");
        }
        public string GetNumberOfAddedItems()
        {
            return GetText(cartCount);
        }
        public bool IsRemoveButtonDisplayed()
        {
            try
            {
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(removeFromCartButton));
                return element.Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsAddToCartButtonDisplayed()
        {
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(addToCartButton));
                return element.Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                // The element was not found on the page
                return false;
            }
        }
    }
}

