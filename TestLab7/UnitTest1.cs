using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace TestLab7
{
    public class Tests
    {
        private IWebDriver webDriver;


        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
          
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit(); 
        }

        [Test]
        public void LoginButtonTest()
        {
            webDriver.Url = "https://mail.ru/";
            IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id=\"mailbox\"]/div[1]/button)]")); 
            loginButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("auth")); 
        }

        [Test]
        public void RegistrationButtonTest()
        {
            webDriver.Url = "https://mail.ru/";
            IWebElement registrationButton = webDriver.FindElement(By.XPath("//*[@id=\"ph-whiteline\"]/div/div[2]/div[1])]")); 
            registrationButton.Click(); 
            Assert.IsTrue(webDriver.Url.Contains("signup")); 
        }

        [Test]
        public void SearchButtonTest()
        {
            webDriver.Url = "https://mail.ru/";
            IWebElement searchBox = webDriver.FindElement(By.XPath("/html/body/form/input[1]")); 
            searchBox.SendKeys("новости"); 
            IWebElement searchButton = webDriver.FindElement(By.XPath("//*[@id=\"wp6Gjw8U\"]/div[1]/div[5]/div/form/div[3]/button]")); 
            searchButton.Click(); 
            Assert.IsTrue(webDriver.Url.Contains("search")); 
        }

        [Test]
        public void CloudButtonTest()
        {
            webDriver.Url = "https://mail.ru/";
            IWebElement newsButton = webDriver.FindElement(By.XPath("//*[@id=\"ph-whiteline\"]/div/nav/ul/li[3]/a]"));
            newsButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("cloud")); 
        }

        [Test]
        public void MailButtonTest()
        {
            webDriver.Url = "https://mail.ru/";
            IWebElement mailButton = webDriver.FindElement(By.XPath("//*[@id=\"ph-whiteline\"]/div/nav/ul/li[2]/a)]")); 
            mailButton.Click(); 
            Assert.IsTrue(webDriver.Url.Contains("mail")); 
        }
    }
}

