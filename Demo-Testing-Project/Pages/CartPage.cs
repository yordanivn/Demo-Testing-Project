using System;
using OpenQA.Selenium;

namespace Demo_Testing_Project.Pages
{
	public class CartPage:BasePage
	{
        public CartPage(IWebDriver driver):base(driver)
		{
		}
		private readonly By cartItem = By.CssSelector(".cart_item");
		private readonly By checkoutButton = By.Id("checkout");
		private readonly By removeButton = By.Id("remove-sauce-labs-backpack");
		private readonly By continueShoppingButton = By.Id("continue-shopping");



		public bool IsCartItemDisplayed()
		{
			return FindElement(cartItem).Displayed;
		}

		public void ClickCheckout()
		{
			Click(checkoutButton);
		}

		public void ClickRemove()
		{
			Click(removeButton);
		}
		public void ClickContinueShopping()
		{
			Click(continueShoppingButton);
		}

	}
}

