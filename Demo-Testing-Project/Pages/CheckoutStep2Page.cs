using System;
using OpenQA.Selenium;

namespace Demo_Testing_Project.Pages
{
	public class CheckoutStep2Page:BasePage
	{
		public CheckoutStep2Page(IWebDriver driver):base(driver)
		{
		}
		private readonly By finishButton = By.Id("finish");
		private readonly By cancelButton = By.Id("cancel");

        public bool IsPageOpen()
        {
            return driver.Url.Contains("checkout-step-two.html");
        }
    }
}

