using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    public static class Amazon
    {
        private static IWebDriver browser = new FirefoxDriver();

        public static void OpenHomePage()
        {
            browser.Navigate().GoToUrl("http:\\www.amazon.co.uk");
        }

        public static void Searchfor(string searchWord)
        {
            var searchBox = browser.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(searchWord);

            browser.FindElement(By.ClassName("nav-submit-input")).Click();
        }

        public static decimal GetFirstResultPrice()
        {
            return Convert.ToDecimal(browser.FindElement(By.ClassName("bld")).Text.Substring(1));
        }

        public static int GetResultCount()
        {
            return browser.FindElements(By.ClassName("rslt")).Count() + 1;
        }

        public static decimal GetLastResultsPrice(int element)
        {
            var priceToFind = "result_" + element;
            return Convert.ToDecimal(browser.FindElement(By.XPath("//div[@id='" + priceToFind + "']/ul[@class='rsltL']/*/a/span")).Text.Substring(1));
        }

        public static void CloseBrowser()
        {
            browser.Close();
        }
    }
}
