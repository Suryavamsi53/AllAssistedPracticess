using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Phase4Section1._4

    //namespace Phase4Section1._9
    {
        [TestClass]
        public class LocateTest
        {
            [TestMethod]
            public void FFSearch()
            {
            var options = new FirefoxOptions();
            options.AcceptInsecureCertificates = true;
            using (var driver = new FirefoxDriver())
                {

                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("https://www.simplilearn.com/");

                    new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                         d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                    var searchBox = driver.FindElement(By.Id("header_srch"));
                    Assert.IsNotNull(searchBox);
                    searchBox.SendKeys("ASP.NET");
                    var searchButton = driver.FindElement(By.ClassName("login"));
                    searchButton.Click();

                    new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                       d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));


                    var pageTitle = driver.PageSource.Contains("Learning on Simplilearn");
                    Assert.IsNotNull(pageTitle);

                    var footerText = driver.FindElement(By.XPath("//footer[@class='footer']"));
                    Assert.IsNotNull(footerText);


                driver.Quit();
            }
            }
        }
    }

