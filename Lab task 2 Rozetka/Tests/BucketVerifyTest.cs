using Lab_task_2_Rozetka.Configs;
using NUnit.Framework;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using Lab_task_2_Rozetka.Pages;

namespace Lab_task_2_Rozetka.Tests
{
    class BucketVerifyTest : BaseTest
    {

        [Test]
        [TestCaseSource("DataXml")]
        public void BucketVerify(string product, string summ)
        {
            HomePage homePage = new HomePage();
            homePage.SearchByKeyword(product);
            homePage.SearchButtonClick();
            SearchResultsPage searchResultsPage = new SearchResultsPage();
            searchResultsPage.AsusCheckBoxClick();
            searchResultsPage.SortDropDown();
            searchResultsPage.ExpensiveClick();
            searchResultsPage.SortDropDown();
            searchResultsPage.BuyFirstProduct();
            searchResultsPage.ClickCartButton();
            BucketPage bucketPage = new BucketPage();
            int total = bucketPage.getBucketSumm();
            Assert.That(total, Is.LessThan(Int32.Parse(summ)));

        }
    }
}
