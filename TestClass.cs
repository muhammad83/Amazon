using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace selenium
{
    [TestFixture]
    public class TestClass
    {
        [Test]        
        public void AssertEqualIpadFirstReturnedPrice()
        {
            Amazon.OpenHomePage();
            Amazon.Searchfor("Ipad");

            var price = Amazon.GetFirstResultPrice();

            Assert.AreEqual(305.00, price);
            Amazon.CloseBrowser();
        }

        [Test]
        public void CountElementsAndAssertNotEqualLastPrice()
        {
            Amazon.OpenHomePage();
            Amazon.Searchfor("Ipad");

            var totalResults = Amazon.GetResultCount();

            System.Diagnostics.Trace.WriteLine("Total results returned = " + totalResults);

            var lastItemPrice = Amazon.GetLastResultsPrice(totalResults - 1);

            Assert.AreNotEqual(10.00, lastItemPrice);
            Amazon.CloseBrowser();
            
                
        }
    }
}
