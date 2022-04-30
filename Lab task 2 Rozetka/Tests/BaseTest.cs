using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using System.Collections;
using System.Xml.Linq;
using Lab_task_2_Rozetka.Configs;
using System;
using System.Linq;

namespace Lab_task_2_Rozetka.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"E:\Projects\RozetkaHomeTaskEpamLab\RozetkaHomeTaskEpamLab\Logs\Logs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Log started");
            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            Properties.driver.Manage().Window.Maximize();
            Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }
       public static IEnumerable DataXml => GetDataXml();
        private static IEnumerable GetDataXml()
        {
           var doc = XDocument.Load(@"E:\домашка\EPAM LAB\Lab task 2 Rozetka\Lab task 2 Rozetka\Data\Data.xml");
           return
           from data in doc.Descendants("data")
           let product = data.Attribute("product").Value
           let summ = data.Attribute("summ").Value
           select new object[] { product, summ };
        }

        [TearDown]
        public void TearDown()
        {
            Properties.driver.Close();
            Log.Information("Closed");
        }
      
       
    }
}
