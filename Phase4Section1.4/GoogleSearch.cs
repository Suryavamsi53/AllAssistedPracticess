using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;


namespace Phase4Section1._4
{
        [TestClass]
        public class GoogleSearch
        {
            [TestMethod]
            public void FFSearch()
            {
                using (var driver = new FirefoxDriver())
                {

                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("https://www.google.com");

             

            }
            }
        }
    }
