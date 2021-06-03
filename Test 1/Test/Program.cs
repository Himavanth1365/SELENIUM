using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Test_1.Pages;
using Test_1.Utilities;

namespace Test_1
{
    [TestFixture]
    class Program : CommonDriver
    {
        //static void Main(string[] args)
        //{
        //}
        [SetUp]
        public void LoginToTrunUp()
        {
            // Launch Chrome Browser
            driver = new ChromeDriver(@"E:\SELENIUM\Test 1\");

            // Create object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);
            
        }

        [Test]
        public void EditTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);
           
        }

        [Test]
        public void DeleteTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }

        [TearDown]
        public void TestClosur()
        {
            // Closing down the steps
            driver.Quit();
        }

    }
}
