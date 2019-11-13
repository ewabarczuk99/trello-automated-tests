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
	public class EnterPage 
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
		}

		[TearDown]
		public void closeBrowser()
		{
			driver.Close();

		}

	}
}
