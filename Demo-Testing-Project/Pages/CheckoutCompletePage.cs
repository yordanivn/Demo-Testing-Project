using System;
using OpenQA.Selenium;

namespace Demo_Testing_Project.Pages
{
	public class CheckoutCompletePage:BasePage
	{
		public CheckoutCompletePage(IWebDriver driver):base(driver)
		{
		}
		private readonly By completeHeader = By.ClassName("complete-header");
		private readonly By backHomeButton = By.Id("back-to-products");

		public bool IsPageOpen()
		{
			return driver.Url.Contains("checkout-complete.html");
		}
		public bool IsCheckoutComplete()
		{
			return GetText(completeHeader) == "Thank you for your order!";
        }
	}
}

