using System;
using Demo_Testing_Project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Demo_Testing_Project.Tests
{
	public class BaseTest
	{
		protected IWebDriver driver;
		protected LoginPage loginPage;
		protected CartPage cartPage;
		protected InventoryPage inventoryPage;
		protected CheckoutStep1Page checkoutStep1Page;
		protected CheckoutStep2Page CheckoutStep2Page;
		protected CheckoutCompletePage checkoutCompletePage;

		[SetUp]
		public void SetUp()
		{
			
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--disable-search-engine-choice-screen");
            chromeOptions.AddArgument("--headless");  // Enable headless mode
            chromeOptions.AddArgument("--no-sandbox");  // Required for running in CI environments
            chromeOptions.AddArgument("--disable-dev-shm-usage");  // Prevents out of memory issues
            chromeOptions.AddArgument("--disable-gpu");  // Disable GPU for headless mode
            chromeOptions.AddArgument("--window-size=1920x1080");  // Set a window size to ensure correct layout

            driver = new ChromeDriver(chromeOptions);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			loginPage = new LoginPage(driver);
			cartPage = new CartPage(driver);
			inventoryPage = new InventoryPage(driver);
			checkoutStep1Page = new CheckoutStep1Page(driver);
			CheckoutStep2Page = new CheckoutStep2Page(driver);
			checkoutCompletePage = new CheckoutCompletePage(driver);

        }

		[TearDown]
		public void TearDown()
		{
			if (driver != null)
			{
				driver.Quit();
				driver.Dispose();
			}
		}

		protected void Login(string username, string password)
		{
			driver.Navigate().GoToUrl("https://www.saucedemo.com/");
			loginPage.LoginUser(username, password);
		}
	}
}

