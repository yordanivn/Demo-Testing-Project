using System;
using OpenQA.Selenium;

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

		public void AddToCardByIndex(int itemIdex)
		{
			var itemAddToCardButton = By.XPath($"//div[@class='inventory_item'][{itemIdex}]");
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
    }
}

