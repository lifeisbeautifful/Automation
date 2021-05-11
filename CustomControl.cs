using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class CustomControl:Webdriver
    {
      public static void GetElem(string control,string name)
        {
            IWebElement Control = Driver.FindElement(By.Id($"{control}-awed"));
            Control.Clear();
            Control.SendKeys(name);
            Driver.FindElement(By.XPath($"//div[@id='{control}-dropmenu']//li[text()='{name}']")).Click();
        }
    }
}
