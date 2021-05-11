using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{

    public class Test:Webdriver
    {
        
        [SetUp]
       
        public  void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Hello");
            
            
        }

        [Test]
        public void Test1()

        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Onion");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            CustomControl.GetElem("ContentPlaceHolder1_AllMealsCombo", "Papaya");
            //Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Papaya']")).Click();

            Assert.Pass();
        }
    }
}