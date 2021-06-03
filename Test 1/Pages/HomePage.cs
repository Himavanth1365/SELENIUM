using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Test_1.Utilities;

namespace Test_1.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            Wait.WaitForElementToBePresent(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);

            // Click Administration
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();
            Thread.Sleep(1500);

            // Click Time & Materials
            IWebElement TimeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterial.Click();
            Thread.Sleep(3000);
        }            
    }
}
