using System;
using OpenQA.Selenium;

namespace Demo_Testing_Project.Pages
{
	public class CheckoutStep1Page:BasePage
	{
		public CheckoutStep1Page(IWebDriver driver):base(driver)
		{
		}
		private readonly By firstNameField = By.Id("first-name");
		private readonly By lastNameField = By.Id("last-name");
		private readonly By zipCodeField = By.Id("postal-code");
		private readonly By continueButton = By.Id("continue");
		private readonly By cancelButton = By.Id("cancel");
		private readonly By ErrorMsg = By.XPath("//h3[@data-test='error']");
		

        public void EnterOrderDetails(string firstName, string lastName, string zipCode)
        {
            Type(firstNameField, firstName);
            Type(lastNameField, lastName);
            Type(zipCodeField, zipCode);
        }

		public void ClickContinue()
		{
			Click(continueButton);
		}
		public void ClickCancel()
		{
			Click(cancelButton);
		}
		public bool IsPageOpen()
		{
			return driver.Url.Contains("checkout-step-one.html");
		}

    }
}

