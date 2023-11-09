using System.Security.Cryptography;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest;

[TestClass]
public class UnitTest1
{
    private static readonly string DriverDirectory = "/Users/daoudahmad/chromeSelenium";
    private static IWebDriver _driver;

    [ClassInitialize]
    public static void Setup(TestContext context)
    {
        _driver = new ChromeDriver(DriverDirectory);
        //_driver = new FirefoxDriver(DriverDirectory);
        // _driver = new EdgeDriver(DriverDirectory);
    }

    //[ClassCleanup]
    //public static void TearDown()
    //{
    //    _driver.Dispose();
    //}

    [TestMethod]
    public void TestMethod1()
    {
        //_driver.Navigate().GoToUrl("http://localhost:5503/index.htm");
        _driver.Navigate().GoToUrl("http://127.0.0.1:3000/Index.html");
        Assert.AreEqual("MusicRecordGet", _driver.Title);
    }
}
