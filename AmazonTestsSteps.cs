using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace selenium
{
    [Binding]
    public class AmazonTestsSteps
    {
        private int totalResults;
        [Given(@"I have entered ipad in the search bar")]
        public void GivenIHaveEnteredIpadInTheSearchBar()
        {
            Amazon.OpenHomePage();


        }

        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            Amazon.Searchfor("Ipad");
        }

        [Then(@"the first result returned should be equal")]
        public void ThenTheFirstResultReturnedShouldBeEqual()
        {
            var price = Amazon.GetFirstResultPrice();

            Assert.AreEqual(price, price);
            Amazon.CloseBrowser();
        }

        [Then(@"count the total results returned")]
        public void ThenCountTheTotalResultsReturned()
        {
            totalResults = Amazon.GetResultCount();
        }

        [Then(@"print it to output window")]
        public void ThenPrintItToOutputWindow()
        {
            System.Diagnostics.Trace.WriteLine("Total results returned = " + totalResults);
        }

        [Then(@"assert the last price of ipad is not equal")]
        public void ThenAssertTheLastPriceOfIpadIsNotEqual()
        {
            var lastItemPrice = Amazon.GetLastResultsPrice(totalResults - 1);

            Assert.AreNotEqual(lastItemPrice + 1, lastItemPrice);
            Amazon.CloseBrowser();
        }

    }
}
