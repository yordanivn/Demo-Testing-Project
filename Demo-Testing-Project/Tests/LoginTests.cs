using System;
namespace Demo_Testing_Project.Tests
{
	public class LoginTests:BaseTest
	{
		[Test]
		public void TestWithValidCredentials()
		{
            Login("standard_user", "secret_sauce");
			Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The inventory page is not loaded after successful login");
        }

		[Test]
		public void TestWithInvalidCredentials()
		{
            Login("aaaa", "secret_sauce");
			string error = loginPage.GetErrorMessage();
			Assert.That(error.Contains("Epic sadface: Username and password do not match any user in this service"));
        }
		[Test]
		public void TestWitLockedOutUser()
		{
            Login("locked_out_user", "secret_sauce");
            string error = loginPage.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface: Sorry, this user has been locked out."));
        }
		[Test]
		public void TestWithNoUserName()
		{
            Login("", "secret_sauce");
            string error = loginPage.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface: Username is required"));
        }
        [Test]
        public void TestWithNoPassword()
        {
            Login("standard_user", "");
            string error = loginPage.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface: Password is required"));
        }

    }
}

