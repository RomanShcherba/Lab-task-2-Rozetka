using System;
using Lab_task_2_Rozetka.Configs;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Lab_task_2_Rozetka.Pages
{
    class SearchResultsPage : BasePage
    {
        public SearchResultsPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-id='ASUS']")]
        private IWebElement asusCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'buy-button')]")]
        private IWebElement firstProduct;

        [FindsBy(How = How.XPath, Using = "//select[@_ngcontent-rz-client-c184]")]
        private IWebElement sortDropdownMenu;

        [FindsBy(How = How.XPath, Using = "//option[contains(@value,'expensive')]")]
        private IWebElement expensiveValue;

        [FindsBy(How = How.XPath, Using = "//rz-cart//button[contains(@class, 'header__button ng-star-inserted')]")]
        private IWebElement _cartButton;

        public void AsusCheckBoxClick()
        {
            Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            asusCheckBox.Click();
        }

        public void SortDropDown()
        {
            sortDropdownMenu.Click();
        }

        public void ExpensiveClick()
        {
            expensiveValue.Click();
        }

        public void BuyFirstProduct()
        {
            firstProduct.Click();
        }

        public void ClickCartButton()
        {
            _cartButton.Click();
        }
    }
}
