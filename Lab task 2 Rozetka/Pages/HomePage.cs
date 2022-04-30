using Lab_task_2_Rozetka.Configs;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Lab_task_2_Rozetka.Pages

{
        class HomePage : BasePage
    {
        public HomePage()
          {
            PageFactory.InitElements(Properties.driver, this);
          }

            [FindsBy(How = How.XPath, Using = "//input[@class='search-form__input ng-untouched ng-pristine ng-valid']")]
            private readonly IWebElement searchInput;
            
            [FindsBy(How = How.XPath, Using = "//button[contains(@class,'button button_color_green')]")]
            private readonly IWebElement searchButton;

        public void SearchByKeyword(string product)
           {
            searchInput.SendKeys(product);
           }
        public void SearchButtonClick()
           {
             searchButton.Click();
           }
    }
}
