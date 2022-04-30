using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Threading;
using Lab_task_2_Rozetka.Configs;

namespace Lab_task_2_Rozetka.Pages
{
   class BucketPage : BasePage
    {

        public BucketPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class ='cart-receipt__sum-price']//span[contains(@class,'')]")]
        private IWebElement bucketTotal;

        public int getBucketSumm()
        {
            return int.Parse(bucketTotal.Text);
        }

    }
}
