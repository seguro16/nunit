using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace UnitTestProject2
{

   public enum BrowserType
    {
        Chrome,
        Firefox,
        IE


    }

    [TestFixture]
    public class Hooks : Base
    {
        private BrowserType _browserType;


        public Hooks(BrowserType browser)
        {
            //Driver = new FirefoxDriver();
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }
        
            private void ChooseDriverInstance(BrowserType browserType)
            {
                if (browserType == BrowserType.Chrome)
                    Driver = new ChromeDriver();
                else if (browserType == BrowserType.Firefox)
                    Driver = new FirefoxDriver();
            }

        



    }
}
