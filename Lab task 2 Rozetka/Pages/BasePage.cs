using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using Lab_task_2_Rozetka.Configs;



namespace Lab_task_2_Rozetka.Pages
{
        class BasePage
    {
        
         public BasePage()
         {
             PageFactory.InitElements(Properties.driver, this);
         }

    }
}
