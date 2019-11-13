using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace trello_automated_tests
{
	class EnterSignUpPage
	{
		IWebDriver driver;

		[SetUp]
		public void startBrowser()
		{
			driver = new ChromeDriver();
		}

		[Test]
		public void test()
		{
			driver.Url = "https://trello.com";
			driver.FindElement(By.CssSelector("body > header > nav > div.float-right.buttons > a.btn.btn-sm.bg-white.font-weight-bold")).Click();
			driver.Url = "https://trello.com/signup";

		}

		[TearDown]
		public void closeBrowser()
		{
			driver.Close();

		}

	}
}
