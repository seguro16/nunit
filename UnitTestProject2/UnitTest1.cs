using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace UnitTestProject2
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting : Hooks
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {

        }


        [Test]
        public void FireGoogleTest()
        {

            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            //Driver.FindElement(By.Name("btnK")).Click();
           //Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                              // "The text selenium does not exist");

        }
        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }

    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void ChromeGoogleTest()
        {

            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
           // Driver.FindElement(By.Name("btnK")).Click();
            //Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                                //"The text ExecuteAutomation does not exist");



        }
        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }

    }

}

